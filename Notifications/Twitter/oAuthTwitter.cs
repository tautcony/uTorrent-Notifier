using System;
using System.IO;
using System.Net;
using System.Web;

namespace uTorrentNotifier.Notifications.Twitter
{
    public class OAuthTwitter : OAuthBase
    {
        public enum Method { Get, Post };
        public const string RequestToken = "http://twitter.com/oauth/request_token";
        public const string Authorize = "http://twitter.com/oauth/authorize";
        public const string AccessToken = "http://twitter.com/oauth/access_token";

        // JMD: this property should not have a dependency on the Settings file.
        public string ConsumerKey { get; set; } = "";

        // JMD: this property should not have a dependency on the Settings file.
        public string ConsumerSecret { get; set; } = "";

        public string OAuthToken { get; set; }
        public string Token { get; set; } = "";

        public string Pin { get; set; } = "";

        public string TokenSecret { get; set; } = "";

        /// <summary>
        /// Get the link to Twitter's authorization page for this application.
        /// </summary>
        /// <returns>The url with a valid request token, or a null string.</returns>
        public string AuthorizationLinkGet()
        {
            string ret = null;

            // First let's get a REQUEST token.
            var response = OAuthWebRequest(Method.Get, RequestToken, string.Empty);
            if (response.Length > 0)
            {
                //response contains token and token secret.  We only need the token.
                var qs = HttpUtility.ParseQueryString(response);
                if (qs["oauth_token"] != null)
                {
                    OAuthToken = qs["oauth_token"]; // tuck this away for later
                    ret = Authorize + "?oauth_token=" + qs["oauth_token"];// +"&oauth_callback=oob";
                }
            }
            return ret;
        }

        /// <summary>
        /// Exchange the request token for an access token.
        /// </summary>
        /// <param name="authToken">The oauth_token is supplied by Twitter's authorization page following the callback.</param>
        /// <param name="pin"></param>
        public void AccessTokenGet(string authToken, string pin)
        {
            Token = authToken;
            Pin = pin; // JDevlin

            var response = OAuthWebRequest(Method.Get, AccessToken, string.Empty);

            if (response.Length > 0)
            {
                //Store the Token and Token Secret
                var qs = HttpUtility.ParseQueryString(response);
                if (qs["oauth_token"] != null)
                {
                    Token = qs["oauth_token"];
                }
                if (qs["oauth_token_secret"] != null)
                {
                    TokenSecret = qs["oauth_token_secret"];
                }
            }
        }

        /// <summary>
        /// Submit a web request using oAuth.
        /// </summary>
        /// <param name="method">GET or POST</param>
        /// <param name="url">The full url, including the querystring.</param>
        /// <param name="postData">Data to post (querystring format)</param>
        /// <returns>The web server response.</returns>
        public string OAuthWebRequest(Method method, string url, string postData)
        {
            //Setup postData for signing.
            //Add the postData to the querystring.
            if (method == Method.Post)
            {
                if (postData.Length > 0)
                {
                    //Decode the parameters and re-encode using the oAuth UrlEncode method.
                    var qs = HttpUtility.ParseQueryString(postData);
                    postData = "";
                    foreach (var key in qs.AllKeys)
                    {
                        if (postData.Length > 0)
                        {
                            postData += "&";
                        }
                        qs[key] = HttpUtility.UrlDecode(qs[key]);
                        qs[key] = UrlEncode(qs[key]);
                        postData += key + "=" + qs[key];

                    }
                    if (url.IndexOf("?", StringComparison.Ordinal) > 0)
                    {
                        url += "&";
                    }
                    else
                    {
                        url += "?";
                    }
                    url += postData;
                }
            }
            else if (method == Method.Get && !string.IsNullOrEmpty(postData))
            {
                url += "?" + postData;
            }

            var uri = new Uri(url);

            var nonce = GenerateNonce();
            var timeStamp = GenerateTimestamp();

            //Generate Signature
            var sig = GenerateSignature(uri,
                ConsumerKey,
                ConsumerSecret,
                Token,
                TokenSecret,
                method.ToString(),
                timeStamp,
                nonce,
                Pin,
                out var outUrl,
                out var querystring);

            querystring += "&oauth_signature=" + HttpUtility.UrlEncode(sig);

            //Convert the querystring to postData
            if (method == Method.Post)
            {
                postData = querystring;
                querystring = "";
            }

            if (querystring.Length > 0)
            {
                outUrl += "?";
            }

            var ret = WebRequest(method, outUrl +  querystring, postData);

            return ret;
        }

        /// <summary>
        /// Web Request Wrapper
        /// </summary>
        /// <param name="method">Http Method</param>
        /// <param name="url">Full url to the web resource</param>
        /// <param name="postData">Data to post in querystring format</param>
        /// <returns>The web server response.</returns>
        public string WebRequest(Method method, string url, string postData)
        {
            if (!(System.Net.WebRequest.Create(url) is HttpWebRequest webRequest)) return null;
            webRequest.Method = method.ToString();
            webRequest.ServicePoint.Expect100Continue = false;
            //webRequest.UserAgent  = "Identify your application please.";
            //webRequest.Timeout = 20000;

            if (method == Method.Post)
            {
                webRequest.ContentType = "application/x-www-form-urlencoded";

                //POST the data.
                var requestWriter = new StreamWriter(webRequest.GetRequestStream());
                try
                {
                    requestWriter.Write(postData);
                }
                finally
                {
                    requestWriter.Close();
                }
            }

            var responseData = WebResponseGet(webRequest);

            return responseData;

        }

        /// <summary>
        /// Process the web response.
        /// </summary>
        /// <param name="webRequest">The request object.</param>
        /// <returns>The response data.</returns>
        public string WebResponseGet(HttpWebRequest webRequest)
        {
            StreamReader responseReader = null;
            string responseData;

            try
            {
                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream() ?? throw new InvalidOperationException());
                responseData = responseReader.ReadToEnd();
            }
            finally
            {
                webRequest.GetResponse().GetResponseStream()?.Close();
                responseReader?.Close();
            }

            return responseData;
        }

        // JMD: added for convenience. Reset the state of the oAuthTwitter object.
        public void Reset()
        {
            ConsumerKey = ConsumerSecret = OAuthToken = Token = TokenSecret = Pin = string.Empty;
        }
    }
}