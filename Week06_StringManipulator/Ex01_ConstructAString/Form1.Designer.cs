namespace Ex01_ConstructAString
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Double = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Int32 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_String = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Date = new System.Windows.Forms.TextBox();
            this.cb_Enum = new System.Windows.Forms.ComboBox();
            this.btn_ConvertSimple = new System.Windows.Forms.Button();
            this.bn_ConvertUsingFormat = new System.Windows.Forms.Button();
            this.btn_StringBuilder = new System.Windows.Forms.Button();
            this.tb_SimpleResult = new System.Windows.Forms.TextBox();
            this.tb_FormatResult = new System.Windows.Forms.TextBox();
            this.tb_SBResult = new System.Windows.Forms.TextBox();
            this.timerUpdateDateTimeString = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbMonth = new System.Windows.Forms.TextBox();
            this.tbDay = new System.Windows.Forms.TextBox();
            this.tbHour = new System.Windows.Forms.TextBox();
            this.tbMinute = new System.Windows.Forms.TextBox();
            this.tbSecond = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Double";
            // 
            // tb_Double
            // 
            this.tb_Double.Location = new System.Drawing.Point(90, 47);
            this.tb_Double.Name = "tb_Double";
            this.tb_Double.Size = new System.Drawing.Size(100, 22);
            this.tb_Double.TabIndex = 1;
            this.tb_Double.Text = "3.14159";
            this.tb_Double.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Int32";
            // 
            // tb_Int32
            // 
            this.tb_Int32.Location = new System.Drawing.Point(90, 19);
            this.tb_Int32.Name = "tb_Int32";
            this.tb_Int32.Size = new System.Drawing.Size(100, 22);
            this.tb_Int32.TabIndex = 1;
            this.tb_Int32.Text = "3099";
            this.tb_Int32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "String";
            // 
            // tb_String
            // 
            this.tb_String.Location = new System.Drawing.Point(90, 108);
            this.tb_String.Name = "tb_String";
            this.tb_String.Size = new System.Drawing.Size(100, 22);
            this.tb_String.TabIndex = 1;
            this.tb_String.Text = "Chinte";
            this.tb_String.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "DateTime";
            // 
            // tb_Date
            // 
            this.tb_Date.Location = new System.Drawing.Point(90, 291);
            this.tb_Date.Name = "tb_Date";
            this.tb_Date.Size = new System.Drawing.Size(567, 22);
            this.tb_Date.TabIndex = 1;
            this.tb_Date.Text = "2020/03/24";
            this.tb_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_Enum
            // 
            this.cb_Enum.FormattingEnabled = true;
            this.cb_Enum.Location = new System.Drawing.Point(90, 80);
            this.cb_Enum.Name = "cb_Enum";
            this.cb_Enum.Size = new System.Drawing.Size(100, 20);
            this.cb_Enum.TabIndex = 2;
            // 
            // btn_ConvertSimple
            // 
            this.btn_ConvertSimple.Location = new System.Drawing.Point(241, 22);
            this.btn_ConvertSimple.Name = "btn_ConvertSimple";
            this.btn_ConvertSimple.Size = new System.Drawing.Size(112, 53);
            this.btn_ConvertSimple.TabIndex = 3;
            this.btn_ConvertSimple.Text = "Simple Convert";
            this.btn_ConvertSimple.UseVisualStyleBackColor = true;
            // 
            // bn_ConvertUsingFormat
            // 
            this.bn_ConvertUsingFormat.Location = new System.Drawing.Point(241, 111);
            this.bn_ConvertUsingFormat.Name = "bn_ConvertUsingFormat";
            this.bn_ConvertUsingFormat.Size = new System.Drawing.Size(112, 53);
            this.bn_ConvertUsingFormat.TabIndex = 3;
            this.bn_ConvertUsingFormat.Text = "Format Convert";
            this.bn_ConvertUsingFormat.UseVisualStyleBackColor = true;
            // 
            // btn_StringBuilder
            // 
            this.btn_StringBuilder.Location = new System.Drawing.Point(241, 207);
            this.btn_StringBuilder.Name = "btn_StringBuilder";
            this.btn_StringBuilder.Size = new System.Drawing.Size(112, 53);
            this.btn_StringBuilder.TabIndex = 3;
            this.btn_StringBuilder.Text = "String Builder";
            this.btn_StringBuilder.UseVisualStyleBackColor = true;
            // 
            // tb_SimpleResult
            // 
            this.tb_SimpleResult.Location = new System.Drawing.Point(359, 22);
            this.tb_SimpleResult.Multiline = true;
            this.tb_SimpleResult.Name = "tb_SimpleResult";
            this.tb_SimpleResult.Size = new System.Drawing.Size(298, 53);
            this.tb_SimpleResult.TabIndex = 4;
            // 
            // tb_FormatResult
            // 
            this.tb_FormatResult.Location = new System.Drawing.Point(359, 111);
            this.tb_FormatResult.Multiline = true;
            this.tb_FormatResult.Name = "tb_FormatResult";
            this.tb_FormatResult.Size = new System.Drawing.Size(298, 53);
            this.tb_FormatResult.TabIndex = 4;
            // 
            // tb_SBResult
            // 
            this.tb_SBResult.Location = new System.Drawing.Point(359, 207);
            this.tb_SBResult.Multiline = true;
            this.tb_SBResult.Name = "tb_SBResult";
            this.tb_SBResult.Size = new System.Drawing.Size(298, 53);
            this.tb_SBResult.TabIndex = 4;
            // 
            // timerUpdateDateTimeString
            // 
            this.timerUpdateDateTimeString.Interval = 200;
            this.timerUpdateDateTimeString.Tick += new System.EventHandler(this.timerUpdateDateTimeString_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 103);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Info";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "Height";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(78, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "Alex";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "178";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "109303999";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(90, 334);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(63, 22);
            this.tbYear.TabIndex = 6;
            // 
            // tbMonth
            // 
            this.tbMonth.Location = new System.Drawing.Point(159, 334);
            this.tbMonth.Name = "tbMonth";
            this.tbMonth.Size = new System.Drawing.Size(63, 22);
            this.tbMonth.TabIndex = 6;
            // 
            // tbDay
            // 
            this.tbDay.Location = new System.Drawing.Point(228, 334);
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(63, 22);
            this.tbDay.TabIndex = 6;
            // 
            // tbHour
            // 
            this.tbHour.Location = new System.Drawing.Point(328, 334);
            this.tbHour.Name = "tbHour";
            this.tbHour.Size = new System.Drawing.Size(63, 22);
            this.tbHour.TabIndex = 6;
            // 
            // tbMinute
            // 
            this.tbMinute.Location = new System.Drawing.Point(397, 334);
            this.tbMinute.Name = "tbMinute";
            this.tbMinute.Size = new System.Drawing.Size(63, 22);
            this.tbMinute.TabIndex = 6;
            // 
            // tbSecond
            // 
            this.tbSecond.Location = new System.Drawing.Point(466, 334);
            this.tbSecond.Name = "tbSecond";
            this.tbSecond.Size = new System.Drawing.Size(63, 22);
            this.tbSecond.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(104, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "Y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(179, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "M";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(239, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "D";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(344, 359);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "H";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(412, 359);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "Min";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(483, 359);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "Sec";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 389);
            this.Controls.Add(this.tbSecond);
            this.Controls.Add(this.tbDay);
            this.Controls.Add(this.tbMinute);
            this.Controls.Add(this.tbMonth);
            this.Controls.Add(this.tbHour);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_SBResult);
            this.Controls.Add(this.tb_FormatResult);
            this.Controls.Add(this.tb_SimpleResult);
            this.Controls.Add(this.btn_StringBuilder);
            this.Controls.Add(this.bn_ConvertUsingFormat);
            this.Controls.Add(this.btn_ConvertSimple);
            this.Controls.Add(this.cb_Enum);
            this.Controls.Add(this.tb_Date);
            this.Controls.Add(this.tb_String);
            this.Controls.Add(this.tb_Int32);
            this.Controls.Add(this.tb_Double);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Double;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Int32;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_String;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Date;
        private System.Windows.Forms.ComboBox cb_Enum;
        private System.Windows.Forms.Button btn_ConvertSimple;
        private System.Windows.Forms.Button bn_ConvertUsingFormat;
        private System.Windows.Forms.Button btn_StringBuilder;
        private System.Windows.Forms.TextBox tb_SimpleResult;
        private System.Windows.Forms.TextBox tb_FormatResult;
        private System.Windows.Forms.TextBox tb_SBResult;
        private System.Windows.Forms.Timer timerUpdateDateTimeString;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbMonth;
        private System.Windows.Forms.TextBox tbDay;
        private System.Windows.Forms.TextBox tbHour;
        private System.Windows.Forms.TextBox tbMinute;
        private System.Windows.Forms.TextBox tbSecond;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

