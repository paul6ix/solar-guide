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
    public partial class form_beginner : Form
    {
        public form_beginner()
        {
            InitializeComponent();
        }

        
        

        private void button_back_Click(object sender, EventArgs e)
        {
            Form_dasboard mainForm = new Form_dasboard();
            this.Hide();
            mainForm.ShowDialog();
            
        }

        

        

       

        private void button_reading_Click(object sender, EventArgs e)
        {
            string folderName = @"c:\\";
            string pathString = System.IO.Path.Combine(folderName, "temp");
            System.IO.Directory.CreateDirectory(pathString);
            String openPDFFile = "C:\\temp\\module_1.pdf";
            System.IO.File.WriteAllBytes(openPDFFile, global::Solar_Guide.Properties.Resources.module_1);
            System.Diagnostics.Process.Start(openPDFFile);
        }

        private void button_taketest_Click(object sender, EventArgs e)
        {
            Form form_module1 = new Form_Module1();
            form_module1.Show();
            this.Hide();
        }
    }
}
