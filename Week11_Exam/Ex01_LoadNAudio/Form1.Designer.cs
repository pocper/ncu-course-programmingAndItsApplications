namespace Ex01_LoadNAudio
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnRecord = new System.Windows.Forms.Button();
            this.textBox_LeftRMS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_RightRMS = new System.Windows.Forms.TextBox();
            this.textBox_threshold = new System.Windows.Forms.TextBox();
            this.button_set = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(91, 65);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(8);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(339, 160);
            this.btnRecord.TabIndex = 0;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // textBox_LeftRMS
            // 
            this.textBox_LeftRMS.Location = new System.Drawing.Point(1025, 74);
            this.textBox_LeftRMS.Name = "textBox_LeftRMS";
            this.textBox_LeftRMS.Size = new System.Drawing.Size(154, 43);
            this.textBox_LeftRMS.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(868, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Left RMS";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(852, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Right RMS";
            // 
            // textBox_RightRMS
            // 
            this.textBox_RightRMS.Location = new System.Drawing.Point(1025, 152);
            this.textBox_RightRMS.Name = "textBox_RightRMS";
            this.textBox_RightRMS.Size = new System.Drawing.Size(154, 43);
            this.textBox_RightRMS.TabIndex = 5;
            // 
            // textBox_threshold
            // 
            this.textBox_threshold.Location = new System.Drawing.Point(519, 182);
            this.textBox_threshold.Name = "textBox_threshold";
            this.textBox_threshold.Size = new System.Drawing.Size(225, 43);
            this.textBox_threshold.TabIndex = 6;
            // 
            // button_set
            // 
            this.button_set.Location = new System.Drawing.Point(519, 65);
            this.button_set.Name = "button_set";
            this.button_set.Size = new System.Drawing.Size(225, 95);
            this.button_set.TabIndex = 7;
            this.button_set.Text = "Set";
            this.button_set.UseVisualStyleBackColor = true;
            this.button_set.Click += new System.EventHandler(this.button_set_Click);
            // 
            // chart1
            // 
            chartArea2.AxisY.Maximum = 32768D;
            chartArea2.AxisY.Minimum = -32768D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(32, 268);
            this.chart1.Margin = new System.Windows.Forms.Padding(8);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Left";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Right";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1217, 696);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 1125);
            this.Controls.Add(this.button_set);
            this.Controls.Add(this.textBox_threshold);
            this.Controls.Add(this.textBox_RightRMS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_LeftRMS);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnRecord);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.TextBox textBox_LeftRMS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_RightRMS;
        private System.Windows.Forms.TextBox textBox_threshold;
        private System.Windows.Forms.Button button_set;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

