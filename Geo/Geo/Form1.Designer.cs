﻿
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
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStripItem_Plugins = new System.Windows.Forms.ToolStripMenuItem();
            this.lblActivePlugin = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.White;
            this.picture.Location = new System.Drawing.Point(-2, 89);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(1039, 546);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(10, 34);
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
            this.button2.Location = new System.Drawing.Point(110, 34);
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
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
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
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1469, 89);
            this.panel1.TabIndex = 3;
            // 
            // button11
            // 
            this.button11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button11.Location = new System.Drawing.Point(398, 0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(135, 31);
            this.button11.TabIndex = 20;
            this.button11.Text = "Добавление плагина";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.menuStripPlugins_Add_Click);
            // 
            // button10
            // 
            this.button10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.Location = new System.Drawing.Point(964, 34);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(69, 27);
            this.button10.TabIndex = 18;
            this.button10.Text = "Загрузить";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.Location = new System.Drawing.Point(962, 61);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(71, 29);
            this.button9.TabIndex = 17;
            this.button9.Text = "Сохранить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Location = new System.Drawing.Point(663, 34);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 30);
            this.button8.TabIndex = 16;
            this.button8.Text = "вперед";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(590, 34);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(67, 29);
            this.button7.TabIndex = 15;
            this.button7.Text = "назад";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(456, 34);
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
            this.checkBox4.Location = new System.Drawing.Point(875, 63);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(83, 24);
            this.checkBox4.TabIndex = 13;
            this.checkBox4.Text = "n-углов";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(744, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(744, 35);
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
            this.checkBox3.Location = new System.Drawing.Point(626, 65);
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
            this.comboBox2.Location = new System.Drawing.Point(474, 61);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(146, 28);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.TextChanged += new System.EventHandler(this.comboBox2_TextChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox2.Location = new System.Drawing.Point(374, 63);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(94, 24);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Толщина\r\n";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(243, 61);
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
            this.checkBox1.Location = new System.Drawing.Point(140, 65);
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
            this.comboBox1.Location = new System.Drawing.Point(10, 61);
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
            this.button4.Location = new System.Drawing.Point(342, 34);
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
            this.button3.Location = new System.Drawing.Point(207, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "Прямоугольник";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripItem_Plugins,
            this.lblActivePlugin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1469, 31);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "Список плагинов";
            // 
            // menuStripItem_Plugins
            // 
            this.menuStripItem_Plugins.Name = "menuStripItem_Plugins";
            this.menuStripItem_Plugins.Size = new System.Drawing.Size(143, 27);
            this.menuStripItem_Plugins.Text = "Список плагинов";
            // 
            // lblActivePlugin
            // 
            this.lblActivePlugin.Name = "lblActivePlugin";
            this.lblActivePlugin.Size = new System.Drawing.Size(250, 27);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 635);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picture);
            this.Name = "Form1";
            this.Text = "FanPaint";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem menuStripItem_Plugins;
        private System.Windows.Forms.ToolStripTextBox lblActivePlugin;
        private System.Windows.Forms.Button button11;
    }
}

