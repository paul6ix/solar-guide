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
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formDashboard =new Form_dasboard();
            formDashboard.Show();
            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form formLogin = new Form_Register();
            formLogin.Show();
            this.Hide();
        }

        private void Form_login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://facebook.com/login");

        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
          
            pictureBox_facebook.Cursor = Cursors.Hand;
            
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            
            pictureBox_facebook.Cursor = Cursors.Default;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://gmail.com");
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_google.Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_google.Cursor = Cursors.Default;
        }
    }
}
