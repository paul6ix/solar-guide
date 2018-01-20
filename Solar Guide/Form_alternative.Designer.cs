namespace Solar_Guide
{
    partial class Form_alternative
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_alternative));
            this.button_dashboard = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_elect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_dashboard
            // 
            this.button_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(10)))), ((int)(((byte)(89)))));
            this.button_dashboard.FlatAppearance.BorderSize = 0;
            this.button_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dashboard.Font = new System.Drawing.Font("Helvetica World", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.button_back.Font = new System.Drawing.Font("Helvetica World", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Helvetica World", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Solar_Guide.Properties.Resources.button_bar;
            this.button1.Location = new System.Drawing.Point(22, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(600, 60);
            this.button1.TabIndex = 25;
            this.button1.Text = "SOLAR FUELS";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button_elect
            // 
            this.button_elect.BackColor = System.Drawing.Color.Transparent;
            this.button_elect.FlatAppearance.BorderSize = 0;
            this.button_elect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.button_elect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_elect.Font = new System.Drawing.Font("Helvetica World", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_elect.ForeColor = System.Drawing.Color.White;
            this.button_elect.Image = global::Solar_Guide.Properties.Resources.button_bar;
            this.button_elect.Location = new System.Drawing.Point(22, 37);
            this.button_elect.Name = "button_elect";
            this.button_elect.Size = new System.Drawing.Size(600, 60);
            this.button_elect.TabIndex = 24;
            this.button_elect.Text = "SOLAR THERMAL ENERGY";
            this.button_elect.UseVisualStyleBackColor = false;
            // 
            // Form_alternative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Solar_Guide.Properties.Resources.Solar_dark_energy_blur;
            this.ClientSize = new System.Drawing.Size(634, 661);
            this.Controls.Add(this.button_dashboard);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_elect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_alternative";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALTERNATIVES TO SOLAR ENERGY";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_dashboard;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_elect;
    }
}