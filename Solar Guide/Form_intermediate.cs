﻿using System;
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
            form_beginner backForm = new form_beginner();
            this.Hide();
            backForm.ShowDialog();
        }

        private void button_dashboard_Click(object sender, EventArgs e)
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
            String openPDFFile = "C:\\temp\\module2.pdf";
            System.IO.File.WriteAllBytes(openPDFFile, global::Solar_Guide.Properties.Resources.module2);
            System.Diagnostics.Process.Start(openPDFFile);
        }

        private void button_taketest_Click(object sender, EventArgs e)
        {
            Form formModule = new Form_Module2();
            formModule.Show();
            this.Hide();
        }
    }
}
