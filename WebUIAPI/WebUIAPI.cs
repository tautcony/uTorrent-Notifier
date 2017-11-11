using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.IO;
using System.Windows.Forms;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace uTorrentNotifier
{
    public partial class WebUiapi : IDisposable
    {
        public Config Config;
        private readonly Timer _timer;
        private string _token;
        private readonly CookieContainer _cookies;
        private readonly TorrentListing _torrents;

        public WebUiapi(Config config)
        {
            Config    = config;
            _torrents = new TorrentListing();
            _timer    = new Timer();
            _cookies  = new CookieContainer();

            _timer.Tick += Timer_Tick;
            _timer.Interval = 5000;
        }

        public void Start()
        {
            _token = GetToken();

            if (_token == null)
                return;

            _timer.Start();
            Timer_Tick(null, null);
        }

        public void Stop()
        {
            _timer.Stop();
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            _torrents.Current = ListTorrents();
            Debug.WriteLine($"Torrents count: {_torrents.Current.Count}");
            if (_torrents.Last != null)
            {
                var completed = FindDone();
                var added = FindNew();

                if (completed.Count > 0)
                    DownloadComplete?.Invoke(completed);

                if (added.Count > 0)
                    TorrentAdded?.Invoke(added);
            }
        }

        private string GetToken()
        {
            try
            {
                if (string.IsNullOrEmpty(Config.Uri))
                    return null;
                var request = (HttpWebRequest)WebRequest.Create(Config.Uri + "/token.html");
                request.Credentials = new NetworkCredential(Config.UserName, Config.Password);
                request.CookieContainer = _cookies;

                var resStream = request.GetResponse().GetResponseStream();
                if (resStream == null)
                    return null;
                var token = System.Text.RegularExpressions.Regex.Replace(new StreamReader(resStream).ReadToEnd(), @"(<[^>]+>)", string.Empty);
                resStream.Close();

                return token;
            }
            catch (WebException ex)
            {
                WebUiError?.Invoke(this, ex);
                return null;
            }
            catch (System.Net.Sockets.SocketException ex)
            {
                WebUiError?.Invoke(this, ex);
                return null;
            }
        }

        private List<TorrentFile> ListTorrents()
        {
            var torrents = new List<TorrentFile>();

            var args = new List<(string, string)>
            {
                ("list", "1"),
                ("token", _token)
            };


            var json = Send(args);

            if (!string.IsNullOrEmpty(json))
            {
                var o = JObject.Parse(json);
                IList<JToken> results = o["torrents"].Children().ToList();
                torrents.AddRange(results.Select(result => TorrentFile.ConvertStringArray(JsonConvert.DeserializeObject<string[]>(result.ToString()))));
            }
            else
            {
                return null;
            }

            UpdatedList(torrents);

            return torrents;
        }

        private string Send(string action, IEnumerable<(string, string)> args)
        {
            var l = new List<(string, string)>
            {
                ("action", action),
                ("token", _token)
            };
            l.AddRange(args);

            return Send(l);
        }

        private string Send(IEnumerable<(string, string)> args)
        {
            return Get($"{Config.Uri}/?{string.Join("&", args.Select(item => $"{item.Item1}={item.Item2}"))}");
        }

        private string Get(string get)
        {
            try
            {
                var request = (HttpWebRequest) WebRequest.Create(get);
                request.Credentials = new NetworkCredential(Config.UserName, Config.Password);
                request.CookieContainer = _cookies;

                var resStream = request.GetResponse().GetResponseStream();
                if (resStream == null)
                    return null;
                var html = new StreamReader(resStream).ReadToEnd();
                resStream.Close();

                return html;
            }
            catch (System.Net.Sockets.SocketException ex)
            {
                WebUiError?.Invoke(this, ex);
                return null;
            }
            catch (WebException ex)
            {
                WebUiError?.Invoke(this, ex);
                return null;
            }
        }

        private List<TorrentFile> FindDone()
        {
            if (_torrents.Last != null && _torrents.Current != null)
            {
                return (
                    from currentTorrent in _torrents.Current
                    from lastTorrent in _torrents.Last
                    where currentTorrent.Hash == lastTorrent.Hash &&
                          currentTorrent.PercentProgress == 1000 &&
                          lastTorrent.PercentProgress != 1000
                    select currentTorrent
                    ).ToList();
            }
            return new List<TorrentFile>();
        }

        private List<TorrentFile> FindNew()
        {
            if (_torrents.Last != null && _torrents.Current != null)
            {
                return _torrents.Current.Where(currentTorrent =>
                    _torrents.Last.Find(item => item.Hash == currentTorrent.Hash) == null).ToList();
            }
            return new List<TorrentFile>();
        }

        public bool Stopped => !_timer.Enabled;

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _timer.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

    class TorrentListing
    {
        private List<TorrentFile> _current;

        public TorrentListing()
        {
            Last = null;
            _current = null;
        }

        public List<TorrentFile> Last { get; set; }

        public List<TorrentFile> Current
        {
            get => _current;
            set
            {
                if (_current != null)
                    Last = _current;
                _current = value;
            }
        }
    }
}
