
namespace MyEXE
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
            this.maskedTextBox_set = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox_input = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_checked = new System.Windows.Forms.Button();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // maskedTextBox_set
            // 
            this.maskedTextBox_set.Location = new System.Drawing.Point(174, 78);
            this.maskedTextBox_set.Name = "maskedTextBox_set";
            this.maskedTextBox_set.PasswordChar = '*';
            this.maskedTextBox_set.Size = new System.Drawing.Size(183, 43);
            this.maskedTextBox_set.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Set";
            // 
            // maskedTextBox_input
            // 
            this.maskedTextBox_input.Location = new System.Drawing.Point(174, 176);
            this.maskedTextBox_input.Name = "maskedTextBox_input";
            this.maskedTextBox_input.Size = new System.Drawing.Size(183, 43);
            this.maskedTextBox_input.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input";
            // 
            // button_checked
            // 
            this.button_checked.Location = new System.Drawing.Point(451, 150);
            this.button_checked.Name = "button_checked";
            this.button_checked.Size = new System.Drawing.Size(245, 88);
            this.button_checked.TabIndex = 5;
            this.button_checked.Text = "Checked";
            this.button_checked.UseVisualStyleBackColor = true;
            this.button_checked.Click += new System.EventHandler(this.button_checked_Click);
            // 
            // textBox_output
            // 
            this.textBox_output.Location = new System.Drawing.Point(451, 81);
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.Size = new System.Drawing.Size(245, 43);
            this.textBox_output.TabIndex = 4;
            this.textBox_output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 292);
            this.Controls.Add(this.button_checked);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox_set);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox_set;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_checked;
        private System.Windows.Forms.TextBox textBox_output;
    }
}

