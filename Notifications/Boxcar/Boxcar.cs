using System.Text;
using System.Net;

namespace uTorrentNotifier
{
    public class Boxcar
    {
        private readonly string _uri = "http://boxcar.io";
        private readonly Config.BoxcarConfig _boxcarConfig;

        public Boxcar(Config.BoxcarConfig boxcarConfig)
        {
            _boxcarConfig = boxcarConfig;
        }

        public void Add(string message)
        {
            if (string.IsNullOrEmpty(_boxcarConfig.ApiKey))
                return;
            try
            {
                var url = _uri + "/devices/providers/" + _boxcarConfig.ApiKey + "/notifications";

                var client = new WebClient();
                client.Headers.Add("user-agent", "uTorrent Notifier");
                client.UploadData(url, Encoding.ASCII.GetBytes("email=" + _boxcarConfig.Md5Email + "&notification[message]=" + message.Replace(" ", "+")));
            }
            catch (WebException)
            {
                /* User probably isn't subscribed to the provider yet */
                SendInvite();
                Add(message);
            }
        }

        public void SendInvite()
        {
            var url = _uri + "/devices/providers/" + _boxcarConfig.ApiKey + "/notifications/subscribe";

            var client = new WebClient();
            client.Headers.Add("user-agent", "uTorrent Notifier");
            client.UploadData(url, Encoding.ASCII.GetBytes("email=" + _boxcarConfig.Md5Email));
        }
    }
}
