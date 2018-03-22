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
    public partial class Form_quiz : Form
    {
        public int ans = 0;
        public Form_quiz() {    
 
            InitializeComponent();
        }



        private void textBox_quiz2_TextChanged(object sender, EventArgs e)
        {
            String input = textBox_quiz2.Text;
            if (input.Equals("D"))
            {
                MessageBox.Show("Correct Answer");
                ans = ans + 1;
            }

            else if (input.Equals(""))
            {
                textBox_quiz2.Text = null;
            }
            else
            {
                MessageBox.Show("incorrect Answer");
            }
        }

        private void Form_quiz_Load(object sender, EventArgs e)
        {

        }

        private void textBox_quiz1_TextChanged(object sender, EventArgs e)
        {

        String input = textBox_quiz1.Text;
        if (input.Equals("C"))
        {
            MessageBox.Show("Correct Answer");
            ans = ans + 1;
        }

        else if (input.Equals(""))
        {
            textBox_quiz1.Text = null;
        }
        else
        {
            MessageBox.Show("incorrect Answer");
        }
    }
    }
}
