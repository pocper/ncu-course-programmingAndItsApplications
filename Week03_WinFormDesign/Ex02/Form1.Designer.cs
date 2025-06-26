namespace Ex02
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
            this.button_ShowDate = new System.Windows.Forms.Button();
            this.button_ShowTime = new System.Windows.Forms.Button();
            this.textBox_ShowMsg = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button_ShowDate
            // 
            this.button_ShowDate.Location = new System.Drawing.Point(28, 38);
            this.button_ShowDate.Name = "button_ShowDate";
            this.button_ShowDate.Size = new System.Drawing.Size(166, 47);
            this.button_ShowDate.TabIndex = 0;
            this.button_ShowDate.Text = "Date";
            this.button_ShowDate.UseVisualStyleBackColor = true;
            this.button_ShowDate.Click += new System.EventHandler(this.button_ShowDate_Click);
            // 
            // button_ShowTime
            // 
            this.button_ShowTime.Location = new System.Drawing.Point(28, 100);
            this.button_ShowTime.Name = "button_ShowTime";
            this.button_ShowTime.Size = new System.Drawing.Size(166, 42);
            this.button_ShowTime.TabIndex = 1;
            this.button_ShowTime.Text = "Time";
            this.button_ShowTime.UseVisualStyleBackColor = true;
            this.button_ShowTime.Click += new System.EventHandler(this.button_ShowTime_Click);
            // 
            // textBox_ShowMsg
            // 
            this.textBox_ShowMsg.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_ShowMsg.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_ShowMsg.ForeColor = System.Drawing.Color.Blue;
            this.textBox_ShowMsg.Location = new System.Drawing.Point(28, 191);
            this.textBox_ShowMsg.Name = "textBox_ShowMsg";
            this.textBox_ShowMsg.Size = new System.Drawing.Size(251, 39);
            this.textBox_ShowMsg.TabIndex = 2;
            this.textBox_ShowMsg.Text = "--";
            this.textBox_ShowMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(333, 450);
            this.Controls.Add(this.textBox_ShowMsg);
            this.Controls.Add(this.button_ShowTime);
            this.Controls.Add(this.button_ShowDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ShowDate;
        private System.Windows.Forms.Button button_ShowTime;
        private System.Windows.Forms.TextBox textBox_ShowMsg;
        private System.Windows.Forms.Timer timer1;
    }
}

