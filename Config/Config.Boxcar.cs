using System;
using System.Text;
using System.Security.Cryptography;

namespace uTorrentNotifier
{
    public partial class Config
    {
        public class BoxcarConfig
        {
            private bool _enable;
            private string _apiKey;
            private string _email;

            public BoxcarConfig()
            {
                _email = Properties.Settings.Default.BoxcarEmail;
                _apiKey = Properties.Settings.Default.BoxcarAPIKey;
                _enable = Properties.Settings.Default.BoxcarEnable;
            }

            public bool Enable
            {
                get => _enable;
                set
                {
                    Properties.Settings.Default.BoxcarEnable = value;
                    _enable = value;
                }
            }

            public string ApiKey
            {
                get => _apiKey;
                set
                {
                    Properties.Settings.Default.BoxcarAPIKey = value;
                    _apiKey = value;
                }
            }

            public string Email
            {
                get => _email;
                set
                {
                    Properties.Settings.Default.BoxcarEmail = value;
                    _email = value;
                }
            }

            public string Md5Email => BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(_email))).Replace("-", "").ToLower();
        }
    }
}
