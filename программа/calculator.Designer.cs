﻿namespace программа
{
    partial class calculator
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
            this.usluga1comboBox = new System.Windows.Forms.ComboBox();
            this.usluga1label = new System.Windows.Forms.Label();
            this.usluga2comboBox = new System.Windows.Forms.ComboBox();
            this.usluga2label = new System.Windows.Forms.Label();
            this.usluga3comboBox = new System.Windows.Forms.ComboBox();
            this.usluga1StoimostLabel = new System.Windows.Forms.Label();
            this.usluga3label = new System.Windows.Forms.Label();
            this.usluga2StoimostLabel = new System.Windows.Forms.Label();
            this.usluga3StoimostLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.usluga1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.usluga2 = new System.Windows.Forms.CheckBox();
            this.usluga3 = new System.Windows.Forms.CheckBox();
            this.spravkaTextBox = new System.Windows.Forms.TextBox();
            this.ItogS = new System.Windows.Forms.Label();
            this.ItogB = new System.Windows.Forms.Button();
            this.usluga4 = new System.Windows.Forms.CheckBox();
            this.usluga4label = new System.Windows.Forms.Label();
            this.usluga4comboBox = new System.Windows.Forms.ComboBox();
            this.usluga4StoimostLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usluga1comboBox
            // 
            this.usluga1comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usluga1comboBox.FormattingEnabled = true;
            this.usluga1comboBox.Items.AddRange(new object[] {
            "До 1000М²",
            "До 10000М²",
            "Свыше 1га"});
            this.usluga1comboBox.Location = new System.Drawing.Point(411, 42);
            this.usluga1comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usluga1comboBox.Name = "usluga1comboBox";
            this.usluga1comboBox.Size = new System.Drawing.Size(140, 24);
            this.usluga1comboBox.TabIndex = 4;
            this.usluga1comboBox.SelectedIndexChanged += new System.EventHandler(this.button1_Click);
            // 
            // usluga1label
            // 
            this.usluga1label.AutoSize = true;
            this.usluga1label.Location = new System.Drawing.Point(62, 50);
            this.usluga1label.Name = "usluga1label";
            this.usluga1label.Size = new System.Drawing.Size(305, 17);
            this.usluga1label.TabIndex = 5;
            this.usluga1label.Text = "Горизонтальная съемка земельного участка";
            this.usluga1label.Click += new System.EventHandler(this.label1_Click);
            // 
            // usluga2comboBox
            // 
            this.usluga2comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usluga2comboBox.FormattingEnabled = true;
            this.usluga2comboBox.Items.AddRange(new object[] {
            "Образование з/у",
            "Уточнение гр-ц з/у",
            "Раздел з/у",
            "Объединение з/у"});
            this.usluga2comboBox.Location = new System.Drawing.Point(411, 102);
            this.usluga2comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usluga2comboBox.Name = "usluga2comboBox";
            this.usluga2comboBox.Size = new System.Drawing.Size(140, 24);
            this.usluga2comboBox.TabIndex = 6;
            this.usluga2comboBox.SelectedIndexChanged += new System.EventHandler(this.button2_Click);
            // 
            // usluga2label
            // 
            this.usluga2label.AutoSize = true;
            this.usluga2label.Location = new System.Drawing.Point(62, 105);
            this.usluga2label.Name = "usluga2label";
            this.usluga2label.Size = new System.Drawing.Size(194, 17);
            this.usluga2label.TabIndex = 7;
            this.usluga2label.Text = "Подготовка межевого плана";
            this.usluga2label.Click += new System.EventHandler(this.label2_Click);
            // 
            // usluga3comboBox
            // 
            this.usluga3comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usluga3comboBox.FormattingEnabled = true;
            this.usluga3comboBox.Items.AddRange(new object[] {
            "ИЖС",
            "Помещение",
            "Часть в здании/ддоме"});
            this.usluga3comboBox.Location = new System.Drawing.Point(411, 157);
            this.usluga3comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usluga3comboBox.Name = "usluga3comboBox";
            this.usluga3comboBox.Size = new System.Drawing.Size(140, 24);
            this.usluga3comboBox.TabIndex = 8;
            this.usluga3comboBox.SelectedIndexChanged += new System.EventHandler(this.button3_Click);
            // 
            // usluga1StoimostLabel
            // 
            this.usluga1StoimostLabel.AutoSize = true;
            this.usluga1StoimostLabel.Location = new System.Drawing.Point(616, 50);
            this.usluga1StoimostLabel.Name = "usluga1StoimostLabel";
            this.usluga1StoimostLabel.Size = new System.Drawing.Size(71, 17);
            this.usluga1StoimostLabel.TabIndex = 12;
            this.usluga1StoimostLabel.Text = " 0 рублей";
            // 
            // usluga3label
            // 
            this.usluga3label.AutoSize = true;
            this.usluga3label.Location = new System.Drawing.Point(62, 160);
            this.usluga3label.Name = "usluga3label";
            this.usluga3label.Size = new System.Drawing.Size(224, 17);
            this.usluga3label.TabIndex = 13;
            this.usluga3label.Text = "Подготовка технического плана ";
            this.usluga3label.Click += new System.EventHandler(this.label6_Click);
            // 
            // usluga2StoimostLabel
            // 
            this.usluga2StoimostLabel.AutoSize = true;
            this.usluga2StoimostLabel.Location = new System.Drawing.Point(616, 105);
            this.usluga2StoimostLabel.Name = "usluga2StoimostLabel";
            this.usluga2StoimostLabel.Size = new System.Drawing.Size(67, 17);
            this.usluga2StoimostLabel.TabIndex = 14;
            this.usluga2StoimostLabel.Text = "0 рублей";
            this.usluga2StoimostLabel.Click += new System.EventHandler(this.usluga2StoimostLabel_Click);
            // 
            // usluga3StoimostLabel
            // 
            this.usluga3StoimostLabel.AutoSize = true;
            this.usluga3StoimostLabel.Location = new System.Drawing.Point(616, 160);
            this.usluga3StoimostLabel.Name = "usluga3StoimostLabel";
            this.usluga3StoimostLabel.Size = new System.Drawing.Size(67, 17);
            this.usluga3StoimostLabel.TabIndex = 15;
            this.usluga3StoimostLabel.Text = "0 рублей";
            this.usluga3StoimostLabel.Click += new System.EventHandler(this.usluga3StoimostLabel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(623, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Подытог";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(814, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "тыкни";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usluga1
            // 
            this.usluga1.AutoSize = true;
            this.usluga1.Location = new System.Drawing.Point(38, 51);
            this.usluga1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usluga1.Name = "usluga1";
            this.usluga1.Size = new System.Drawing.Size(18, 17);
            this.usluga1.TabIndex = 18;
            this.usluga1.UseVisualStyleBackColor = true;
            this.usluga1.CheckedChanged += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "выбор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "вид работы";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(814, 102);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "тыкни";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(814, 157);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "тыкни";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // usluga2
            // 
            this.usluga2.AutoSize = true;
            this.usluga2.Location = new System.Drawing.Point(38, 110);
            this.usluga2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usluga2.Name = "usluga2";
            this.usluga2.Size = new System.Drawing.Size(18, 17);
            this.usluga2.TabIndex = 23;
            this.usluga2.UseVisualStyleBackColor = true;
            this.usluga2.CheckedChanged += new System.EventHandler(this.button2_Click);
            // 
            // usluga3
            // 
            this.usluga3.AutoSize = true;
            this.usluga3.Location = new System.Drawing.Point(38, 162);
            this.usluga3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usluga3.Name = "usluga3";
            this.usluga3.Size = new System.Drawing.Size(18, 17);
            this.usluga3.TabIndex = 24;
            this.usluga3.UseVisualStyleBackColor = true;
            this.usluga3.CheckedChanged += new System.EventHandler(this.button3_Click);
            // 
            // spravkaTextBox
            // 
            this.spravkaTextBox.Location = new System.Drawing.Point(12, 393);
            this.spravkaTextBox.Multiline = true;
            this.spravkaTextBox.Name = "spravkaTextBox";
            this.spravkaTextBox.ReadOnly = true;
            this.spravkaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.spravkaTextBox.Size = new System.Drawing.Size(856, 134);
            this.spravkaTextBox.TabIndex = 25;
            // 
            // ItogS
            // 
            this.ItogS.AutoSize = true;
            this.ItogS.Location = new System.Drawing.Point(811, 352);
            this.ItogS.Name = "ItogS";
            this.ItogS.Size = new System.Drawing.Size(67, 17);
            this.ItogS.TabIndex = 26;
            this.ItogS.Text = "0 рублей";
            this.ItogS.Click += new System.EventHandler(this.ItogS_Click);
            // 
            // ItogB
            // 
            this.ItogB.Location = new System.Drawing.Point(668, 349);
            this.ItogB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ItogB.Name = "ItogB";
            this.ItogB.Size = new System.Drawing.Size(75, 23);
            this.ItogB.TabIndex = 27;
            this.ItogB.Text = "тыкни";
            this.ItogB.UseVisualStyleBackColor = true;
            this.ItogB.Click += new System.EventHandler(this.ItogB_Click);
            // 
            // usluga4
            // 
            this.usluga4.AutoSize = true;
            this.usluga4.Location = new System.Drawing.Point(38, 214);
            this.usluga4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usluga4.Name = "usluga4";
            this.usluga4.Size = new System.Drawing.Size(18, 17);
            this.usluga4.TabIndex = 28;
            this.usluga4.UseVisualStyleBackColor = true;
            this.usluga4.CheckedChanged += new System.EventHandler(this.usluga4_CheckedChanged);
            // 
            // usluga4label
            // 
            this.usluga4label.AutoSize = true;
            this.usluga4label.Location = new System.Drawing.Point(62, 212);
            this.usluga4label.Name = "usluga4label";
            this.usluga4label.Size = new System.Drawing.Size(107, 17);
            this.usluga4label.TabIndex = 29;
            this.usluga4label.Text = "Строительство";
            this.usluga4label.Click += new System.EventHandler(this.usluga4label_Click);
            // 
            // usluga4comboBox
            // 
            this.usluga4comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usluga4comboBox.FormattingEnabled = true;
            this.usluga4comboBox.Items.AddRange(new object[] {
            "ИЖС",
            "Коммерческая недвижимость",
            "Инженерные коммуникации"});
            this.usluga4comboBox.Location = new System.Drawing.Point(411, 209);
            this.usluga4comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usluga4comboBox.Name = "usluga4comboBox";
            this.usluga4comboBox.Size = new System.Drawing.Size(140, 24);
            this.usluga4comboBox.TabIndex = 30;
            this.usluga4comboBox.SelectedIndexChanged += new System.EventHandler(this.button4_Click);
            // 
            // usluga4StoimostLabel
            // 
            this.usluga4StoimostLabel.AutoSize = true;
            this.usluga4StoimostLabel.Location = new System.Drawing.Point(613, 212);
            this.usluga4StoimostLabel.Name = "usluga4StoimostLabel";
            this.usluga4StoimostLabel.Size = new System.Drawing.Size(67, 17);
            this.usluga4StoimostLabel.TabIndex = 31;
            this.usluga4StoimostLabel.Text = "0 рублей";
            this.usluga4StoimostLabel.Click += new System.EventHandler(this.usluga4StoimostLabel_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(814, 210);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 32;
            this.button4.Text = "тыкни";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(51, 330);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 33;
            this.button5.Text = "korzina";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 539);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.usluga4StoimostLabel);
            this.Controls.Add(this.usluga4comboBox);
            this.Controls.Add(this.usluga4label);
            this.Controls.Add(this.usluga4);
            this.Controls.Add(this.ItogB);
            this.Controls.Add(this.ItogS);
            this.Controls.Add(this.spravkaTextBox);
            this.Controls.Add(this.usluga3);
            this.Controls.Add(this.usluga2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usluga1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.usluga3StoimostLabel);
            this.Controls.Add(this.usluga2StoimostLabel);
            this.Controls.Add(this.usluga3label);
            this.Controls.Add(this.usluga1StoimostLabel);
            this.Controls.Add(this.usluga3comboBox);
            this.Controls.Add(this.usluga2label);
            this.Controls.Add(this.usluga2comboBox);
            this.Controls.Add(this.usluga1label);
            this.Controls.Add(this.usluga1comboBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "calculator";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox usluga1comboBox;
        private System.Windows.Forms.Label usluga1label;
        private System.Windows.Forms.ComboBox usluga2comboBox;
        private System.Windows.Forms.Label usluga2label;
        private System.Windows.Forms.ComboBox usluga3comboBox;
        private System.Windows.Forms.Label usluga1StoimostLabel;
        private System.Windows.Forms.Label usluga3label;
        private System.Windows.Forms.Label usluga2StoimostLabel;
        private System.Windows.Forms.Label usluga3StoimostLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox usluga1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox usluga2;
        private System.Windows.Forms.CheckBox usluga3;
        private System.Windows.Forms.TextBox spravkaTextBox;
        private System.Windows.Forms.Label ItogS;
        private System.Windows.Forms.Button ItogB;
        private System.Windows.Forms.CheckBox usluga4;
        private System.Windows.Forms.Label usluga4label;
        private System.Windows.Forms.ComboBox usluga4comboBox;
        private System.Windows.Forms.Label usluga4StoimostLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}