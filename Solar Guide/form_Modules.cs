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
    public partial class form_Modules : Form
    {
        public form_Modules()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_module1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button_fr_Click(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form_dasboard mainForm = new Form_dasboard();
            this.Hide();
            mainForm.ShowDialog();
            
        }

        private void button_intro_Click(object sender, EventArgs e)
        {
            Form form_intro = new Form_intro();
            form_intro.Show();
            this.Hide();
        }

        private void button_pv_fund_Click(object sender, EventArgs e)
        {
            Form form_pvfund = new Form_pvfund();
            form_pvfund.Show();
            this.Hide();
        }

        private void button_pv_tech_Click(object sender, EventArgs e)
        {
            Form form_pvtech = new Form_pvtech();
            form_pvtech.Show();
            this.Hide();
        }

        private void button_pv_sys_Click(object sender, EventArgs e)
        {
            Form form_pvsys = new Form_pvsystems();
            form_pvsys.Show();
            this.Hide();
        }

        private void button_other_Click(object sender, EventArgs e)
        {
            Form form_other = new Form_alternative();
            form_other.Show();
            this.Hide();
        }
    }
}
