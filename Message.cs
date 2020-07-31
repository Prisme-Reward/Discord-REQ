using System;
using System.IO;
using System.Net;
using System.Text;

namespace Discord.REQ
{
    public class Message
    {
        public static string SendMessage(string Message, string ChannelId, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            try
            {
                var Req = (HttpWebRequest)WebRequest.Create($"https://discordapp.com/api/v6/channels/{ChannelId}/messages");

                var postData = "{" + $"\"content\":\"{Message}\"" + "}";

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
            catch (Exception)
            {
                return "Error :(";
            }
        }

        public static string PinsMessage(string channelid, string messageid, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            try
            {
                HttpWebRequest Req = WebRequest.CreateHttp($"https://discordapp.com/api/v6/channels/{channelid}/pins/{messageid}");
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

        public static string DeleteMessage(string chanid, string messageid, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            try
            {
                HttpWebRequest Req = WebRequest.CreateHttp($"https://discordapp.com/api/v6/channels/{chanid}/messages/{messageid}");

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

        public static string Typing(string Channelid, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            var Req = (HttpWebRequest)WebRequest.Create($"https://discordapp.com/api/v6/channels/{Channelid}/typing");

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