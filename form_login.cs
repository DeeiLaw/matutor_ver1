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
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form_register1 = new form_register1();
            form_register1.Closed += (s, args) => this.Close();
            form_register1.Show();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dashboard = new form_dashboard();
            dashboard.Closed += (s, args) => this.Close();
            dashboard.Show();
        }
    }
}
