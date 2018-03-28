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
    public partial class Form_reading_2 : Form
    {
        public Form_reading_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Users/Ope/Desktop/Solar Guide/Solar Guide/Solar Guide/Resources/Introduction to PV system.docx");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Users/Ope/Desktop/Solar Guide/Solar Guide/Solar Guide/Resources/PV system Components.docx");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Users/Ope/Desktop/Solar Guide/Solar Guide/Solar Guide/Resources/PV system Design.docx");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Users/Ope/Desktop/Solar Guide/Solar Guide/Solar Guide/Resources/PV system Economics and Ecology.docx");
        }
    }
}
