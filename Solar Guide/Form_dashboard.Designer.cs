namespace Solar_Guide
{
    partial class Form_dasboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_dasboard));
            this.button_logout = new System.Windows.Forms.Button();
            this.button_reading = new System.Windows.Forms.Button();
            this.button_taketest = new System.Windows.Forms.Button();
            this.button_result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_logout
            // 
            this.button_logout.AutoSize = true;
            this.button_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(25)))), ((int)(((byte)(77)))));
            this.button_logout.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.ForeColor = System.Drawing.Color.Snow;
            this.button_logout.Location = new System.Drawing.Point(806, 454);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(100, 37);
            this.button_logout.TabIndex = 3;
            this.button_logout.Text = "Log Out";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
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
            this.button_reading.Location = new System.Drawing.Point(9, 12);
            this.button_reading.Name = "button_reading";
            this.button_reading.Size = new System.Drawing.Size(296, 224);
            this.button_reading.TabIndex = 4;
            this.button_reading.UseVisualStyleBackColor = false;
            this.button_reading.Click += new System.EventHandler(this.button_reading_Click);
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
            this.button_taketest.Location = new System.Drawing.Point(318, 12);
            this.button_taketest.Name = "button_taketest";
            this.button_taketest.Size = new System.Drawing.Size(296, 224);
            this.button_taketest.TabIndex = 5;
            this.button_taketest.UseVisualStyleBackColor = false;
            this.button_taketest.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_result
            // 
            this.button_result.BackColor = System.Drawing.Color.Transparent;
            this.button_result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_result.FlatAppearance.BorderSize = 0;
            this.button_result.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button_result.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(10)))), ((int)(((byte)(89)))));
            this.button_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_result.ForeColor = System.Drawing.SystemColors.Control;
            this.button_result.Image = ((System.Drawing.Image)(resources.GetObject("button_result.Image")));
            this.button_result.Location = new System.Drawing.Point(623, 12);
            this.button_result.Name = "button_result";
            this.button_result.Size = new System.Drawing.Size(296, 224);
            this.button_result.TabIndex = 6;
            this.button_result.UseVisualStyleBackColor = false;
            // 
            // Form_dasboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 518);
            this.Controls.Add(this.button_result);
            this.Controls.Add(this.button_taketest);
            this.Controls.Add(this.button_reading);
            this.Controls.Add(this.button_logout);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "Form_dasboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solar Guide Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_reading;
        private System.Windows.Forms.Button button_taketest;
        private System.Windows.Forms.Button button_result;
    }
}

