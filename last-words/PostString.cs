using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace last_words
{
    public class PostString
    {
        List<int> s_ = new List<int>();
        string a_ = "0123456789abcdefghijklmnopqrstuvwxyz!@#$%^&*-+=;:|,()<>[]?.";
        public PostString()
        {
        }
        public string toString()
        {
            string s = "";
            for (int i = s_.Count - 1; i >= 0; i--)
            {
                s += a_[s_[i]];
            }
            return s;
        }
        public void next()
        {
            int i = 0;
            while (i < s_.Count)
            {
                s_[i]++;
                if (s_[i] == a_.Length)
                {
                    s_[i] = 0;
                    i++;
                }
                else
                {
                    break;
                }
            }
            if (i == s_.Count)
            {
                s_.Add(0);
            }
        }

        public void rand(int digits)
        {
            s_.Clear();
            Random rnd = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < digits; i++)
            {
                s_.Add(rnd.Next(a_.Length));
            }
        }

        public void load(string s)
        {
            s_.Clear();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                s_.Add(a_.IndexOf(s[i]));
            }
        }
        public decimal distance()
        {
            decimal d = 0;
            for (int i = 0; i < s_.Count; i++)
            {
                d = d * a_.Length + s_[i];
            }
            return d;
        }
    }
}
