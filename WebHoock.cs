using System.IO;
using System.Net;
using System.Text;

namespace Discord.REQ
{
    public class WebHoock
    {
        public static string CreateWebhook(string ChannelId, string Token, string Name = "Spidey Bot", string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            var Req = (HttpWebRequest)WebRequest.Create($"https://discordapp.com/api/v6/channels/{ChannelId}/webhooks");

            var postData = "{" + $"\"name\": \"{Name}\"" + "}";

            var data = Encoding.ASCII.GetBytes(postData);

            Req.Method = "POST";
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

        public static string DeleteWebhook(string WebhoockId, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            var Req = (HttpWebRequest)WebRequest.Create($"https://discordapp.com/api/v6/webhooks/{WebhoockId}");

            var postData = "{}";

            var data = Encoding.ASCII.GetBytes(postData);

            Req.Method = "DELETE";
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