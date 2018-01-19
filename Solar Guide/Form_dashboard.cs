using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solar_Guide
{
    public partial class Form_dasboard : Form
    {
        public Form_dasboard()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Form formLogin = new Form_login();

            formLogin.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form formModule = new form_Modules();
            formModule.Show();
            this.Hide();

        }

        private void button_reading_Click(object sender, EventArgs e)
        {
            Form formModule = new form_Modules();
            formModule.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formModule = new form_Modules();
            formModule.Show();
            this.Hide();
        }
    }
}
