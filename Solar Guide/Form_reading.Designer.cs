namespace Solar_Guide
{
    partial class Form_reading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_reading));
            this.button_dashboard = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_pv_tech = new System.Windows.Forms.Button();
            this.button_pv_fund = new System.Windows.Forms.Button();
            this.button_intro = new System.Windows.Forms.Button();
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
            this.button_dashboard.Location = new System.Drawing.Point(526, 423);
            this.button_dashboard.Name = "button_dashboard";
            this.button_dashboard.Size = new System.Drawing.Size(71, 45);
            this.button_dashboard.TabIndex = 28;
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
            this.button_back.Location = new System.Drawing.Point(49, 423);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(71, 45);
            this.button_back.TabIndex = 27;
            this.button_back.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_pv_tech
            // 
            this.button_pv_tech.BackColor = System.Drawing.Color.Transparent;
            this.button_pv_tech.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_pv_tech.FlatAppearance.BorderSize = 0;
            this.button_pv_tech.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button_pv_tech.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(37)))), ((int)(((byte)(69)))));
            this.button_pv_tech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pv_tech.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pv_tech.ForeColor = System.Drawing.Color.White;
            this.button_pv_tech.Image = ((System.Drawing.Image)(resources.GetObject("button_pv_tech.Image")));
            this.button_pv_tech.Location = new System.Drawing.Point(22, 228);
            this.button_pv_tech.Name = "button_pv_tech";
            this.button_pv_tech.Size = new System.Drawing.Size(600, 60);
            this.button_pv_tech.TabIndex = 31;
            this.button_pv_tech.Text = "EXPERT";
            this.button_pv_tech.UseVisualStyleBackColor = false;
            this.button_pv_tech.Click += new System.EventHandler(this.button_pv_tech_Click);
            // 
            // button_pv_fund
            // 
            this.button_pv_fund.BackColor = System.Drawing.Color.Transparent;
            this.button_pv_fund.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_pv_fund.FlatAppearance.BorderSize = 0;
            this.button_pv_fund.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button_pv_fund.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(37)))), ((int)(((byte)(69)))));
            this.button_pv_fund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pv_fund.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pv_fund.ForeColor = System.Drawing.Color.White;
            this.button_pv_fund.Image = ((System.Drawing.Image)(resources.GetObject("button_pv_fund.Image")));
            this.button_pv_fund.Location = new System.Drawing.Point(22, 136);
            this.button_pv_fund.Name = "button_pv_fund";
            this.button_pv_fund.Size = new System.Drawing.Size(600, 60);
            this.button_pv_fund.TabIndex = 30;
            this.button_pv_fund.Text = "INTERMEDIATE";
            this.button_pv_fund.UseVisualStyleBackColor = false;
            this.button_pv_fund.Click += new System.EventHandler(this.button_pv_fund_Click);
            // 
            // button_intro
            // 
            this.button_intro.BackColor = System.Drawing.Color.Transparent;
            this.button_intro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_intro.FlatAppearance.BorderSize = 0;
            this.button_intro.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button_intro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(37)))), ((int)(((byte)(69)))));
            this.button_intro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_intro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_intro.ForeColor = System.Drawing.Color.White;
            this.button_intro.Image = ((System.Drawing.Image)(resources.GetObject("button_intro.Image")));
            this.button_intro.Location = new System.Drawing.Point(22, 52);
            this.button_intro.Name = "button_intro";
            this.button_intro.Size = new System.Drawing.Size(600, 60);
            this.button_intro.TabIndex = 29;
            this.button_intro.Text = "BEGINNER";
            this.button_intro.UseVisualStyleBackColor = false;
            this.button_intro.Click += new System.EventHandler(this.button_intro_Click);
            // 
            // Form_reading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Solar_Guide.Properties.Resources.Solar_dark_energy_blur;
            this.ClientSize = new System.Drawing.Size(634, 661);
            this.Controls.Add(this.button_pv_tech);
            this.Controls.Add(this.button_pv_fund);
            this.Controls.Add(this.button_intro);
            this.Controls.Add(this.button_dashboard);
            this.Controls.Add(this.button_back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_reading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "READING MODULES";
            this.Load += new System.EventHandler(this.Form_reading_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_dashboard;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_pv_tech;
        private System.Windows.Forms.Button button_pv_fund;
        private System.Windows.Forms.Button button_intro;
    }
}