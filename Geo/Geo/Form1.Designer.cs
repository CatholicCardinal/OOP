
namespace Geo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picture = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.White;
            this.picture.Location = new System.Drawing.Point(76, 89);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(1391, 546);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(14, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Прямая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button2.Location = new System.Drawing.Point(114, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Круг";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1469, 89);
            this.panel1.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(460, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 29);
            this.button6.TabIndex = 14;
            this.button6.Text = "Многоульники";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox4.Location = new System.Drawing.Point(918, 51);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(428, 24);
            this.checkBox4.TabIndex = 13;
            this.checkBox4.Text = "n-углов(обязательно для правильных многоугольников)\r\n";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(787, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(787, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(219, 28);
            this.button5.TabIndex = 11;
            this.button5.Text = "Правильный многоугольник\r\n\r\n";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox3.Location = new System.Drawing.Point(630, 52);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(112, 24);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "Цвет линии\r\n";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Click += new System.EventHandler(this.comboBox2_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(478, 48);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(146, 28);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.TextChanged += new System.EventHandler(this.comboBox2_TextChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox2.Location = new System.Drawing.Point(378, 50);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(94, 24);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Толщина\r\n";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(247, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "5";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(144, 52);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 24);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Заливка\r\n";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 28);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(346, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 29);
            this.button4.TabIndex = 4;
            this.button4.Text = "Ломаная";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button3.Location = new System.Drawing.Point(211, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "Прямоугольник";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(-2, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(78, 551);
            this.panel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 635);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picture);
            this.Name = "Form1";
            this.Text = "FanPaint";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button6;
    }
}

