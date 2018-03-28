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
    public partial class Form_splash : Form
    {
        int timeLeft = 0;
        public Form_splash()
        {
            InitializeComponent();
        }

        private void Form_splash_Load(object sender, EventArgs e)
        {
            timeLeft = 10;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
            }
            else
            {
                timer1.Stop();
                Form formLogin = new Form_login();
                formLogin.Show();
                this.Hide();
            }
        }
    }
}
