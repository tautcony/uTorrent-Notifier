namespace uTorrentNotifier
{
    public partial class Config
    {
        public const string LatestVersion = "http://ejholmes.github.com/uTorrent-Notifier/latest";
        public const string LatestDownload = "http://github.com/downloads/ejholmes/uTorrent-Notifier/setup.exe";
        private string _uri;
        private string _userName;
        private string _password;

        private bool _showBalloonTips;
        private bool _checkForUpdates;

        public TwitterConfig Twitter             = new TwitterConfig();
        public BoxcarConfig Boxcar               = new BoxcarConfig();
        public NotificationsConfig Notifications = new NotificationsConfig();

        public Config()
        {
            _uri             = Properties.Settings.Default.URI;
            _userName        = Properties.Settings.Default.UserName;
            _password        = Properties.Settings.Default.Password;
            RunOnStartup     = Properties.Settings.Default.RunOnStartup;
            _showBalloonTips = Properties.Settings.Default.ShowBalloonTips;
            _checkForUpdates = Properties.Settings.Default.CheckForUpdates;
        }

        public void Save()
        {
            /* Save registry info only if we're changing the value */
            if (RunOnStartup != Properties.Settings.Default.RunOnStartup)
            {
                var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                if (RunOnStartup)
                    key.SetValue(Properties.Resources.Name, System.Windows.Forms.Application.ExecutablePath);
                else
                    key.DeleteValue(Properties.Resources.Name, false);

                Properties.Settings.Default.RunOnStartup = RunOnStartup;
            }
            Properties.Settings.Default.Save();
        }

        public string Uri
        {
            get => _uri;
            set
            {
                var uri = value.TrimEnd('/');

                Properties.Settings.Default.URI = uri;
                _uri = uri;
            }
        }
        public string UserName
        {
            get => _userName;
            set
            {
                Properties.Settings.Default.UserName = value;
                _userName = value;
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                Properties.Settings.Default.Password = value;
                _password = value;
            }
        }

        public bool RunOnStartup { get; set; }

        public bool ShowBalloonTips
        {
            get => _showBalloonTips;
            set
            {
                Properties.Settings.Default.ShowBalloonTips = value;
                _showBalloonTips = value;
            }
        }

        public bool CheckForUpdates
        {
            get => _checkForUpdates;
            set
            {
                Properties.Settings.Default.CheckForUpdates = value;
                _checkForUpdates = value;
            }
        }
    }
}
