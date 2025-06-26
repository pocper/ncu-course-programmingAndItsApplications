namespace Test15
{
    partial class FormTest14
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
            this.button_Start = new System.Windows.Forms.Button();
            this.listBox_Content = new System.Windows.Forms.ListBox();
            this.button_Stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(12, 12);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(126, 48);
            this.button_Start.TabIndex = 0;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // listBox_Content
            // 
            this.listBox_Content.FormattingEnabled = true;
            this.listBox_Content.ItemHeight = 12;
            this.listBox_Content.Location = new System.Drawing.Point(12, 73);
            this.listBox_Content.Name = "listBox_Content";
            this.listBox_Content.Size = new System.Drawing.Size(275, 256);
            this.listBox_Content.TabIndex = 2;
            // 
            // button_Stop
            // 
            this.button_Stop.Location = new System.Drawing.Point(161, 12);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(126, 48);
            this.button_Stop.TabIndex = 0;
            this.button_Stop.Text = "Stop";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormTest15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 347);
            this.Controls.Add(this.listBox_Content);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Start);
            this.Name = "FormTest15";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.ListBox listBox_Content;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Timer timer1;
    }
}

