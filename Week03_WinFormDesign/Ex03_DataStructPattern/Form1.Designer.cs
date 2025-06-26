namespace Ex03_DataStructPattern
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_ShowJob = new System.Windows.Forms.TextBox();
            this.button_SelectRed = new System.Windows.Forms.Button();
            this.button_SelectGreen = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.label_Position = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_CycleTime = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(255, 32);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 52);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_ShowJob);
            this.groupBox1.Controls.Add(this.button_SelectRed);
            this.groupBox1.Controls.Add(this.button_SelectGreen);
            this.groupBox1.Location = new System.Drawing.Point(16, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Job Management";
            // 
            // textBox_ShowJob
            // 
            this.textBox_ShowJob.Location = new System.Drawing.Point(18, 68);
            this.textBox_ShowJob.Multiline = true;
            this.textBox_ShowJob.Name = "textBox_ShowJob";
            this.textBox_ShowJob.Size = new System.Drawing.Size(177, 32);
            this.textBox_ShowJob.TabIndex = 1;
            // 
            // button_SelectRed
            // 
            this.button_SelectRed.Location = new System.Drawing.Point(18, 21);
            this.button_SelectRed.Name = "button_SelectRed";
            this.button_SelectRed.Size = new System.Drawing.Size(75, 23);
            this.button_SelectRed.TabIndex = 0;
            this.button_SelectRed.Text = "Red";
            this.button_SelectRed.UseVisualStyleBackColor = true;
            this.button_SelectRed.Click += new System.EventHandler(this.button_SelectRed_Click);
            // 
            // button_SelectGreen
            // 
            this.button_SelectGreen.Location = new System.Drawing.Point(120, 21);
            this.button_SelectGreen.Name = "button_SelectGreen";
            this.button_SelectGreen.Size = new System.Drawing.Size(75, 23);
            this.button_SelectGreen.TabIndex = 0;
            this.button_SelectGreen.Text = "Green";
            this.button_SelectGreen.UseVisualStyleBackColor = true;
            this.button_SelectGreen.Click += new System.EventHandler(this.button_SelectGreen_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(255, 90);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 52);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Robot Position: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Robot Status:";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(100, 190);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(23, 12);
            this.label_Status.TabIndex = 3;
            this.label_Status.Text = "Idle";
            // 
            // label_Position
            // 
            this.label_Position.AutoSize = true;
            this.label_Position.Location = new System.Drawing.Point(100, 163);
            this.label_Position.Name = "label_Position";
            this.label_Position.Size = new System.Drawing.Size(35, 12);
            this.label_Position.TabIndex = 3;
            this.label_Position.Text = "Origin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cycle Time (sec):";
            // 
            // textBox_CycleTime
            // 
            this.textBox_CycleTime.Location = new System.Drawing.Point(205, 187);
            this.textBox_CycleTime.Name = "textBox_CycleTime";
            this.textBox_CycleTime.Size = new System.Drawing.Size(125, 22);
            this.textBox_CycleTime.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 231);
            this.Controls.Add(this.textBox_CycleTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_Position);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "MyRobotControlPanel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_ShowJob;
        private System.Windows.Forms.Button button_SelectRed;
        private System.Windows.Forms.Button button_SelectGreen;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Label label_Position;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_CycleTime;
        private System.Windows.Forms.Timer timer1;
    }
}

