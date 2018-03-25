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
    public partial class Form_expert : Form
    {
        public Form_expert()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            form_beginner backForm = new form_beginner();
            this.Hide();
            backForm.ShowDialog();
        }

        

       

        private void Form_reading_Load(object sender, EventArgs e)
        {
            string folderName = @"c:\\";
            string pathString = System.IO.Path.Combine(folderName, "temp");
            System.IO.Directory.CreateDirectory(pathString);
        }

       

        private void button_reading_Click(object sender, EventArgs e)
        {
            string folderName = @"c:\\";
            string pathString = System.IO.Path.Combine(folderName, "temp");
            System.IO.Directory.CreateDirectory(pathString);
            String openPDFFile = "C:\\temp\\module3.pdf";
            System.IO.File.WriteAllBytes(openPDFFile, global::Solar_Guide.Properties.Resources.module3);
            System.Diagnostics.Process.Start(openPDFFile);
        }

        private void button_taketest_Click(object sender, EventArgs e)
        {
            Form formModule3 = new Form_module3();
            formModule3.Show();
            this.Hide();
        }
    }
}
