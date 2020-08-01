using System;
using System.IO;
using System.Net;
using System.Text;

namespace Discord.REQ
{
	// Token: 0x02000009 RID: 9
	public class Server
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00003768 File Offset: 0x00001968
		public static string Leave(string ServerID, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://discordapp.com/api/v6/users/@me/guilds/" + ServerID);
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

		// Token: 0x06000028 RID: 40 RVA: 0x00003834 File Offset: 0x00001A34
		public static string Join(string InviteCode, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://discord.com/api/v6/invite/" + InviteCode);
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

		// Token: 0x06000029 RID: 41 RVA: 0x00003900 File Offset: 0x00001B00
		public static string Create(string Name, string Token, string Region = "europe", string Icon = null, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://discordapp.com/api/v6/guilds");
			byte[] bytes = Encoding.ASCII.GetBytes(string.Concat(new string[]
			{
				"{\"name\": \"",
				Name,
				"\", \"region\": \"",
				Region,
				"\", \"icon\": \"",
				Icon,
				"\"}"
			}));
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

		// Token: 0x0600002A RID: 42 RVA: 0x000039F8 File Offset: 0x00001BF8
		public static string Delete(string ServerId, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://discordapp.com/api/v6/guilds/" + ServerId + "/delete");
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

		// Token: 0x0600002B RID: 43 RVA: 0x00003AC8 File Offset: 0x00001CC8
		public static string BanUser(string UserId, string GuildId, string Token, string DeleteMessagesDays = "1", string Reason = "", string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://discord.com/api/v6/guilds/" + GuildId + "/bans/" + UserId);
			byte[] bytes = Encoding.ASCII.GetBytes(string.Concat(new string[]
			{
				"{\"delete_message_days\": \"",
				DeleteMessagesDays,
				"\", \"reason\": \"",
				Reason,
				"\"}"
			}));
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

		// Token: 0x0600002C RID: 44 RVA: 0x00003BC4 File Offset: 0x00001DC4
		public static string UnBanUser(string UserId, string GuildId, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://discord.com/api/v6/guilds/" + GuildId + "/bans/" + UserId);
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

		// Token: 0x0600002D RID: 45 RVA: 0x00003C98 File Offset: 0x00001E98
		public static string KickUser(string UserId, string GuildId, string Token, string Reason = "", string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string.Concat(new string[]
			{
				"https://discord.com/api/v6/guilds/",
				GuildId,
				"/members/",
				UserId,
				"?reason=",
				Reason
			}));
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

		// Token: 0x0600002E RID: 46 RVA: 0x00003D88 File Offset: 0x00001F88
		public static string CreateRole(string GuildId, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://discord.com/api/v6/guilds/" + GuildId + "/roles");
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

		// Token: 0x0600002F RID: 47 RVA: 0x00003E58 File Offset: 0x00002058
		public static string DeleteRole(string GuildId, string RoleId, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://discord.com/api/v6/guilds/" + GuildId + "/roles/" + RoleId);
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

		// Token: 0x06000030 RID: 48 RVA: 0x00003F2C File Offset: 0x0000212C
		public static string SetRoleName(string Name, string GuildId, string RoleId, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://discord.com/api/v6/guilds/" + GuildId + "/roles/" + RoleId);
			byte[] bytes = Encoding.ASCII.GetBytes("{\"name\": \"" + Name + "\"}");
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

		// Token: 0x06000031 RID: 49 RVA: 0x0000400C File Offset: 0x0000220C
		public static string SetRolePermissions(string PermissionNumber, string GuildId, string RoleId, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://discord.com/api/v6/guilds/" + GuildId + "/roles/" + RoleId);
			byte[] bytes = Encoding.ASCII.GetBytes("{\"permissions\": \"" + PermissionNumber + "\"}");
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

		// Token: 0x06000032 RID: 50 RVA: 0x000040EC File Offset: 0x000022EC
		public static string SetRoleColor(string ColorNumber, string GuildId, string RoleId, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://discord.com/api/v6/guilds/" + GuildId + "/roles/" + RoleId);
			byte[] bytes = Encoding.ASCII.GetBytes("{\"color\": \"" + ColorNumber + "\"}");
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

		// Token: 0x06000033 RID: 51 RVA: 0x000041CC File Offset: 0x000023CC
		public static string SetRoleMentionable(string GuildId, string RoleId, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://discord.com/api/v6/guilds/" + GuildId + "/roles/" + RoleId);
			byte[] bytes = Encoding.ASCII.GetBytes("{\"mentionable\":\"true\"}");
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

		// Token: 0x06000034 RID: 52 RVA: 0x000042A0 File Offset: 0x000024A0
		public static string SetRoleUnMentionable(string GuildId, string RoleId, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://discord.com/api/v6/guilds/" + GuildId + "/roles/" + RoleId);
			byte[] bytes = Encoding.ASCII.GetBytes("{\"mentionable\":\"false\"}");
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
	}
}
