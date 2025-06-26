namespace _06WorkingThreadTemplate
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonRelease = new System.Windows.Forms.Button();
            this.tb_show = new System.Windows.Forms.TextBox();
            this.button_text = new System.Windows.Forms.Button();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonStart.Location = new System.Drawing.Point(59, 65);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(525, 135);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start a thread";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonPause.Location = new System.Drawing.Point(59, 265);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(525, 135);
            this.buttonPause.TabIndex = 0;
            this.buttonPause.Text = "Pause the thread";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonRelease
            // 
            this.buttonRelease.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonRelease.Location = new System.Drawing.Point(59, 460);
            this.buttonRelease.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonRelease.Name = "buttonRelease";
            this.buttonRelease.Size = new System.Drawing.Size(525, 135);
            this.buttonRelease.TabIndex = 0;
            this.buttonRelease.Text = "Release the thread";
            this.buttonRelease.UseVisualStyleBackColor = true;
            this.buttonRelease.Click += new System.EventHandler(this.buttonRelease_Click);
            // 
            // tb_show
            // 
            this.tb_show.Font = new System.Drawing.Font("新細明體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_show.Location = new System.Drawing.Point(704, 68);
            this.tb_show.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tb_show.Name = "tb_show";
            this.tb_show.Size = new System.Drawing.Size(596, 112);
            this.tb_show.TabIndex = 1;
            // 
            // button_text
            // 
            this.button_text.Location = new System.Drawing.Point(704, 460);
            this.button_text.Name = "button_text";
            this.button_text.Size = new System.Drawing.Size(596, 135);
            this.button_text.TabIndex = 2;
            this.button_text.Text = "Change Text";
            this.button_text.UseVisualStyleBackColor = true;
            this.button_text.Click += new System.EventHandler(this.button_text_Click);
            // 
            // textBox_input
            // 
            this.textBox_input.Font = new System.Drawing.Font("新細明體", 26.25F);
            this.textBox_input.Location = new System.Drawing.Point(704, 265);
            this.textBox_input.Multiline = true;
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(596, 135);
            this.textBox_input.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 695);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.button_text);
            this.Controls.Add(this.tb_show);
            this.Controls.Add(this.buttonRelease);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonStart);
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonRelease;
        private System.Windows.Forms.TextBox tb_show;
        private System.Windows.Forms.Button button_text;
        private System.Windows.Forms.TextBox textBox_input;
    }
}

