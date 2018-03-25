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

    public partial class Form_test : Form
    {
                int score = 0;
                int i = -1;
                int a = 0;
                string[] questions = new string[]
        {
            "1. The solar or photo voltaic cell converts", "2. Solar cells are made of?",
            "3. A module is a","4. The efficiency of solar cells is about", "5. The voltage of solar cells is",
            "6. The output of solar cells is of the order of","7. Sun tracking system is required in the case of",
             "8. Which of the following area is preferred for solar power plants",
            "9. Most of the solar radiation received on the earth surface is within the range of","10. The energy radiated by the sun in bright sunny day is about",
            "END OF QUESTION"


        };

                string[] answers = new string[] {
            "Chemical energy to electrical", "energy Solar radiation into electrical energy", "Solar radiation into thermal energy", "Thermal energy into electrical energy",
            "Aluminium", "Germanium",  "Silicon", "Cadmium",
            "Series-arrangement of solar cells", "Parallel arrangement of solar cells"," Series-parallel arrangement of solar cells","None of the above",
            "25%", "15%", "40%", "60%",
            "0.5 to 1 V",  "1 to 2 V", "2 to 3 V", "4 to 5 V",
            "0.5 watts", "1.0 watts", "5.0 watts", "10 watts",
             "Cylindrical and parabolic and paraboloid" ,"Flat plate collector" , "Both (a) and (b)", "None of the above",
              "Coastal areas", "Hot arid zones", "Mountain tops", "High rainfall zones",
              "0.25 to 0.4 micron", "0.4 to 0.8 microns" ,"0.6 to 0.95 microns", "0.1 to 0.25 microns",
              "2.5 kW/m2", "1.0 kW/m2", "500 W/m2", "200 W/m2",
              "END OF QUESTION", "END OF QUESTION", "END OF QUESTION", "END OF QUESTION"

        };

        string[] quizAnswers = new string[] { "energy Solar radiation into electrical energy", "Silicon", " Series-parallel arrangement of solar cells", "60%",
            "0.5 to 1 V","1.0 watts","Cylindrical and parabolic and paraboloid","Hot arid zones","0.25 to 0.4 micron","1.0 kW/m2", "END OF QUESTION"
        };

        public Form_test()
        {
            InitializeComponent();
        }

        private void Form_text_Load(object sender, EventArgs e)
        {
            button_module1.Enabled = false;
            button_module2.Enabled = false;
            button_module3.Enabled = false;
            button_End_test.Enabled = false;
            button_End_test.Visible = false;
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            if (i < questions.Length)
            {
                i++;

                label_questions.Text = questions[i];

                radioButton_A.Text = answers[a];
                a++;
                radioButton_B.Text = answers[a];
                a++;
                radioButton_C.Text = answers[a];
                a++;
                radioButton_D.Text = answers[a];
                a++;
                button_submit.Visible = false;
                button_submit.Enabled = false;
                button_End_test.Visible = true;
                button_End_test.Enabled = true;


            }
            if (i == 10)
            {
                MessageBox.Show("Please select available module", "Test ended", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                button_End_test.Visible = false;
                button_End_test.Enabled = true;
            }

        }
       

        private void button_End_test_Click(object sender, EventArgs e)
        {
            if (getSelectedAnswer().Equals(quizAnswers[i]))
            {
                score = score + 1;
              
                label_score.Text = Convert.ToString(score+"0%");
                button_End_test.Enabled = false;
                button_End_test.Visible = false;
                button_submit.Visible = true;
                button_submit.Enabled = true;
                button_submit.Text = "Next";
              if(score < 4)
                {
                    
                    button_module1.Enabled = true;
                    button_module2.Enabled = false;
                    button_module3.Enabled = false;

                }
             else if (score >4 && score < 7)
                {
                    
                    button_module1.Enabled = false;
                    button_module2.Enabled = true;
                    button_module3.Enabled = false;
                }
                else if (score > 7)
                {
                   
                    button_module1.Enabled = false;
                    button_module2.Enabled = false;
                    button_module3.Enabled = true;
                }
               

            }
            else
            {
                button_End_test.Enabled = false;
                button_End_test.Enabled = false;
                button_submit.Visible = true;
                button_submit.Enabled = true;
                button_submit.Text = "Next";
            }

        }

        string getSelectedAnswer()
        {
            if (radioButton_A.Checked)
                return radioButton_A.Text.ToString();
            if (radioButton_B.Checked)
                return radioButton_B.Text.ToString();
            if (radioButton_C.Checked)
                return radioButton_C.Text.ToString();
            if (radioButton_D.Checked)
                return radioButton_D.Text.ToString();
            return "";
        }

        private void button_module1_Click(object sender, EventArgs e)
        {
            Form formBeginner = new form_beginner();
            formBeginner.Show();
            this.Hide();
        }

        private void button_module2_Click(object sender, EventArgs e)
        {
            Form formIntermediate = new Form_intermediate();
            formIntermediate.Show();
            this.Hide();
        }

        private void button_module3_Click(object sender, EventArgs e)
        {
            Form formExpert = new Form_expert();
            formExpert.Show();
            this.Hide();
        }
    }
}
