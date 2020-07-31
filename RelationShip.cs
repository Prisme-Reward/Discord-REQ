using System;
using System.IO;
using System.Net;
using System.Text;

namespace Discord.REQ
{
    public class RelationShip

    {
        public static string RemoveFriend(string FriendId, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            try
            {
                HttpWebRequest Req = WebRequest.CreateHttp($"https://discordapp.com/api/v6/users/@me/relationships/{FriendId}");

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

        public static string AddFriend(string FriendId, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            try
            {
                HttpWebRequest Req = WebRequest.CreateHttp($"https://discordapp.com/api/v6/users/@me/relationships/{FriendId}");

                var postData = "{}";

                var data = Encoding.ASCII.GetBytes(postData);

                Req.Method = "PUT";
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
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public static string BlockUser(string UserId, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            try
            {
                HttpWebRequest Req = WebRequest.CreateHttp($"https://discordapp.com/api/v6/users/@me/relationships/{UserId}");

                var postData = "{" + "\"type\":\"2\"" + "}";

                var data = Encoding.ASCII.GetBytes(postData);

                Req.Method = "PUT";
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
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public static string UnBlockUser(string UserId, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            try
            {
                HttpWebRequest Req = WebRequest.CreateHttp($"https://discordapp.com/api/v6/users/@me/relationships/{UserId}");

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
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
