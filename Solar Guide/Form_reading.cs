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
    public partial class Form_reading : Form
    {
        public Form_reading()
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

        private void button_intro_Click(object sender, EventArgs e)

        {
            
            String openPDFFile = "C:\\temp\\module_1.pdf";
            System.IO.File.WriteAllBytes(openPDFFile, global::Solar_Guide.Properties.Resources.module_1);
            System.Diagnostics.Process.Start(openPDFFile);
          
        }

        private void button_pv_fund_Click(object sender, EventArgs e)
        {
            String openPDFFile = "C:\\temp\\module2.pdf";
            System.IO.File.WriteAllBytes(openPDFFile, global::Solar_Guide.Properties.Resources.module2  );
            System.Diagnostics.Process.Start(openPDFFile);
        }

        private void Form_reading_Load(object sender, EventArgs e)
        {
            string folderName = @"c:\\";
            string pathString = System.IO.Path.Combine(folderName, "temp");
            System.IO.Directory.CreateDirectory(pathString);
        }

        private void button_pv_tech_Click(object sender, EventArgs e)
        {
            String openPDFFile = "C:\\temp\\module3.pdf";
            System.IO.File.WriteAllBytes(openPDFFile, global::Solar_Guide.Properties.Resources.module3);
            System.Diagnostics.Process.Start(openPDFFile);
        }
    }
}
