using System.IO;
using System.Net;
using System.Text;

namespace Discord.REQ
{
    public class Voice
    {
        public static string Call(string UserChannelId, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            HttpWebRequest Req = (HttpWebRequest)WebRequest.Create($"https://discord.com/api/v6/channels/{UserChannelId}/call/ring");
            var Data = Encoding.ASCII.GetBytes("{\"recipients\": null}");
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