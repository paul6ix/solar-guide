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
    public partial class Form_intermediate : Form
    {
        public Form_intermediate()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            form_Modules backForm = new form_Modules();
            this.Hide();
            backForm.ShowDialog();
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            Form_dasboard mainForm = new Form_dasboard();
            this.Hide();
            mainForm.ShowDialog();
        }
    }
}
