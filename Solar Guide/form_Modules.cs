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
    }
}
