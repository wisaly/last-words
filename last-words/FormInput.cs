using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace last_words
{
    public partial class FormInput : Form
    {
        public string ans_;
        public FormInput()
        {
            InitializeComponent();

            labelQuestion.Text = ConfigurationManager.AppSettings["preset-question"];
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ans_ = editAns.Text;
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
