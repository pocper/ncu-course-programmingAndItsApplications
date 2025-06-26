namespace EX01_lock
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
            this.listBoxSource = new System.Windows.Forms.ListBox();
            this.listBoxCopied = new System.Windows.Forms.ListBox();
            this.buttonNoLock = new System.Windows.Forms.Button();
            this.buttonUseLock = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listBoxSource
            // 
            this.listBoxSource.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBoxSource.FormattingEnabled = true;
            this.listBoxSource.ItemHeight = 24;
            this.listBoxSource.Location = new System.Drawing.Point(31, 33);
            this.listBoxSource.Name = "listBoxSource";
            this.listBoxSource.Size = new System.Drawing.Size(120, 244);
            this.listBoxSource.TabIndex = 0;
            // 
            // listBoxCopied
            // 
            this.listBoxCopied.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBoxCopied.FormattingEnabled = true;
            this.listBoxCopied.ItemHeight = 24;
            this.listBoxCopied.Location = new System.Drawing.Point(172, 33);
            this.listBoxCopied.Name = "listBoxCopied";
            this.listBoxCopied.Size = new System.Drawing.Size(120, 244);
            this.listBoxCopied.TabIndex = 0;
            // 
            // buttonNoLock
            // 
            this.buttonNoLock.Location = new System.Drawing.Point(314, 33);
            this.buttonNoLock.Name = "buttonNoLock";
            this.buttonNoLock.Size = new System.Drawing.Size(177, 82);
            this.buttonNoLock.TabIndex = 1;
            this.buttonNoLock.Text = "Start without lock";
            this.buttonNoLock.UseVisualStyleBackColor = true;
            this.buttonNoLock.Click += new System.EventHandler(this.buttonNoLock_Click);
            // 
            // buttonUseLock
            // 
            this.buttonUseLock.Location = new System.Drawing.Point(314, 140);
            this.buttonUseLock.Name = "buttonUseLock";
            this.buttonUseLock.Size = new System.Drawing.Size(177, 82);
            this.buttonUseLock.TabIndex = 1;
            this.buttonUseLock.Text = "Start with lock";
            this.buttonUseLock.UseVisualStyleBackColor = true;
            this.buttonUseLock.Click += new System.EventHandler(this.buttonUseLock_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 331);
            this.Controls.Add(this.buttonUseLock);
            this.Controls.Add(this.buttonNoLock);
            this.Controls.Add(this.listBoxCopied);
            this.Controls.Add(this.listBoxSource);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSource;
        private System.Windows.Forms.ListBox listBoxCopied;
        private System.Windows.Forms.Button buttonNoLock;
        private System.Windows.Forms.Button buttonUseLock;
        private System.Windows.Forms.Timer timer1;
    }
}

