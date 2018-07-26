using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace last_words
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormInput frm = new FormInput();
            if (frm.ShowDialog() != DialogResult.OK)
                return;

            string ans = frm.ans_;
            string salt1 = ConfigurationManager.AppSettings["salt1"];
            string salt2 = ConfigurationManager.AppSettings["salt2"];
            string salt3 = ConfigurationManager.AppSettings["salt3"];
            string keyHash = ConfigurationManager.AppSettings["key-hash"];
            string encrypted = ConfigurationManager.AppSettings["encrypted-text"];

            string initHash = GetHash.hash(ans, salt1);
            PostString ps = new PostString();
            int cnt = 0;
            while(true)
            {
                ps.next();
                string tryKey = initHash + ps.toString();
                string tryKeyHash = GetHash.hash(tryKey, salt2);
                if (cnt % 1000 == 0)
                {
                    cnt = 0;
                    Console.WriteLine(tryKeyHash);
                }
                if (tryKeyHash == keyHash)
                {
                    Console.WriteLine("calculation finished with {0}", ps.toString());
                    string key = GetHash.hash(tryKey, salt3);
                    Console.WriteLine("key is {0}", key);
                    string decrypted = TextEncrypt.decrypt(encrypted, key);
                    MessageBox.Show(decrypted);
                    return;
                }
                cnt++;
            }
        }
    }
}
