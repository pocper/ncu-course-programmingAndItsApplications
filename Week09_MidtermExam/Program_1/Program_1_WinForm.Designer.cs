
namespace Program_1
{
    partial class Program_1_WinForm
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
            this.textBox_FileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ReadBytes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 52);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 135);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open PNG";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_FileName
            // 
            this.textBox_FileName.Location = new System.Drawing.Point(472, 52);
            this.textBox_FileName.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBox_FileName.Multiline = true;
            this.textBox_FileName.Name = "textBox_FileName";
            this.textBox_FileName.Size = new System.Drawing.Size(967, 129);
            this.textBox_FileName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(48, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "The first 9 bytes:";
            // 
            // textBox_ReadBytes
            // 
            this.textBox_ReadBytes.Location = new System.Drawing.Point(501, 228);
            this.textBox_ReadBytes.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBox_ReadBytes.Multiline = true;
            this.textBox_ReadBytes.Name = "textBox_ReadBytes";
            this.textBox_ReadBytes.Size = new System.Drawing.Size(937, 129);
            this.textBox_ReadBytes.TabIndex = 1;
            // 
            // Program_1_WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ReadBytes);
            this.Controls.Add(this.textBox_FileName);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "Program_1_WinForm";
            this.Text = "Program_1_WinForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_FileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ReadBytes;
    }
}

