using System;
using System.IO;
using System.Net;
using System.Text;

namespace Discord.REQ
{
	// Token: 0x02000005 RID: 5
	public class Message
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002970 File Offset: 0x00000B70
		public static string Send(string Message, string ChannelId, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://discordapp.com/api/v6/channels/" + ChannelId + "/messages");
			byte[] bytes = Encoding.ASCII.GetBytes("{\"content\":\"" + Message + "\"}");
			httpWebRequest.Method = "POST";
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
		public static string Edit(string Message, string Messageid, string ChannelId, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create($"https://discordapp.com/api/v6/channels/{ChannelId}/messages/{Messageid}");
			byte[] bytes = Encoding.ASCII.GetBytes("{\"content\":\"" + Message + "\"}");
			httpWebRequest.Method = "PATCH";
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



		// Token: 0x06000014 RID: 20 RVA: 0x00002A4C File Offset: 0x00000C4C
		public static string Pins(string channelid, string messageid, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://discordapp.com/api/v6/channels/" + channelid + "/pins/" + messageid);
			byte[] bytes = Encoding.ASCII.GetBytes("{}");
			httpWebRequest.Method = "POST";
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

		public static string DeleteBulk(string chanid, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://discordapp.com/api/v6/channels/" + chanid + "/messages/bulk_delete");
			byte[] bytes = Encoding.ASCII.GetBytes("{}");
			httpWebRequest.Method = "POST";
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



		// Token: 0x06000015 RID: 21 RVA: 0x00002B20 File Offset: 0x00000D20
		public static string Delete(string chanid, string messageid, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://discordapp.com/api/v6/channels/" + chanid + "/messages/" + messageid);
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

		// Token: 0x06000016 RID: 22 RVA: 0x00002BF4 File Offset: 0x00000DF4
		public static string Typing(string Channelid, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://discordapp.com/api/v6/channels/" + Channelid + "/typing");
			byte[] bytes = Encoding.ASCII.GetBytes("{}");
			httpWebRequest.Method = "POST";
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
