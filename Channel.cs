using System.IO;
using System.Net;
using System.Text;

namespace Discord.REQ
{
    public class Channel
    {
        public static string Delete(string ChannelId, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            HttpWebRequest Req = (HttpWebRequest)WebRequest.Create($"https://discordapp.com/api/v6/channels/{ChannelId}");
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

        public static string Create(string Type, string Name, string GuildId, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            /* TYPE 0 = Channel text
             * TYPE 2 = Channel Voc
             * TYPE 4 = Catégorie
             */
            HttpWebRequest Req = (HttpWebRequest)WebRequest.Create($"https://discord.com/api/v6/guilds/{GuildId}/channels");
            var Data = Encoding.ASCII.GetBytes("{" + $"\"type\":\"{Type}\",\"name\":\"{Name}\",\"permission_overwrites\":[]" + "}");
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

        public static string Edit(string ChannelId, string Token, string Name, string Type, string Topic = "", string UserLimite = "0", bool IsNSFW = false, string RateLimite = "0", string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            HttpWebRequest Req = (HttpWebRequest)WebRequest.Create($"https://discord.com/api/v6/channels/{ChannelId}");
            var Data = Encoding.ASCII.GetBytes("{" + $"\"name\":\"{Name}\",\"type\":{Type},\"topic\":\"{Topic}\",\"bitrate\":\"64000\",\"user_limit\":\"{UserLimite}\",\"nsfw\":\"{IsNSFW}\",\"rate_limit_per_user\":\"{RateLimite}\"" + "}");
            Req.Method = "PATCH";
            Req.UserAgent = UserAgent;
            Req.ContentType = "application/json";
            Req.Headers.Add("authorization", Token);
            Req.ContentLength = Data.Length;

            using (var stream = Req.GetRequestStream()) { stream.Write(Data, 0, Data.Length); }
            var Response = (HttpWebResponse)Req.GetResponse();
            var ResponseInString = new StreamReader(Response.GetResponseStream()).ReadToEnd();
            return ResponseInString;
        }

        public static string SetNsfw(bool NSFW, string ChannelId, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            try
            {
                HttpWebRequest Req = (HttpWebRequest)WebRequest.Create($"https://discord.com/api/v6/channels/{ChannelId}");
                var Data = Encoding.ASCII.GetBytes("{" + $"\"nsfw\":\"{NSFW}\"" + "}");
                Req.Method = "PATCH";
                Req.UserAgent = UserAgent;
                Req.ContentType = "application/json";
                Req.Headers.Add("authorization", Token);
                Req.ContentLength = Data.Length;

                using (var stream = Req.GetRequestStream()) { stream.Write(Data, 0, Data.Length); }
                var Response = (HttpWebResponse)Req.GetResponse();
                var ResponseInString = new StreamReader(Response.GetResponseStream()).ReadToEnd();
                return ResponseInString;
            }
            catch
            {
                return "";
            }
        }

        public static string SetTopic(string Topic, string ChannelId, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            try
            {
                HttpWebRequest Req = (HttpWebRequest)WebRequest.Create($"https://discord.com/api/v6/channels/{ChannelId}");
                var Data = Encoding.ASCII.GetBytes("{" + $"\"topic\":\"{Topic}\"" + "}");
                Req.Method = "PATCH";
                Req.UserAgent = UserAgent;
                Req.ContentType = "application/json";
                Req.Headers.Add("authorization", Token);
                Req.ContentLength = Data.Length;

                using (var stream = Req.GetRequestStream()) { stream.Write(Data, 0, Data.Length); }
                var Response = (HttpWebResponse)Req.GetResponse();
                var ResponseInString = new StreamReader(Response.GetResponseStream()).ReadToEnd();
                return ResponseInString;
            }
            catch
            {
                return "";
            }
        }

        public static string SetName(string Name, string ChannelId, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            try
            {
                HttpWebRequest Req = (HttpWebRequest)WebRequest.Create($"https://discord.com/api/v6/channels/{ChannelId}");
                var Data = Encoding.ASCII.GetBytes("{" + $"\"name\":\"{Name}\"" + "}");
                Req.Method = "PATCH";
                Req.UserAgent = UserAgent;
                Req.ContentType = "application/json";
                Req.Headers.Add("authorization", Token);
                Req.ContentLength = Data.Length;

                using (var stream = Req.GetRequestStream()) { stream.Write(Data, 0, Data.Length); }
                var Response = (HttpWebResponse)Req.GetResponse();
                var ResponseInString = new StreamReader(Response.GetResponseStream()).ReadToEnd();
                return ResponseInString;
            }
            catch
            {
                return "";
            }
        }

        public static string SetRateLimit(string RateLimit, string ChannelId, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            try
            {
                HttpWebRequest Req = (HttpWebRequest)WebRequest.Create($"https://discord.com/api/v6/channels/{ChannelId}");
                var Data = Encoding.ASCII.GetBytes("{" + $"\"rate_limit_per_user\":\"{RateLimit}\"" + "}");
                Req.Method = "PATCH";
                Req.UserAgent = UserAgent;
                Req.ContentType = "application/json";
                Req.Headers.Add("authorization", Token);
                Req.ContentLength = Data.Length;

                using (var stream = Req.GetRequestStream()) { stream.Write(Data, 0, Data.Length); }
                var Response = (HttpWebResponse)Req.GetResponse();
                var ResponseInString = new StreamReader(Response.GetResponseStream()).ReadToEnd();
                return ResponseInString;
            }
            catch
            {
                return "";
            }
        }
    }
}
