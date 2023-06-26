using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matutor_ver1
{
    public partial class form_register2 : Form
    {
        public form_register2()
        {
            InitializeComponent();
        }

        private void button_learn_Click(object sender, EventArgs e)
        {
            button_learn.Enabled = false;
            button_learn.BackColor = ColorTranslator.FromHtml("#5765ff");
            
            button_teach.Enabled = true;
            button_teach.BackColor = Color.Gold;
            label_userType.Text = "learn";
        }

        private void button_teach_Click(object sender, EventArgs e)
        {
            button_teach.Enabled = false;
            button_teach.BackColor = ColorTranslator.FromHtml("#5765ff");

            button_learn.Enabled = true;
            button_learn.BackColor = Color.Gold;
            label_userType.Text = "teach";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new form_login();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }
    }
}
