namespace Solar_Guide
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
            this.button_taketest = new System.Windows.Forms.Button();
            this.button_reading = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_intermediate";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INTERMEDIATE";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_taketest;
        private System.Windows.Forms.Button button_reading;
    }
}