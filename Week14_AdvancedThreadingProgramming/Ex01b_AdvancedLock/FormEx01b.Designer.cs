namespace Ex01b_AdvancedLock
{
    partial class FormEx01b
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
            isThrdStopped = true;
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
            this.buttonStartThrdA = new System.Windows.Forms.Button();
            this.buttonStartThrdB = new System.Windows.Forms.Button();
            this.tb_xAlarm = new System.Windows.Forms.TextBox();
            this.tb_xA = new System.Windows.Forms.TextBox();
            this.tb_xB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonStartThrdA
            // 
            this.buttonStartThrdA.Location = new System.Drawing.Point(24, 23);
            this.buttonStartThrdA.Name = "buttonStartThrdA";
            this.buttonStartThrdA.Size = new System.Drawing.Size(141, 38);
            this.buttonStartThrdA.TabIndex = 0;
            this.buttonStartThrdA.Text = "Start Thread A";
            this.buttonStartThrdA.UseVisualStyleBackColor = true;
            this.buttonStartThrdA.Click += new System.EventHandler(this.buttonStartThrdA_Click);
            // 
            // buttonStartThrdB
            // 
            this.buttonStartThrdB.Location = new System.Drawing.Point(24, 78);
            this.buttonStartThrdB.Name = "buttonStartThrdB";
            this.buttonStartThrdB.Size = new System.Drawing.Size(141, 38);
            this.buttonStartThrdB.TabIndex = 0;
            this.buttonStartThrdB.Text = "Start Thread B";
            this.buttonStartThrdB.UseVisualStyleBackColor = true;
            this.buttonStartThrdB.Click += new System.EventHandler(this.buttonStartThrdB_Click);
            // 
            // tb_xAlarm
            // 
            this.tb_xAlarm.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_xAlarm.Location = new System.Drawing.Point(292, 23);
            this.tb_xAlarm.Name = "tb_xAlarm";
            this.tb_xAlarm.Size = new System.Drawing.Size(90, 46);
            this.tb_xAlarm.TabIndex = 1;
            this.tb_xAlarm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_xA
            // 
            this.tb_xA.Location = new System.Drawing.Point(188, 33);
            this.tb_xA.Name = "tb_xA";
            this.tb_xA.Size = new System.Drawing.Size(58, 22);
            this.tb_xA.TabIndex = 2;
            this.tb_xA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_xB
            // 
            this.tb_xB.Location = new System.Drawing.Point(188, 88);
            this.tb_xB.Name = "tb_xB";
            this.tb_xB.Size = new System.Drawing.Size(58, 22);
            this.tb_xB.TabIndex = 2;
            this.tb_xB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "There is a thread to reset ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 140);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_xB);
            this.Controls.Add(this.tb_xA);
            this.Controls.Add(this.tb_xAlarm);
            this.Controls.Add(this.buttonStartThrdB);
            this.Controls.Add(this.buttonStartThrdA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartThrdA;
        private System.Windows.Forms.Button buttonStartThrdB;
        private System.Windows.Forms.TextBox tb_xAlarm;
        private System.Windows.Forms.TextBox tb_xA;
        private System.Windows.Forms.TextBox tb_xB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

