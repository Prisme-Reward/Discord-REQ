using System.IO;
using System.Net;
using System.Text;

namespace Discord.REQ
{
    public class Template
    {
        public static string Create(string GuildId, string Token, string Name = "Template", string Description = "Simple Template", string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            var Req = (HttpWebRequest)WebRequest.Create($"https://ptb.discordapp.com/api/v6/guilds/{GuildId}/templates");
            var Data = Encoding.ASCII.GetBytes("{" + $"\"name\":\"{Name}\",\"description\":\"{Description}\"" + "}");

            Req.Method = "POST";
            Req.UserAgent = UserAgent;
            Req.ContentType = "application/json";
            Req.Headers.Add("authorization", Token);
            Req.ContentLength = Data.Length;

            using (var stream = Req.GetRequestStream()) { stream.Write(Data, 0, Data.Length); }
            var Response = (HttpWebResponse)Req.GetResponse();
            var ResponseInString = new StreamReader(Response.GetResponseStream()).ReadToEnd();
            return ResponseInString;
        }

        public static string Delete(string GuildId, string TemplateCode, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            var Req = (HttpWebRequest)WebRequest.Create($"https://ptb.discordapp.com/api/v6/guilds/{GuildId}/templates/{TemplateCode}");
            var Data = Encoding.ASCII.GetBytes("{}");

            Req.Method = "DELETE";
            Req.UserAgent = UserAgent;
            Req.ContentType = "application/json";
            Req.Headers.Add("authorization", Token);
            Req.ContentLength = Data.Length;

            using (var stream = Req.GetRequestStream()) { stream.Write(Data, 0, Data.Length); }
            var Response = (HttpWebResponse)Req.GetResponse();
            var ResponseInString = new StreamReader(Response.GetResponseStream()).ReadToEnd();
            return ResponseInString;
        }

        public static string Use(string TemplateCode, string Token, string ServerName, string Icon = "null", string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            var Req = (HttpWebRequest)WebRequest.Create($"https://discord.com/api/v6/guilds/templates/{TemplateCode}");
            var Data = Encoding.ASCII.GetBytes("{" + $"\"name\":\"{ServerName}\",\"icon\":\"{Icon}\"" + "}");

            Req.Method = "POST";
            Req.UserAgent = UserAgent;
            Req.ContentType = "application/json";
            Req.Headers.Add("authorization", Token);
            Req.ContentLength = Data.Length;

            using (var stream = Req.GetRequestStream()) { stream.Write(Data, 0, Data.Length); }
            var Response = (HttpWebResponse)Req.GetResponse();
            var ResponseInString = new StreamReader(Response.GetResponseStream()).ReadToEnd();
            return ResponseInString;
        }
    }
}