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
    public partial class Form_intro : Form
    {
        int score = 0;
        int i = -1;
        int a = 0;
        string[] questions = new string[]
{
         "1. Which of these are not the positive effects of using solar energy.","2. Which of the following is the negative effect of using solar energy.",
           "3. Using solar energy will harm the environment.","4. Which of the following area is preferred for solar power plants:", " 5. What is solar energy?",
           "6. How does solar panels absorb solar energy?","7. What energy is absorbed by the solar panels?",
             "8. The solar or photo voltaic cell converts:",
            "9. Why are some disadvatages of using solar panels","10. The energy radiated by the sun in bright sunny day is about",
            "END OF QUESTION"


};

        string[] answers = new string[] {
          "It harms the environment","It increases home safety","It stabilizes economy", "It reduces pollution",
          "None of the above","It benefits health", "It improves economy", "It reduces pollution",
          "True","False","Don't know","None of the above",
          "Coastal areas","Hot arid zones","Mountain tops","High rainfall zones",
          "Sound energy", "It is the radiant light and heat from the sun", "All of the above","None of the above",
          "By converting photons to electrons", "By converting protons to electrons","By converting electrons to photons","By converting electrons to protons",
          "Sound energy","Solar energy", "Kinetic energy", "Chemical energy",
          "Chemical energy to electrical energy","Solar radiation into electrical energy","Solar radiation into thermal energy","Thermal energy into electrical energy",
          "It is expensive"," It is not very effective at night"," It is not very reliable"," All of the above",
            "END OF QUESTION", "END OF QUESTION", "END OF QUESTION", "END OF QUESTION"

        };

        string[] quizAnswers = new string[] { "reduces pollution", "None of the above", " False", "Hot arid zones",
            "It is the radiant light and heat from the sun","By converting electrons to photons","Solar energy","Solar radiation into electrical energy","All of the above","Series and parallel arrangement of solar cells", "END OF QUESTION"
        };
        public Form_intro()
        {
            InitializeComponent();
        }

       

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            Form_dasboard mainForm = new Form_dasboard();
            this.Hide();
            mainForm.ShowDialog();
        }

        private void button_back_Click_1(object sender, EventArgs e)
        {
            form_Modules backForm = new form_Modules();
            this.Hide();
            backForm.ShowDialog();
        }

        private void Form_intro_Load(object sender, EventArgs e)
        {
            button_Submit_all.Enabled = false;
            button_Submit_all.Visible = false;
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
                button_Submit_all.Visible = true;
                button_Submit_all.Enabled = true;
                button_End_test.Visible = false;
                button_End_test.Enabled = true;
            }


        }

        private void button_End_test_Click(object sender, EventArgs e)
        {
            if (getSelectedAnswer().Equals(quizAnswers[i]))
            {
                score = score + 1;

                label_score.Text = Convert.ToString(score + "0%");
                button_End_test.Enabled = false;
                button_End_test.Visible = false;
                button_submit.Visible = true;
                button_submit.Enabled = true;
                button_submit.Text = "Next";
               

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

      
    }

}
