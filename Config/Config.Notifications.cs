namespace uTorrentNotifier
{
    public partial class Config
    {
        public class NotificationsConfig
        {
            private bool _downloadComplete;
            private bool _torrentAdded;

            public NotificationsConfig()
            {
                _torrentAdded = Properties.Settings.Default.Notification_TorrentAdded;
                _downloadComplete = Properties.Settings.Default.Notification_DownloadComplete;
            }

            public bool DownloadComplete
            {
                get => _downloadComplete;
                set
                {
                    Properties.Settings.Default.Notification_DownloadComplete = value;
                    _downloadComplete= value;
                }
            }

            public bool TorrentAdded
            {
                get => _torrentAdded;
                set
                {
                    Properties.Settings.Default.Notification_TorrentAdded = value;
                    _torrentAdded = value;
                }
            }
        }
    }
}
