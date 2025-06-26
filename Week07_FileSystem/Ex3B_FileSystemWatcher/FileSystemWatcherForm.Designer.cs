namespace Ex3B_FileSystemWatcher
{
    partial class FileSystemWatcherForm
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
            this.button_SelectDir = new System.Windows.Forms.Button();
            this.textBox_Dir = new System.Windows.Forms.TextBox();
            this.checkBox_IsMonitoring = new System.Windows.Forms.CheckBox();
            this.listBox_Log = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button_SelectDir
            // 
            this.button_SelectDir.Location = new System.Drawing.Point(12, 15);
            this.button_SelectDir.Name = "button_SelectDir";
            this.button_SelectDir.Size = new System.Drawing.Size(75, 53);
            this.button_SelectDir.TabIndex = 0;
            this.button_SelectDir.Text = "Select";
            this.button_SelectDir.UseVisualStyleBackColor = true;
            this.button_SelectDir.Click += new System.EventHandler(this.button_SelectDir_Click);
            // 
            // textBox_Dir
            // 
            this.textBox_Dir.Location = new System.Drawing.Point(104, 15);
            this.textBox_Dir.Multiline = true;
            this.textBox_Dir.Name = "textBox_Dir";
            this.textBox_Dir.Size = new System.Drawing.Size(286, 53);
            this.textBox_Dir.TabIndex = 1;
            // 
            // checkBox_IsMonitoring
            // 
            this.checkBox_IsMonitoring.AutoSize = true;
            this.checkBox_IsMonitoring.Location = new System.Drawing.Point(13, 75);
            this.checkBox_IsMonitoring.Name = "checkBox_IsMonitoring";
            this.checkBox_IsMonitoring.Size = new System.Drawing.Size(226, 16);
            this.checkBox_IsMonitoring.TabIndex = 2;
            this.checkBox_IsMonitoring.Text = "Enable Monitoring of the selected directory";
            this.checkBox_IsMonitoring.UseVisualStyleBackColor = true;
            this.checkBox_IsMonitoring.CheckedChanged += new System.EventHandler(this.checkBox_IsMonitoring_CheckedChanged);
            // 
            // listBox_Log
            // 
            this.listBox_Log.FormattingEnabled = true;
            this.listBox_Log.ItemHeight = 12;
            this.listBox_Log.Location = new System.Drawing.Point(13, 114);
            this.listBox_Log.Name = "listBox_Log";
            this.listBox_Log.Size = new System.Drawing.Size(377, 196);
            this.listBox_Log.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FileSystemWatcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 323);
            this.Controls.Add(this.listBox_Log);
            this.Controls.Add(this.checkBox_IsMonitoring);
            this.Controls.Add(this.textBox_Dir);
            this.Controls.Add(this.button_SelectDir);
            this.Name = "FileSystemWatcherForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_SelectDir;
        private System.Windows.Forms.TextBox textBox_Dir;
        private System.Windows.Forms.CheckBox checkBox_IsMonitoring;
        private System.Windows.Forms.ListBox listBox_Log;
        private System.Windows.Forms.Timer timer1;
    }
}

