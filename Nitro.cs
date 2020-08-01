using System;
using System.IO;
using System.Net;
using System.Linq;
using System.Text;

namespace Discord.REQ
{
    public class Nitro
    {
        private static Random randomInstance = new Random();

        private static string GenerateRandomCode()
        {
            string charset = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567891234567891234567891234567891234567891234567";
            return new string(Enumerable.Repeat(charset, 16).Select(new Func<string, char>(getRandomFromStr)).ToArray<char>());
        }

        private static char getRandomFromStr(string inputStr) => inputStr[randomInstance.Next(inputStr.Length)];

        public static bool Check(string NitroCode, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            try
            {
                var Req = (HttpWebRequest)WebRequest.CreateHttp($"https://discord.com/api/v7/entitlements/gift-codes/{NitroCode}");

                Req.Method = "GET";
                Req.UserAgent = UserAgent;

                var Response = (HttpWebResponse)Req.GetResponse();
                var ResponseInString = new StreamReader(Response.GetResponseStream()).ReadToEnd();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string Claim(string NitroCode, string Token, string UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36")
        {
            var Req = (HttpWebRequest)WebRequest.Create($"https://discordapp.com/api/v6/entitlements/gift-codes/{NitroCode}/redeem");
            var Data = Encoding.ASCII.GetBytes("{}");

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

        public static string GenCode()
        {
            string Code = GenerateRandomCode();
            return Code;
        }
    }
}