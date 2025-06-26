namespace Ex03_RegExp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonFind = new System.Windows.Forms.Button();
            this.listBox_Result = new System.Windows.Forms.ListBox();
            this.textBox_Pattern = new System.Windows.Forms.TextBox();
            this.richTextBox_Content = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(33, 87);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(211, 45);
            this.buttonFind.TabIndex = 0;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // listBox_Result
            // 
            this.listBox_Result.FormattingEnabled = true;
            this.listBox_Result.ItemHeight = 12;
            this.listBox_Result.Location = new System.Drawing.Point(33, 178);
            this.listBox_Result.Name = "listBox_Result";
            this.listBox_Result.Size = new System.Drawing.Size(211, 244);
            this.listBox_Result.TabIndex = 2;
            // 
            // textBox_Pattern
            // 
            this.textBox_Pattern.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_Pattern.Location = new System.Drawing.Point(113, 28);
            this.textBox_Pattern.Name = "textBox_Pattern";
            this.textBox_Pattern.Size = new System.Drawing.Size(624, 33);
            this.textBox_Pattern.TabIndex = 3;
            this.textBox_Pattern.Text = "[0-9]{2}";
            // 
            // richTextBox_Content
            // 
            this.richTextBox_Content.Location = new System.Drawing.Point(291, 87);
            this.richTextBox_Content.Name = "richTextBox_Content";
            this.richTextBox_Content.Size = new System.Drawing.Size(446, 335);
            this.richTextBox_Content.TabIndex = 4;
            this.richTextBox_Content.Text = resources.GetString("richTextBox_Content.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pattern";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(33, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Match Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_Content);
            this.Controls.Add(this.textBox_Pattern);
            this.Controls.Add(this.listBox_Result);
            this.Controls.Add(this.buttonFind);
            this.Name = "Form1";
            this.Text = "Source:https://edition.cnn.com/world/live-news/coronavirus-outbreak-03-24-20-intl" +
    "-hnk/index.html";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.ListBox listBox_Result;
        private System.Windows.Forms.TextBox textBox_Pattern;
        private System.Windows.Forms.RichTextBox richTextBox_Content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

