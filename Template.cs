using System.IO;
using System.Net;
using System.Text;

namespace Discord.REQ
{
    public class Template
    {
        public static string CreateTemplate(string GuildId, string Token, string Name = "Template", string Description = "Simple Template", string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            var Req = (HttpWebRequest)WebRequest.Create($"https://ptb.discordapp.com/api/v6/guilds/{GuildId}/templates");

            var postData = "{" + $"\"name\":\"{Name}\",\"description\":\"{Description}\"" + "}";

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

        public static string DeleteTemplate(string GuildId, string TemplateCode, string Token, string Name = "Template", string Description = "Simple Template", string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            var Req = (HttpWebRequest)WebRequest.Create($"https://ptb.discordapp.com/api/v6/guilds/{GuildId}/templates/{TemplateCode}");

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