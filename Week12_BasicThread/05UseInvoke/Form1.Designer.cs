namespace _05UseInvoke
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
            this.buttonUsingInvoke = new System.Windows.Forms.Button();
            this.buttonNoInvoke = new System.Windows.Forms.Button();
            this.textBox1Source = new System.Windows.Forms.TextBox();
            this.textBox2Source = new System.Windows.Forms.TextBox();
            this.textBox1Dest = new System.Windows.Forms.TextBox();
            this.textBox2Dest = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonUsingInvoke
            // 
            this.buttonUsingInvoke.Location = new System.Drawing.Point(186, 50);
            this.buttonUsingInvoke.Name = "buttonUsingInvoke";
            this.buttonUsingInvoke.Size = new System.Drawing.Size(144, 48);
            this.buttonUsingInvoke.TabIndex = 0;
            this.buttonUsingInvoke.Text = "Copy using Invoke";
            this.buttonUsingInvoke.UseVisualStyleBackColor = true;
            this.buttonUsingInvoke.Click += new System.EventHandler(this.buttonUsingInvoke_Click);
            // 
            // buttonNoInvoke
            // 
            this.buttonNoInvoke.Location = new System.Drawing.Point(186, 117);
            this.buttonNoInvoke.Name = "buttonNoInvoke";
            this.buttonNoInvoke.Size = new System.Drawing.Size(144, 48);
            this.buttonNoInvoke.TabIndex = 0;
            this.buttonNoInvoke.Text = "Copy without Invoke";
            this.buttonNoInvoke.UseVisualStyleBackColor = true;
            this.buttonNoInvoke.Click += new System.EventHandler(this.buttonNoInvoke_Click);
            // 
            // textBox1Source
            // 
            this.textBox1Source.Font = new System.Drawing.Font("PMingLiU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1Source.Location = new System.Drawing.Point(36, 53);
            this.textBox1Source.Name = "textBox1Source";
            this.textBox1Source.Size = new System.Drawing.Size(100, 40);
            this.textBox1Source.TabIndex = 1;
            this.textBox1Source.Text = "--";
            this.textBox1Source.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2Source
            // 
            this.textBox2Source.Font = new System.Drawing.Font("PMingLiU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2Source.Location = new System.Drawing.Point(36, 120);
            this.textBox2Source.Name = "textBox2Source";
            this.textBox2Source.Size = new System.Drawing.Size(100, 40);
            this.textBox2Source.TabIndex = 1;
            this.textBox2Source.Text = "--";
            this.textBox2Source.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1Dest
            // 
            this.textBox1Dest.Font = new System.Drawing.Font("PMingLiU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1Dest.Location = new System.Drawing.Point(369, 53);
            this.textBox1Dest.Name = "textBox1Dest";
            this.textBox1Dest.Size = new System.Drawing.Size(100, 40);
            this.textBox1Dest.TabIndex = 1;
            // 
            // textBox2Dest
            // 
            this.textBox2Dest.Font = new System.Drawing.Font("PMingLiU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2Dest.Location = new System.Drawing.Point(369, 120);
            this.textBox2Dest.Name = "textBox2Dest";
            this.textBox2Dest.Size = new System.Drawing.Size(100, 40);
            this.textBox2Dest.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 212);
            this.Controls.Add(this.textBox2Dest);
            this.Controls.Add(this.textBox1Dest);
            this.Controls.Add(this.textBox2Source);
            this.Controls.Add(this.textBox1Source);
            this.Controls.Add(this.buttonNoInvoke);
            this.Controls.Add(this.buttonUsingInvoke);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUsingInvoke;
        private System.Windows.Forms.Button buttonNoInvoke;
        private System.Windows.Forms.TextBox textBox1Source;
        private System.Windows.Forms.TextBox textBox2Source;
        private System.Windows.Forms.TextBox textBox1Dest;
        private System.Windows.Forms.TextBox textBox2Dest;
        private System.Windows.Forms.Timer timer1;
    }
}

