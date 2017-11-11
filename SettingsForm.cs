using System;
using System.Diagnostics;
using System.Windows.Forms;
using uTorrentNotifier.Notifications.Twitter;

namespace uTorrentNotifier
{
    public partial class SettingsForm : Form
    {
        //private Version _Version;
        private OAuthTwitter _oAuth;
        private readonly ClassRegistry _classRegistry;

        public SettingsForm(ClassRegistry classRegistry)
        {
            _classRegistry = classRegistry;

            InitializeComponent();
        }

        private void SettingsForm_Shown(object sender, EventArgs e)
        {
            lblVersion.Text = ClassRegistry.Version.ToString();
            SetConfig();
        }

        private void SetConfig()
        {
            tbPassword.Text                                = _classRegistry.Config.Password;
            tbUsername.Text                                = _classRegistry.Config.UserName;
            tbWebUI_URL.Text                               = _classRegistry.Config.Uri;
            cbRunOnStartup.Checked                         = _classRegistry.Config.RunOnStartup;
            cbShowBalloonTips.Checked                      = _classRegistry.Config.ShowBalloonTips;
            cbCheckForUpdates.Checked                      = _classRegistry.Config.CheckForUpdates;

            tbTwitterPIN.Text                              = _classRegistry.Config.Twitter.Pin;
            tbTwitterPrefixTweet.Text                      = _classRegistry.Config.Twitter.PrefixTweet;
            cbTwitterEnable.Checked                        = _classRegistry.Config.Twitter.Enable;

            cbBoxcarEnable.Checked                         = _classRegistry.Config.Boxcar.Enable;
            tbBoxcarEmail.Text                             = _classRegistry.Config.Boxcar.Email;
            tbBoxcarAPIKey.Text                            = _classRegistry.Config.Boxcar.ApiKey;

            cbProwlNotification_TorentAdded.Checked        = _classRegistry.Config.Notifications.TorrentAdded;
            cbTorrentNotification_DownloadComplete.Checked = _classRegistry.Config.Notifications.DownloadComplete;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _classRegistry.Config.Uri                                 = tbWebUI_URL.Text;
            _classRegistry.Config.UserName                            = tbUsername.Text;
            _classRegistry.Config.Password                            = tbPassword.Text;
            _classRegistry.Config.RunOnStartup                        = cbRunOnStartup.Checked;
            _classRegistry.Config.ShowBalloonTips                     = cbShowBalloonTips.Checked;
            _classRegistry.Config.CheckForUpdates                     = cbCheckForUpdates.Checked;

            _classRegistry.Config.Twitter.PrefixTweet                 = tbTwitterPrefixTweet.Text;
            _classRegistry.Config.Twitter.Enable                      = cbTwitterEnable.Checked;

            _classRegistry.Config.Boxcar.Enable                       = cbBoxcarEnable.Checked;
            _classRegistry.Config.Boxcar.Email                        = tbBoxcarEmail.Text;
            _classRegistry.Config.Boxcar.ApiKey                       = tbBoxcarAPIKey.Text;

            _classRegistry.Config.Notifications.TorrentAdded          = cbProwlNotification_TorentAdded.Checked;
            _classRegistry.Config.Notifications.DownloadComplete      = cbTorrentNotification_DownloadComplete.Checked;

            _classRegistry.Config.Save();
            Hide();

            if (!_classRegistry.UTorrent.Stopped)
                _classRegistry.UTorrent.Stop();
            _classRegistry.UTorrent.Start();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://ejholmes.github.com/uTorrent-Notifier/");
        }

        private void btnStartAuthorization_Click(object sender, EventArgs e)
        {
            _oAuth = new OAuthTwitter
            {
                ConsumerKey = _classRegistry.Config.Twitter.ConsumerKey,
                ConsumerSecret = _classRegistry.Config.Twitter.ConsumerSecret
            };

            _classRegistry.Config.Twitter.Pin = string.Empty;
            _classRegistry.Config.Twitter.Token = string.Empty;
            _classRegistry.Config.Twitter.TokenSecret = string.Empty;

            var oAuthLink = _oAuth.AuthorizationLinkGet();
            try
            {
                Process.Start(oAuthLink);
                tbTwitterPIN.Text = string.Empty;
                tbTwitterPIN.Enabled = true;
                lblTwitterPIN.Enabled = true;
                btnTwitterAuthorize.Enabled = true;
            }
            catch
            {
                tbTwitterPIN.Text = string.Empty;
                lblTwitterPIN.Enabled = false;
                tbTwitterPIN.Enabled = false;
                btnTwitterAuthorize.Enabled = false;
                MessageBox.Show("An error occurred trying to authenticate. Check your network settings and browser config, and try again.", "uTorrent Notifier - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTwitterAuthorize_Click(object sender, EventArgs e)
        {
            var pin = tbTwitterPIN.Text;
            if (!string.IsNullOrEmpty(pin))
            {
                pin = pin.Trim();
            }
            else
            {
                MessageBox.Show("Copy and paste the authentication PIN code from Twitter", "uTorrent Notifier - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _oAuth.AccessTokenGet(_oAuth.OAuthToken, pin);
                _classRegistry.Config.Twitter.Token = _oAuth.Token;
                _classRegistry.Config.Twitter.TokenSecret = _oAuth.TokenSecret;
                _classRegistry.Config.Twitter.Pin = pin;
                tbTwitterPIN.Enabled = false;
                btnTwitterAuthorize.Enabled = false;
                MessageBox.Show("Successfully authenticated with Twitter", "uTorrent Notifier - Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                _classRegistry.Config.Twitter.Pin = string.Empty;
                tbTwitterPIN.Text = string.Empty;
                lblTwitterPIN.Enabled = false;
                tbTwitterPIN.Enabled = false;
                btnTwitterAuthorize.Enabled = false;
                MessageBox.Show("An error occurred trying to authenticate. Check your network settings and browser config, and try again.", "uTorrent Notifier - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSendTestTweet_Click(object sender, EventArgs e)
        {
            var bCanSend = _classRegistry.Twitter != null;
            if(!cbTwitterEnable.Checked) bCanSend=false;

            if(bCanSend)
            {
                _classRegistry.Twitter.Update("Congratulations! Twitter notifications from uTorrent Notifier are working correctly :)");
                MessageBox.Show("A test tweet has been sent...", "uTorrent Notifier - Test sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("uTorrent Notifier must be authenticated and enabled before testing. Please check your settings, and try again.", "uTorrent Notifier - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBoxcarGetAPIKey_Click(object sender, EventArgs e)
        {
            Process.Start("http://boxcar.io/site/providers/new");
        }

    }
}
