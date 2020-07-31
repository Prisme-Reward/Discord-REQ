using System.IO;
using System.Net;
using System.Text;

namespace Discord.REQ
{
    public class UserProfile
    {
        public static string SetIdle(string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            var Req = (HttpWebRequest)WebRequest.Create($"https://discordapp.com/api/v6/users/@me/settings");

            var postData = "{\"status\":\"idle\"}";

            var data = Encoding.ASCII.GetBytes(postData);

            Req.Method = "PATCH";
            Req.UserAgent = UserAgent;
            Req.ContentType = "application/json";
            Req.Headers.Add("authorization", Token);
            Req.ContentLength = data.Length;

            using (var stream = Req.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)Req.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }

        public static string SetOnline(string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            var Req = (HttpWebRequest)WebRequest.Create($"https://discordapp.com/api/v6/users/@me/settings");

            var postData = "{\"status\":\"online\"}";

            var data = Encoding.ASCII.GetBytes(postData);

            Req.Method = "PATCH";
            Req.UserAgent = UserAgent;
            Req.ContentType = "application/json";
            Req.Headers.Add("authorization", Token);
            Req.ContentLength = data.Length;

            using (var stream = Req.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)Req.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }

        public static string SetOffline(string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            var Req = (HttpWebRequest)WebRequest.Create($"https://discordapp.com/api/v6/users/@me/settings");

            var postData = "{\"status\":\"invisible\"}";

            var data = Encoding.ASCII.GetBytes(postData);

            Req.Method = "PATCH";
            Req.UserAgent = UserAgent;
            Req.ContentType = "application/json";
            Req.Headers.Add("authorization", Token);
            Req.ContentLength = data.Length;

            using (var stream = Req.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)Req.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }

        public static string SetDND(string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            var Req = (HttpWebRequest)WebRequest.Create($"https://discordapp.com/api/v6/users/@me/settings");

            var postData = "{\"status\":\"dnd\"}";

            var data = Encoding.ASCII.GetBytes(postData);

            Req.Method = "PATCH";
            Req.UserAgent = UserAgent;
            Req.ContentType = "application/json";
            Req.Headers.Add("authorization", Token);
            Req.ContentLength = data.Length;

            using (var stream = Req.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)Req.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }

        public static string SetUsername(string UserName, string Email, string Password, string Tag, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            var Req = (HttpWebRequest)WebRequest.Create($"https://discordapp.com/api/v6/users/@me");

            var postData = "{" + $"\"username\":\"{UserName}\",\"email\":\"{Email}\",\"password\":\"{Password}\",\"discriminator\":\"{Tag}\"" + "}";

            var data = Encoding.ASCII.GetBytes(postData);

            Req.Method = "PATCH";
            Req.UserAgent = UserAgent;
            Req.ContentType = "application/json";
            Req.Headers.Add("authorization", Token);
            Req.ContentLength = data.Length;

            using (var stream = Req.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)Req.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }
    }
}