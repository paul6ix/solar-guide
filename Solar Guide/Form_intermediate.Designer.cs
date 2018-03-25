﻿namespace Solar_Guide
{
    partial class Form_intermediate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_intermediate));
            this.button_dashboard = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_taketest = new System.Windows.Forms.Button();
            this.button_reading = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_dashboard
            // 
            this.button_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(10)))), ((int)(((byte)(89)))));
            this.button_dashboard.FlatAppearance.BorderSize = 0;
            this.button_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dashboard.ForeColor = System.Drawing.Color.White;
            this.button_dashboard.Image = global::Solar_Guide.Properties.Resources.menu_2;
            this.button_dashboard.Location = new System.Drawing.Point(521, 462);
            this.button_dashboard.Name = "button_dashboard";
            this.button_dashboard.Size = new System.Drawing.Size(71, 45);
            this.button_dashboard.TabIndex = 16;
            this.button_dashboard.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_dashboard.UseVisualStyleBackColor = false;
            this.button_dashboard.Click += new System.EventHandler(this.button_dashboard_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(10)))), ((int)(((byte)(89)))));
            this.button_back.FlatAppearance.BorderSize = 0;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.ForeColor = System.Drawing.Color.White;
            this.button_back.Image = ((System.Drawing.Image)(resources.GetObject("button_back.Image")));
            this.button_back.Location = new System.Drawing.Point(44, 462);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(71, 45);
            this.button_back.TabIndex = 15;
            this.button_back.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_taketest
            // 
            this.button_taketest.BackColor = System.Drawing.Color.Transparent;
            this.button_taketest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_taketest.FlatAppearance.BorderSize = 0;
            this.button_taketest.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button_taketest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(10)))), ((int)(((byte)(89)))));
            this.button_taketest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_taketest.ForeColor = System.Drawing.SystemColors.Control;
            this.button_taketest.Image = ((System.Drawing.Image)(resources.GetObject("button_taketest.Image")));
            this.button_taketest.Location = new System.Drawing.Point(321, 23);
            this.button_taketest.Name = "button_taketest";
            this.button_taketest.Size = new System.Drawing.Size(296, 224);
            this.button_taketest.TabIndex = 18;
            this.button_taketest.UseVisualStyleBackColor = false;
            this.button_taketest.Click += new System.EventHandler(this.button_taketest_Click);
            // 
            // button_reading
            // 
            this.button_reading.BackColor = System.Drawing.Color.Transparent;
            this.button_reading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_reading.FlatAppearance.BorderSize = 0;
            this.button_reading.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button_reading.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(10)))), ((int)(((byte)(89)))));
            this.button_reading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reading.ForeColor = System.Drawing.SystemColors.Control;
            this.button_reading.Image = ((System.Drawing.Image)(resources.GetObject("button_reading.Image")));
            this.button_reading.Location = new System.Drawing.Point(12, 23);
            this.button_reading.Name = "button_reading";
            this.button_reading.Size = new System.Drawing.Size(296, 224);
            this.button_reading.TabIndex = 17;
            this.button_reading.UseVisualStyleBackColor = false;
            this.button_reading.Click += new System.EventHandler(this.button_reading_Click);
            // 
            // Form_intermediate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Solar_Guide.Properties.Resources.Solar_dark_energy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(634, 661);
            this.Controls.Add(this.button_taketest);
            this.Controls.Add(this.button_reading);
            this.Controls.Add(this.button_dashboard);
            this.Controls.Add(this.button_back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_intermediate";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INTERMEDIATE";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_dashboard;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_taketest;
        private System.Windows.Forms.Button button_reading;
    }
}