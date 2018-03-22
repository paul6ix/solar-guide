namespace Solar_Guide
{
    partial class Form_quiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_quiz));
            this.button_intro = new System.Windows.Forms.Button();
            this.textBox_quiz2 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_quiz1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
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
            this.button_intro.Location = new System.Drawing.Point(12, 23);
            this.button_intro.Name = "button_intro";
            this.button_intro.Size = new System.Drawing.Size(600, 60);
            this.button_intro.TabIndex = 1;
            this.button_intro.Text = "1. Solar cells are made of";
            this.button_intro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_intro.UseVisualStyleBackColor = false;
            // 
            // textBox_quiz2
            // 
            this.textBox_quiz2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_quiz2.Location = new System.Drawing.Point(43, 292);
            this.textBox_quiz2.MaxLength = 1;
            this.textBox_quiz2.Name = "textBox_quiz2";
            this.textBox_quiz2.Size = new System.Drawing.Size(88, 20);
            this.textBox_quiz2.TabIndex = 12;
            this.textBox_quiz2.TextChanged += new System.EventHandler(this.textBox_quiz2_TextChanged);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(37)))), ((int)(((byte)(69)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(12, 175);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(600, 60);
            this.button9.TabIndex = 7;
            this.button9.Text = "2. The efficiency of solar cells is about";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.BackgroundImage = global::Solar_Guide.Properties.Resources.button_bar;
            this.radioButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(43, 101);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(122, 22);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "A. Aluminium";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Black;
            this.radioButton2.BackgroundImage = global::Solar_Guide.Properties.Resources.button_bar;
            this.radioButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(210, 101);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(133, 22);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "B. Germanium";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Black;
            this.radioButton3.BackgroundImage = global::Solar_Guide.Properties.Resources.button_bar;
            this.radioButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(363, 101);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(98, 22);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "C. Silicon";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.Color.Black;
            this.radioButton4.BackgroundImage = global::Solar_Guide.Properties.Resources.button_bar;
            this.radioButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.radioButton4.ForeColor = System.Drawing.Color.White;
            this.radioButton4.Location = new System.Drawing.Point(479, 101);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(123, 22);
            this.radioButton4.TabIndex = 16;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "D. Cadmium ";
            this.radioButton4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Please Input your Answer";
            // 
            // textBox_quiz1
            // 
            this.textBox_quiz1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_quiz1.Location = new System.Drawing.Point(43, 149);
            this.textBox_quiz1.MaxLength = 1;
            this.textBox_quiz1.Name = "textBox_quiz1";
            this.textBox_quiz1.Size = new System.Drawing.Size(88, 20);
            this.textBox_quiz1.TabIndex = 18;
            this.textBox_quiz1.TextChanged += new System.EventHandler(this.textBox_quiz1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Please Input your Answer";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.BackColor = System.Drawing.Color.Transparent;
            this.radioButton5.BackgroundImage = global::Solar_Guide.Properties.Resources.button_bar;
            this.radioButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.radioButton5.ForeColor = System.Drawing.Color.White;
            this.radioButton5.Location = new System.Drawing.Point(43, 241);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(77, 22);
            this.radioButton5.TabIndex = 20;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "A. 25%";
            this.radioButton5.UseVisualStyleBackColor = false;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.BackColor = System.Drawing.Color.Transparent;
            this.radioButton6.BackgroundImage = global::Solar_Guide.Properties.Resources.button_bar;
            this.radioButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.radioButton6.ForeColor = System.Drawing.Color.White;
            this.radioButton6.Location = new System.Drawing.Point(343, 241);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(79, 22);
            this.radioButton6.TabIndex = 21;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "C. 40%";
            this.radioButton6.UseVisualStyleBackColor = false;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.BackColor = System.Drawing.Color.Transparent;
            this.radioButton7.BackgroundImage = global::Solar_Guide.Properties.Resources.button_bar;
            this.radioButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.radioButton7.ForeColor = System.Drawing.Color.White;
            this.radioButton7.Location = new System.Drawing.Point(468, 241);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(79, 22);
            this.radioButton7.TabIndex = 22;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "D. 60%";
            this.radioButton7.UseVisualStyleBackColor = false;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.BackColor = System.Drawing.Color.Transparent;
            this.radioButton8.BackgroundImage = global::Solar_Guide.Properties.Resources.button_bar;
            this.radioButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.radioButton8.ForeColor = System.Drawing.Color.White;
            this.radioButton8.Location = new System.Drawing.Point(199, 241);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(78, 22);
            this.radioButton8.TabIndex = 23;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "B. 15%";
            this.radioButton8.UseVisualStyleBackColor = false;
            // 
            // Form_quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Solar_Guide.Properties.Resources.Solar_dark_energy_blur;
            this.ClientSize = new System.Drawing.Size(634, 661);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_quiz1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox_quiz2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button_intro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_quiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pratice Test";
            this.Load += new System.EventHandler(this.Form_quiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_intro;
        private System.Windows.Forms.TextBox textBox_quiz2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_quiz1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
    }
}