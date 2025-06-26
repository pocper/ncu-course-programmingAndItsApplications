namespace Ex3_FileSystem
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxFileInfo = new System.Windows.Forms.TextBox();
            this.buttonDirInfo = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonCurDir = new System.Windows.Forms.Button();
            this.textBoxCurDir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "File Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxFileInfo
            // 
            this.textBoxFileInfo.Location = new System.Drawing.Point(127, 24);
            this.textBoxFileInfo.Multiline = true;
            this.textBoxFileInfo.Name = "textBoxFileInfo";
            this.textBoxFileInfo.Size = new System.Drawing.Size(362, 66);
            this.textBoxFileInfo.TabIndex = 1;
            // 
            // buttonDirInfo
            // 
            this.buttonDirInfo.Location = new System.Drawing.Point(29, 177);
            this.buttonDirInfo.Name = "buttonDirInfo";
            this.buttonDirInfo.Size = new System.Drawing.Size(75, 50);
            this.buttonDirInfo.TabIndex = 0;
            this.buttonDirInfo.Text = "Directory Info";
            this.buttonDirInfo.UseVisualStyleBackColor = true;
            this.buttonDirInfo.Click += new System.EventHandler(this.buttonDirInfo_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 177);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(362, 142);
            this.textBox2.TabIndex = 1;
            // 
            // buttonCurDir
            // 
            this.buttonCurDir.Location = new System.Drawing.Point(29, 335);
            this.buttonCurDir.Name = "buttonCurDir";
            this.buttonCurDir.Size = new System.Drawing.Size(75, 50);
            this.buttonCurDir.TabIndex = 0;
            this.buttonCurDir.Text = "目前工作目錄";
            this.buttonCurDir.UseVisualStyleBackColor = true;
            this.buttonCurDir.Click += new System.EventHandler(this.buttonCurDir_Click);
            // 
            // textBoxCurDir
            // 
            this.textBoxCurDir.Location = new System.Drawing.Point(127, 335);
            this.textBoxCurDir.Multiline = true;
            this.textBoxCurDir.Name = "textBoxCurDir";
            this.textBoxCurDir.Size = new System.Drawing.Size(362, 50);
            this.textBoxCurDir.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.textBoxCurDir);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxFileInfo);
            this.Controls.Add(this.buttonCurDir);
            this.Controls.Add(this.buttonDirInfo);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxFileInfo;
        private System.Windows.Forms.Button buttonDirInfo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonCurDir;
        private System.Windows.Forms.TextBox textBoxCurDir;
    }
}

