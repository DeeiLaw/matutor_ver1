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
    public partial class form_register1 : Form
    {
        public form_register1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new form_login();
            login.Closed += (s, args) => this.Close();
            login.Show();
            
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var register2 = new form_register2();
            register2.Closed += (s, args) => this.Close();
            register2.Show();
        }
    }
}
