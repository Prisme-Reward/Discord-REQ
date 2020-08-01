using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Discord.REQ
{
    public class Reaction
    {
		public static string React(string messageid, string channelid, string emojiurlencoded, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create($"https://discordapp.com/api/v6/channels/{channelid}/messages/{messageid}/reactions/{emojiurlencoded}/@me");
			byte[] bytes = Encoding.ASCII.GetBytes("{}");
			httpWebRequest.Method = "PUT";
			httpWebRequest.UserAgent = UserAgent;
			httpWebRequest.ContentType = "application/json";
			httpWebRequest.Headers.Add("authorization", Token);
			httpWebRequest.ContentLength = (long)bytes.Length;
			using (Stream requestStream = httpWebRequest.GetRequestStream())
			{
				requestStream.Write(bytes, 0, bytes.Length);
			}
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			return new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
		}

		public static string UnReact(string messageid, string channelid, string emojiurlencoded, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create($"https://discordapp.com/api/v6/channels/{channelid}/messages/{messageid}/reactions/{emojiurlencoded}/@me");
			byte[] bytes = Encoding.ASCII.GetBytes("{}");
			httpWebRequest.Method = "DELETE";
			httpWebRequest.UserAgent = UserAgent;
			httpWebRequest.ContentType = "application/json";
			httpWebRequest.Headers.Add("authorization", Token);
			httpWebRequest.ContentLength = (long)bytes.Length;
			using (Stream requestStream = httpWebRequest.GetRequestStream())
			{
				requestStream.Write(bytes, 0, bytes.Length);
			}
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			return new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
		}

		public static string DeleteAllReact(string messageid, string channelid,  string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create($"https://discordapp.com/api/v6/channels/{channelid}/messages/{messageid}/reactions/");
			byte[] bytes = Encoding.ASCII.GetBytes("{}");
			httpWebRequest.Method = "DELETE";
			httpWebRequest.UserAgent = UserAgent;
			httpWebRequest.ContentType = "application/json";
			httpWebRequest.Headers.Add("authorization", Token);
			httpWebRequest.ContentLength = (long)bytes.Length;
			using (Stream requestStream = httpWebRequest.GetRequestStream())
			{
				requestStream.Write(bytes, 0, bytes.Length);
			}
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			return new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
		}

		public static string DeleteEmoji(string emojiid, string guildid, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create($"https://discordapp.com/api/v6/guilds/{guildid}/emojis/{emojiid}");
			byte[] bytes = Encoding.ASCII.GetBytes("{}");
			httpWebRequest.Method = "DELETE";
			httpWebRequest.UserAgent = UserAgent;
			httpWebRequest.ContentType = "application/json";
			httpWebRequest.Headers.Add("authorization", Token);
			httpWebRequest.ContentLength = (long)bytes.Length;
			using (Stream requestStream = httpWebRequest.GetRequestStream())
			{
				requestStream.Write(bytes, 0, bytes.Length);
			}
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			return new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
		}
	}
}
