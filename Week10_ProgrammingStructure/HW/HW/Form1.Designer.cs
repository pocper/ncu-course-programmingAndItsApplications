
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
            this.textBox_Width = new System.Windows.Forms.TextBox();
            this.textBox_Length = new System.Windows.Forms.TextBox();
            this.button_set = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBox_Width
            // 
            this.textBox_Width.Location = new System.Drawing.Point(383, 84);
            this.textBox_Width.Name = "textBox_Width";
            this.textBox_Width.Size = new System.Drawing.Size(254, 43);
            this.textBox_Width.TabIndex = 0;
            // 
            // textBox_Length
            // 
            this.textBox_Length.Location = new System.Drawing.Point(383, 184);
            this.textBox_Length.Name = "textBox_Length";
            this.textBox_Length.Size = new System.Drawing.Size(254, 43);
            this.textBox_Length.TabIndex = 1;
            // 
            // button_set
            // 
            this.button_set.Location = new System.Drawing.Point(83, 83);
            this.button_set.Name = "button_set";
            this.button_set.Size = new System.Drawing.Size(234, 144);
            this.button_set.TabIndex = 2;
            this.button_set.Text = "SET";
            this.button_set.UseVisualStyleBackColor = true;
            this.button_set.Click += new System.EventHandler(this.button_set_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "W";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "L";
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.ItemHeight = 30;
            this.listBoxLog.Location = new System.Drawing.Point(83, 282);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(554, 334);
            this.listBoxLog.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 688);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_set);
            this.Controls.Add(this.textBox_Length);
            this.Controls.Add(this.textBox_Width);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Width;
        private System.Windows.Forms.TextBox textBox_Length;
        private System.Windows.Forms.Button button_set;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.Timer timer1;
    }
}

