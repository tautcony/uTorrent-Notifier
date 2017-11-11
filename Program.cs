using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;

[assembly:CLSCompliant(true)]
namespace uTorrentNotifier
{
    public class Program : Form
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Program());
        }

        private NotifyIcon _trayIcon;
        private ContextMenu _trayMenu;
        private MenuItem _miStartAll;
        private MenuItem _miPauseAll;
        private MenuItem _menuItem2;
        private MenuItem _miSettings;
        private MenuItem _menuItem1;
        private MenuItem _miClose;

        private readonly SettingsForm _settingsForm;

        private readonly ClassRegistry _classRegistry;

        public Program()
        {
            var firstRun = false;
            InitializeComponent();

            if (Properties.Settings.Default.FirstRun)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.Reload();
                Properties.Settings.Default.FirstRun = false;
                firstRun = true;
            }
            _classRegistry = new ClassRegistry();
            _settingsForm = new SettingsForm(_classRegistry);

            if (_classRegistry.Config.CheckForUpdates)
            {
                System.Threading.ThreadPool.QueueUserWorkItem(CheckForUpdates);
            }
            _classRegistry.UTorrent.TorrentAdded += utorrent_TorrentAdded;
            _classRegistry.UTorrent.DownloadComplete += utorrent_DownloadComplete;
            _classRegistry.UTorrent.WebUiError += utorrent_LogOnError;
            _classRegistry.UTorrent.UpdatedList += uTorrent_UpdatedList;
            _classRegistry.UTorrent.Start();

            if (firstRun)
                _settingsForm.Show();
        }

        void utorrent_LogOnError(object sender, Exception e)
        {
            _trayIcon.ShowBalloonTip(5000, "Login Error", e.Message, ToolTipIcon.Error);
            _trayIcon.Text = Properties.Resources.Name + "\n" + "Error connecting to uTorrent";
        }

        void utorrent_DownloadComplete(List<TorrentFile> finished)
        {
            if (_classRegistry.Config.Notifications.DownloadComplete)
            {
                foreach (var f in finished)
                {
                    if (_classRegistry.Config.Twitter.Enable)
                    {
                        _classRegistry.Twitter.Update("Downloaded " + f.Name + " | " + Utilities.FormatBytes((long)f.Size));
                    }

                    if (_classRegistry.Config.Boxcar.Enable)
                    {
                        _classRegistry.Boxcar.Add("Download Complete: " + f.Name);
                    }

                    if (_classRegistry.Config.ShowBalloonTips)
                    {
                        _trayIcon.ShowBalloonTip(5000, "Download Complete", f.Name, ToolTipIcon.Info);
                    }
                }
            }
        }

        void utorrent_TorrentAdded(List<TorrentFile> added)
        {
            if (_classRegistry.Config.Notifications.TorrentAdded)
            {
                foreach (var f in added)
                {
                    if (_classRegistry.Config.Twitter.Enable)
                    {
                        _classRegistry.Twitter.Update("Added " + f.Name);
                    }

                    if (_classRegistry.Config.Boxcar.Enable)
                    {
                        _classRegistry.Boxcar.Add("Torrent Added: " + f.Name);
                    }

                    if (_classRegistry.Config.ShowBalloonTips)
                    {
                        _trayIcon.ShowBalloonTip(5000, "Torrent Added", f.Name, ToolTipIcon.Info);
                    }
                }
            }
        }

        void uTorrent_UpdatedList(List<TorrentFile> torrents)
        {
            var downloading = torrents.Count(n => n.StatusString == WebUiapi.StatusString.Downloading);
            if (downloading == 1)
            {
                _trayIcon.Text = Properties.Resources.Name + "\n" +
                    downloading.ToString(CultureInfo.CurrentCulture) + " torrent downloading\n";
            }
            else
            {
                _trayIcon.Text = Properties.Resources.Name + "\n" +
                    downloading.ToString(CultureInfo.CurrentCulture) + " torrents downloading\n";
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            _settingsForm.Show();
        }

        private void PauseAll_Click(object sender, EventArgs e)
        {
            _classRegistry.UTorrent.PauseAll();
        }

        private void StartAll_Click(object sender, EventArgs e)
        {
            _classRegistry.UTorrent.StartAll();
        }

        private void CheckForUpdates(object sender)
        {
            var webclient = new System.Net.WebClient();
            var latestVersion = webclient.DownloadString(Config.LatestVersion);

            var latest = new Version(latestVersion);

            if (latest > ClassRegistry.Version)
            {
                if (MessageBox.Show("You are using version " + ClassRegistry.Version + ". Would you like to download version " + latestVersion + "?",
                    "New Version Available",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
                {
                    Process.Start(Config.LatestDownload);
                    Application.Exit();
                }
            }
        }

        private void InitializeComponent()
        {
            //
            // StartAll
            //
            _miStartAll = new MenuItem
            {
                Index = 0,
                Text = "Start All"
            };
            _miStartAll.Click += StartAll_Click;
            //
            // PauseAll
            //
            _miPauseAll = new MenuItem
            {
                Index = 1,
                Text = "Pause All"
            };
            _miPauseAll.Click += PauseAll_Click;
            //
            // menuItem2
            //
            _menuItem2 = new MenuItem
            {
                Index = 2,
                Text = "-"
            };
            //
            // Settings
            //
            _miSettings = new MenuItem
            {
                Index = 3,
                Text = "Settings"
            };
            _miSettings.Click += Settings_Click;
            //
            // menuItem1
            //
            _menuItem1 = new MenuItem
            {
                Index = 4,
                Text = "-"
            };
            //
            // Close
            //
            _miClose = new MenuItem
            {
                Index = 5,
                Text = "Exit"
            };
            _miClose.Click += Close_Click;

            _trayMenu = new ContextMenu();
            _trayMenu.MenuItems.AddRange(new[] {
                _miStartAll,
                _miPauseAll,
                _menuItem2,
                _miSettings,
                _menuItem1,
                _miClose});

            _trayIcon = new NotifyIcon
            {
                Text = Properties.Resources.Name,
                Icon = Properties.Resources.un_icon_systray
            };
            Icon = Properties.Resources.un_icon;

            // Add menu to tray icon and show it.
            _trayIcon.ContextMenu = _trayMenu;
            _trayIcon.Visible = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            Visible = false; // Hide form window.
            ShowInTaskbar = false; // Remove from taskbar.

            base.OnLoad(e);
        }

        private void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Release the icon resource.
                _trayIcon.Dispose();
                _classRegistry.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}