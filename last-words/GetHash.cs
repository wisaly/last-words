using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace last_words
{
    public class GetHash
    {
        public static string hash(string text, string salt)
        {
            byte[] buf = Encoding.UTF8.GetBytes(salt + text);
            SHA512 sha = new SHA512CryptoServiceProvider();
            byte[] hbuf = sha.ComputeHash(buf);
            return Convert.ToBase64String(hbuf);
        }
    }
}
