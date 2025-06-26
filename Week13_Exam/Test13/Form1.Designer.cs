
namespace Test13
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
            this.button_connect = new System.Windows.Forms.Button();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.listBox_msg = new System.Windows.Forms.ListBox();
            this.listBox_handle = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox_count = new System.Windows.Forms.TextBox();
            this.button_release = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(108, 133);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(207, 112);
            this.button_connect.TabIndex = 1;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // button_disconnect
            // 
            this.button_disconnect.Location = new System.Drawing.Point(108, 457);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(207, 112);
            this.button_disconnect.TabIndex = 2;
            this.button_disconnect.Text = "Disconnect";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // listBox_msg
            // 
            this.listBox_msg.FormattingEnabled = true;
            this.listBox_msg.ItemHeight = 30;
            this.listBox_msg.Location = new System.Drawing.Point(623, 126);
            this.listBox_msg.Name = "listBox_msg";
            this.listBox_msg.Size = new System.Drawing.Size(574, 454);
            this.listBox_msg.TabIndex = 6;
            // 
            // listBox_handle
            // 
            this.listBox_handle.FormattingEnabled = true;
            this.listBox_handle.ItemHeight = 30;
            this.listBox_handle.Location = new System.Drawing.Point(378, 321);
            this.listBox_handle.Name = "listBox_handle";
            this.listBox_handle.Size = new System.Drawing.Size(195, 184);
            this.listBox_handle.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox_count
            // 
            this.textBox_count.Location = new System.Drawing.Point(378, 221);
            this.textBox_count.Name = "textBox_count";
            this.textBox_count.Size = new System.Drawing.Size(195, 43);
            this.textBox_count.TabIndex = 8;
            // 
            // button_release
            // 
            this.button_release.Location = new System.Drawing.Point(108, 293);
            this.button_release.Name = "button_release";
            this.button_release.Size = new System.Drawing.Size(207, 107);
            this.button_release.TabIndex = 9;
            this.button_release.Text = "Release";
            this.button_release.UseVisualStyleBackColor = true;
            this.button_release.Click += new System.EventHandler(this.button_release_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 682);
            this.Controls.Add(this.button_release);
            this.Controls.Add(this.textBox_count);
            this.Controls.Add(this.listBox_handle);
            this.Controls.Add(this.listBox_msg);
            this.Controls.Add(this.button_disconnect);
            this.Controls.Add(this.button_connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.ListBox listBox_msg;
        private System.Windows.Forms.ListBox listBox_handle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox_count;
        private System.Windows.Forms.Button button_release;
    }
}

