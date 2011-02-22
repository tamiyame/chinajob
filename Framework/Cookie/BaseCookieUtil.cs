using System;
using System.Text;
using System.Security.Cryptography;

namespace Com.Framework.Cookie
{
    public class BaseCookieUtil
    {
        public static string Encoding(string Value)
        {
            UTF8Encoding u8e = new UTF8Encoding();
            byte[] buffer = u8e.GetBytes(Value);

            return Convert.ToBase64String(buffer);
        }

        public static string Decoding(string Value)
        {
            UTF8Encoding u8e = new UTF8Encoding();
            byte[] buffer = Convert.FromBase64String(Value);

            return u8e.GetString(buffer);
        }
    }
}
