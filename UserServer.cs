using System;
using System.IO;
using System.Net;
using System.Text;

namespace Discord.REQ
{
    public class UserServer
    {
        public static string DisabledLeaveServer(string ServerID, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            try
            {
                HttpWebRequest Req = WebRequest.CreateHttp($"https://discordapp.com/api/v6/users/@me/guilds/{ServerID}");

                Req.Method = "DELETE";
                Req.UserAgent = UserAgent;
                Req.ContentType = "application/json";
                Req.Headers.Add("authorization", Token);

                using (Stream ReqResponseStream = Req.GetResponse().GetResponseStream())
                {
                    using (StreamReader ReqResponse = new StreamReader(ReqResponseStream))
                    {
                        string Resp = ReqResponse.ReadToEnd();
                        ReqResponse.Close();
                        return Resp;
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public static string JoinServer(string InviteCode, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            try
            {
                var Req = (HttpWebRequest)WebRequest.Create($"https://discord.com/api/v6/invite/{InviteCode}");

                Req.Method = "POST";
                Req.UserAgent = UserAgent;
                Req.ContentType = "application/json";
                Req.Headers.Add("authorization", Token);

                using (Stream ReqResponseStream = Req.GetResponse().GetResponseStream())
                {
                    using (StreamReader ReqResponse = new StreamReader(ReqResponseStream))

                    {
                        string Resp = ReqResponse.ReadToEnd();
                        ReqResponse.Close();
                        return Resp;
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public static string CreateServer(string Name, string Token, string Region = "europe", string Icon = null, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            var Req = (HttpWebRequest)WebRequest.Create("https://discordapp.com/api/v6/guilds");

            var postData = "{" + $"\"name\": \"{Name}\", \"region\": \"{Region}\", \"icon\": \"{Icon}\"" + "}";

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

        public static string DeleteServer(string ServerId, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            var Req = (HttpWebRequest)WebRequest.Create($"https://discordapp.com/api/v6/guilds/{ServerId}/delete");

            var postData = "{}";

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
    }
}