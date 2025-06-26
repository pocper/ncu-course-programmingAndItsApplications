
namespace HW
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_selectDir = new System.Windows.Forms.Button();
            this.textBox_SelectedDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_FileNum = new System.Windows.Forms.TextBox();
            this.textBox_FolderNum = new System.Windows.Forms.TextBox();
            this.textBox_FileSize = new System.Windows.Forms.TextBox();
            this.FileSize = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button_selectDir
            // 
            this.button_selectDir.Location = new System.Drawing.Point(39, 85);
            this.button_selectDir.Name = "button_selectDir";
            this.button_selectDir.Size = new System.Drawing.Size(183, 96);
            this.button_selectDir.TabIndex = 0;
            this.button_selectDir.Text = "選擇";
            this.button_selectDir.UseVisualStyleBackColor = true;
            this.button_selectDir.Click += new System.EventHandler(this.button_selectDir_Click);
            // 
            // textBox_SelectedDir
            // 
            this.textBox_SelectedDir.Location = new System.Drawing.Point(275, 85);
            this.textBox_SelectedDir.Multiline = true;
            this.textBox_SelectedDir.Name = "textBox_SelectedDir";
            this.textBox_SelectedDir.Size = new System.Drawing.Size(573, 96);
            this.textBox_SelectedDir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "資料夾數量";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "檔案數量";
            // 
            // textBox_FileNum
            // 
            this.textBox_FileNum.Location = new System.Drawing.Point(592, 240);
            this.textBox_FileNum.Name = "textBox_FileNum";
            this.textBox_FileNum.Size = new System.Drawing.Size(100, 43);
            this.textBox_FileNum.TabIndex = 4;
            // 
            // textBox_FolderNum
            // 
            this.textBox_FolderNum.Location = new System.Drawing.Point(592, 313);
            this.textBox_FolderNum.Name = "textBox_FolderNum";
            this.textBox_FolderNum.Size = new System.Drawing.Size(100, 43);
            this.textBox_FolderNum.TabIndex = 5;
            // 
            // textBox_FileSize
            // 
            this.textBox_FileSize.Location = new System.Drawing.Point(592, 378);
            this.textBox_FileSize.Name = "textBox_FileSize";
            this.textBox_FileSize.Size = new System.Drawing.Size(100, 43);
            this.textBox_FileSize.TabIndex = 6;
            // 
            // FileSize
            // 
            this.FileSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileSize.AutoSize = true;
            this.FileSize.Location = new System.Drawing.Point(349, 384);
            this.FileSize.Name = "FileSize";
            this.FileSize.Size = new System.Drawing.Size(163, 30);
            this.FileSize.TabIndex = 7;
            this.FileSize.Text = "總檔案大小";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(718, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "個";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(718, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "個";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(718, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "KB";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 488);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FileSize);
            this.Controls.Add(this.textBox_FileSize);
            this.Controls.Add(this.textBox_FolderNum);
            this.Controls.Add(this.textBox_FileNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_SelectedDir);
            this.Controls.Add(this.button_selectDir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_selectDir;
        private System.Windows.Forms.TextBox textBox_SelectedDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_FileNum;
        private System.Windows.Forms.TextBox textBox_FolderNum;
        private System.Windows.Forms.TextBox textBox_FileSize;
        private System.Windows.Forms.Label FileSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
    }
}

