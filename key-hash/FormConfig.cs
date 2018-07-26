using last_words;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace key_hash
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();

            editPreQues.Text = ConfigurationManager.AppSettings["preset-question"];
            editSalt1.Text = ConfigurationManager.AppSettings["salt1"];
            editSalt2.Text = ConfigurationManager.AppSettings["salt2"];
            editSalt3.Text = ConfigurationManager.AppSettings["salt3"];
        }

        private void btnRand_Click(object sender, EventArgs e)
        {
            PostString ps = new PostString();
            ps.rand((int)editRandDigits.Value);
            editPostStr.Text = ps.toString();
        }

        decimal speed_ = 0M;
        private void btnSpeed_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            string hs = GetHash.hash("test", editSalt1.Text);
            PostString ps = new PostString();
            decimal cnt = 0;
            sw.Start();
            while (true)
            {
                string hs2 = GetHash.hash(hs + ps.toString(), editSalt2.Text);
                cnt++;
                if (sw.ElapsedMilliseconds > 3000)
                {
                    sw.Stop();
                    break;
                }
            }

            speed_ = cnt / (sw.ElapsedMilliseconds / 1000);
            labelSpeed.Text = string.Format("{0} h/s", speed_);
            editPostStr_TextChanged(null, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["preset-question"].Value = editPreQues.Text;
            config.AppSettings.Settings["salt1"].Value = editSalt1.Text;
            config.AppSettings.Settings["salt2"].Value = editSalt2.Text;
            config.AppSettings.Settings["salt3"].Value = editSalt3.Text;
            config.AppSettings.Settings["key-hash"].Value =
                GetHash.hash(GetHash.hash(editPreAns.Text, editSalt1.Text) + editPostStr.Text, editSalt2.Text);
            config.AppSettings.Settings["encrypted-text"].Value = TextEncrypt.encrypt(editText.Text,
                GetHash.hash(GetHash.hash(editPreAns.Text, editSalt1.Text) + editPostStr.Text, editSalt3.Text));
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            File.Copy("key-hash.exe.config", "last-words.exe.config", true);
            MessageBox.Show("已保存");
        }

        private void editPostStr_TextChanged(object sender, EventArgs e)
        {
            if (speed_ == 0)
                return;
            PostString ps = new PostString();
            ps.load(editPostStr.Text);
            decimal dist = ps.distance();
            decimal elapSec = dist / speed_;
            decimal elapMin = elapSec / 60;
            decimal elapHor = elapMin / 60;
            decimal elapDay = elapHor / 24;
            elapHor %= 24;
            elapMin %= 60;
            elapSec %= 60;
            labelExpect.Text = string.Format("{0}天{1}小时{2}分{3}秒", (int)elapDay, (int)elapHor, (int)elapMin, (int)elapSec);
        }
    }
}
