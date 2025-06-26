namespace Ex0_FileDialog
{
    partial class FormEx2B
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
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBox_OpenFilePath = new System.Windows.Forms.TextBox();
            this.textBox_SaveFilePath = new System.Windows.Forms.TextBox();
            this.textBox_CopiedContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_CopyContent = new System.Windows.Forms.Button();
            this.textBox_ReadContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(12, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 328);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBox_OpenFilePath
            // 
            this.textBox_OpenFilePath.Location = new System.Drawing.Point(110, 12);
            this.textBox_OpenFilePath.Name = "textBox_OpenFilePath";
            this.textBox_OpenFilePath.Size = new System.Drawing.Size(465, 22);
            this.textBox_OpenFilePath.TabIndex = 2;
            // 
            // textBox_SaveFilePath
            // 
            this.textBox_SaveFilePath.Location = new System.Drawing.Point(110, 328);
            this.textBox_SaveFilePath.Name = "textBox_SaveFilePath";
            this.textBox_SaveFilePath.Size = new System.Drawing.Size(465, 22);
            this.textBox_SaveFilePath.TabIndex = 2;
            // 
            // textBox_CopiedContent
            // 
            this.textBox_CopiedContent.Location = new System.Drawing.Point(12, 192);
            this.textBox_CopiedContent.Multiline = true;
            this.textBox_CopiedContent.Name = "textBox_CopiedContent";
            this.textBox_CopiedContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_CopiedContent.Size = new System.Drawing.Size(563, 117);
            this.textBox_CopiedContent.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Content from Opened File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Copied Content";
            // 
            // button_CopyContent
            // 
            this.button_CopyContent.Location = new System.Drawing.Point(229, 166);
            this.button_CopyContent.Name = "button_CopyContent";
            this.button_CopyContent.Size = new System.Drawing.Size(75, 23);
            this.button_CopyContent.TabIndex = 6;
            this.button_CopyContent.Text = "Copy";
            this.button_CopyContent.UseVisualStyleBackColor = true;
            this.button_CopyContent.Click += new System.EventHandler(this.button_CopyContent_Click);
            // 
            // textBox_ReadContent
            // 
            this.textBox_ReadContent.Location = new System.Drawing.Point(14, 63);
            this.textBox_ReadContent.Multiline = true;
            this.textBox_ReadContent.Name = "textBox_ReadContent";
            this.textBox_ReadContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ReadContent.Size = new System.Drawing.Size(561, 97);
            this.textBox_ReadContent.TabIndex = 7;
            // 
            // FormEx2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 363);
            this.Controls.Add(this.textBox_ReadContent);
            this.Controls.Add(this.button_CopyContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_CopiedContent);
            this.Controls.Add(this.textBox_SaveFilePath);
            this.Controls.Add(this.textBox_OpenFilePath);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Name = "FormEx2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBox_OpenFilePath;
        private System.Windows.Forms.TextBox textBox_SaveFilePath;
        private System.Windows.Forms.TextBox textBox_CopiedContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_CopyContent;
        private System.Windows.Forms.TextBox textBox_ReadContent;
    }
}

