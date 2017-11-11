using System;
using uTorrentNotifier.Notifications.Boxcar;
using uTorrentNotifier.Notifications.Twitter;

namespace uTorrentNotifier
{
    public class ClassRegistry : IDisposable
    {
        public ClassRegistry()
        {
            Config   = new Config();
            UTorrent = new WebUIAPI.WebUiapi(Config);
            Twitter  = new Twitter(Config.Twitter);
            Boxcar   = new Boxcar(Config.Boxcar);
        }

        public Config Config { get; set; }

        public WebUIAPI.WebUiapi UTorrent { get; }

        public Twitter Twitter { get; }

        public Boxcar Boxcar { get; }

        public static Version Version => System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                UTorrent.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
