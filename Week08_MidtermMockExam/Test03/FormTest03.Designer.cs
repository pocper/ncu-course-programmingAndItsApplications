namespace Test03
{
    partial class FormTest03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTest03));
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.textBox_output1 = new System.Windows.Forms.TextBox();
            this.textBox_output2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Findwords = new System.Windows.Forms.Button();
            this.button_SumUpYears = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.AcceptsReturn = true;
            this.textBox_input.Location = new System.Drawing.Point(32, 90);
            this.textBox_input.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBox_input.Multiline = true;
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(1031, 814);
            this.textBox_input.TabIndex = 0;
            this.textBox_input.Text = resources.GetString("textBox_input.Text");
            // 
            // textBox_output1
            // 
            this.textBox_output1.Location = new System.Drawing.Point(1333, 90);
            this.textBox_output1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBox_output1.Multiline = true;
            this.textBox_output1.Name = "textBox_output1";
            this.textBox_output1.Size = new System.Drawing.Size(729, 442);
            this.textBox_output1.TabIndex = 1;
            // 
            // textBox_output2
            // 
            this.textBox_output2.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_output2.Location = new System.Drawing.Point(1333, 678);
            this.textBox_output2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBox_output2.Name = "textBox_output2";
            this.textBox_output2.Size = new System.Drawing.Size(729, 199);
            this.textBox_output2.TabIndex = 1;
            this.textBox_output2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "This is textbox_input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1328, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(626, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "This is textbox_output1. Please display all -ed words.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1328, 545);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(575, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "This is textbox_output2. Please sum up all years.";
            // 
            // button_Findwords
            // 
            this.button_Findwords.Location = new System.Drawing.Point(1117, 200);
            this.button_Findwords.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.button_Findwords.Name = "button_Findwords";
            this.button_Findwords.Size = new System.Drawing.Size(200, 190);
            this.button_Findwords.TabIndex = 3;
            this.button_Findwords.Text = "-->";
            this.button_Findwords.UseVisualStyleBackColor = true;
            this.button_Findwords.Click += new System.EventHandler(this.button_Findwords_Click);
            // 
            // button_SumUpYears
            // 
            this.button_SumUpYears.Location = new System.Drawing.Point(1117, 755);
            this.button_SumUpYears.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.button_SumUpYears.Name = "button_SumUpYears";
            this.button_SumUpYears.Size = new System.Drawing.Size(200, 98);
            this.button_SumUpYears.TabIndex = 3;
            this.button_SumUpYears.Text = "-->";
            this.button_SumUpYears.UseVisualStyleBackColor = true;
            this.button_SumUpYears.Click += new System.EventHandler(this.button_SumUpYears_Click);
            // 
            // FormTest03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 918);
            this.Controls.Add(this.button_SumUpYears);
            this.Controls.Add(this.button_Findwords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_output2);
            this.Controls.Add(this.textBox_output1);
            this.Controls.Add(this.textBox_input);
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "FormTest03";
            this.Text = "Finding your words";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.TextBox textBox_output1;
        private System.Windows.Forms.TextBox textBox_output2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Findwords;
        private System.Windows.Forms.Button button_SumUpYears;
    }
}

