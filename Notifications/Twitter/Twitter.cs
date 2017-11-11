using System.Web;
using System.ComponentModel;

namespace uTorrentNotifier
{
    public class Twitter
    {
        private readonly Config.TwitterConfig _twitterConfig;
        private OAuthTwitter _oAuth;

        public Twitter(Config.TwitterConfig twitterConfig)
        {
            _twitterConfig = twitterConfig;
        }

        public void Update(string message)
        {
            var bw = new BackgroundWorker
            {
                WorkerReportsProgress = false,
                WorkerSupportsCancellation = false
            };
            bw.DoWork += bw_Update;
            bw.RunWorkerAsync(message);
        }

        void bw_Update(object sender, DoWorkEventArgs e)
        {
            _oAuth = new OAuthTwitter
            {
                ConsumerKey = _twitterConfig.ConsumerKey,
                ConsumerSecret = _twitterConfig.ConsumerSecret,
                Token = _twitterConfig.Token,
                TokenSecret = _twitterConfig.TokenSecret
            };

            var tweet = HttpUtility.UrlEncode(e.Argument.ToString());

            if (!string.IsNullOrEmpty(_twitterConfig.PrefixTweet))
            {
                tweet = _twitterConfig.PrefixTweet + " " + tweet;
            }

            if (tweet.Length > 140) tweet = tweet.Substring(0, 140);

            var oAuthReturn = _oAuth.OAuthWebRequest(
                OAuthTwitter.Method.Post,
                "http://twitter.com/statuses/update.xml",
                "status=" + tweet
                );

            //Console.WriteLine("Twitter test complete: " + oAuthReturn);
        }
    }
}