
namespace Program_2
{
    partial class Program_2_WinForm
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
            this.maskedTextBox_set = new System.Windows.Forms.MaskedTextBox();
            this.button_setPassword = new System.Windows.Forms.Button();
            this.textBox_show = new System.Windows.Forms.TextBox();
            this.button_show = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // maskedTextBox_set
            // 
            this.maskedTextBox_set.Location = new System.Drawing.Point(191, 143);
            this.maskedTextBox_set.Name = "maskedTextBox_set";
            this.maskedTextBox_set.PasswordChar = '*';
            this.maskedTextBox_set.Size = new System.Drawing.Size(426, 43);
            this.maskedTextBox_set.TabIndex = 0;
            // 
            // button_setPassword
            // 
            this.button_setPassword.Location = new System.Drawing.Point(718, 120);
            this.button_setPassword.Name = "button_setPassword";
            this.button_setPassword.Size = new System.Drawing.Size(200, 83);
            this.button_setPassword.TabIndex = 1;
            this.button_setPassword.Text = "Set Password";
            this.button_setPassword.UseVisualStyleBackColor = true;
            this.button_setPassword.Click += new System.EventHandler(this.button_setPassword_Click);
            // 
            // textBox_show
            // 
            this.textBox_show.Location = new System.Drawing.Point(191, 310);
            this.textBox_show.Name = "textBox_show";
            this.textBox_show.Size = new System.Drawing.Size(426, 43);
            this.textBox_show.TabIndex = 2;
            // 
            // button_show
            // 
            this.button_show.Location = new System.Drawing.Point(971, 120);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(202, 83);
            this.button_show.TabIndex = 3;
            this.button_show.Text = "Show Password";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_show_MouseDown);
            this.button_show.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_show_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Program_2_WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 486);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.textBox_show);
            this.Controls.Add(this.button_setPassword);
            this.Controls.Add(this.maskedTextBox_set);
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "Program_2_WinForm";
            this.Text = "Program_2_WinForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox_set;
        private System.Windows.Forms.Button button_setPassword;
        private System.Windows.Forms.TextBox textBox_show;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.Timer timer1;
    }
}

