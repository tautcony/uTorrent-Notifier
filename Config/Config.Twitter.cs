namespace uTorrentNotifier
{
    public partial class Config
    {
        public class TwitterConfig
        {
            private string _token;
            private string _tokenSecret;
            private string _pin;
            private string _prefixTweet;
            private bool _enable;

            public TwitterConfig()
            {
                ConsumerKey    = Properties.Settings.Default.TwitterConsumerKey;
                ConsumerSecret = Properties.Settings.Default.TwitterConsumerSecret;
                _token         = Properties.Settings.Default.TwitterToken;
                _tokenSecret   = Properties.Settings.Default.TwitterTokenSecret;
                _pin           = Properties.Settings.Default.TwitterPIN;
                _enable        = Properties.Settings.Default.TwitterEnable;
                _prefixTweet   = Properties.Settings.Default.TwitterPrefixTweet;
            }

            public string ConsumerKey { get; }

            public string ConsumerSecret { get; }

            public string Token
            {
                get => _token;
                set
                {
                    Properties.Settings.Default.TwitterToken = value;
                    _token = value;
                }
            }

            public string TokenSecret
            {
                get => _tokenSecret;
                set
                {
                    Properties.Settings.Default.TwitterTokenSecret = value;
                    _tokenSecret = value;
                }
            }

            public string Pin
            {
                get => _pin;
                set
                {
                    Properties.Settings.Default.TwitterPIN = value;
                    _pin = value;
                }
            }

            public bool Enable
            {
                get => _enable;
                set
                {
                    Properties.Settings.Default.TwitterEnable = value;
                    _enable = value;
                }
            }

            public string PrefixTweet
            {
                get => _prefixTweet;
                set
                {
                    Properties.Settings.Default.TwitterPrefixTweet = value;
                    _prefixTweet = value;
                }
            }
        }
    }
}