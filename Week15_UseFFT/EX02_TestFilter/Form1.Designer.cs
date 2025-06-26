namespace EX02_TestFilter
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_GenerateSamples = new System.Windows.Forms.Button();
            this.button_DoFilter = new System.Windows.Forms.Button();
            this.textBox_bandWidth = new System.Windows.Forms.TextBox();
            this.textBox_CutOffFreq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_SampleRate = new System.Windows.Forms.ComboBox();
            this.comboBox_Length = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 2D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(230, 22);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Filtered";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Original";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(652, 326);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // button_GenerateSamples
            // 
            this.button_GenerateSamples.Location = new System.Drawing.Point(12, 82);
            this.button_GenerateSamples.Name = "button_GenerateSamples";
            this.button_GenerateSamples.Size = new System.Drawing.Size(181, 65);
            this.button_GenerateSamples.TabIndex = 1;
            this.button_GenerateSamples.Text = "Generate Samples";
            this.button_GenerateSamples.UseVisualStyleBackColor = true;
            this.button_GenerateSamples.Click += new System.EventHandler(this.button_GenerateSamples_Click);
            // 
            // button_DoFilter
            // 
            this.button_DoFilter.Location = new System.Drawing.Point(12, 277);
            this.button_DoFilter.Name = "button_DoFilter";
            this.button_DoFilter.Size = new System.Drawing.Size(181, 65);
            this.button_DoFilter.TabIndex = 1;
            this.button_DoFilter.Text = "Run Filter";
            this.button_DoFilter.UseVisualStyleBackColor = true;
            this.button_DoFilter.Click += new System.EventHandler(this.button_DoFilter_Click);
            // 
            // textBox_bandWidth
            // 
            this.textBox_bandWidth.Location = new System.Drawing.Point(105, 244);
            this.textBox_bandWidth.Name = "textBox_bandWidth";
            this.textBox_bandWidth.Size = new System.Drawing.Size(88, 22);
            this.textBox_bandWidth.TabIndex = 2;
            this.textBox_bandWidth.Text = "1.6";
            this.textBox_bandWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CutOffFreq
            // 
            this.textBox_CutOffFreq.Location = new System.Drawing.Point(93, 216);
            this.textBox_CutOffFreq.Name = "textBox_CutOffFreq";
            this.textBox_CutOffFreq.Size = new System.Drawing.Size(100, 22);
            this.textBox_CutOffFreq.TabIndex = 2;
            this.textBox_CutOffFreq.Text = "250";
            this.textBox_CutOffFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "cut off freq.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "band width factor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "sample rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "length";
            // 
            // comboBox_SampleRate
            // 
            this.comboBox_SampleRate.FormattingEnabled = true;
            this.comboBox_SampleRate.Items.AddRange(new object[] {
            "1024",
            "2048",
            "4096",
            "8192"});
            this.comboBox_SampleRate.Location = new System.Drawing.Point(93, 22);
            this.comboBox_SampleRate.Name = "comboBox_SampleRate";
            this.comboBox_SampleRate.Size = new System.Drawing.Size(121, 20);
            this.comboBox_SampleRate.TabIndex = 4;
            // 
            // comboBox_Length
            // 
            this.comboBox_Length.FormattingEnabled = true;
            this.comboBox_Length.Items.AddRange(new object[] {
            "1024",
            "2048",
            "4096",
            "8192",
            "16384",
            "32768",
            "65536"});
            this.comboBox_Length.Location = new System.Drawing.Point(93, 56);
            this.comboBox_Length.Name = "comboBox_Length";
            this.comboBox_Length.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Length.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 364);
            this.Controls.Add(this.comboBox_Length);
            this.Controls.Add(this.comboBox_SampleRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_CutOffFreq);
            this.Controls.Add(this.textBox_bandWidth);
            this.Controls.Add(this.button_DoFilter);
            this.Controls.Add(this.button_GenerateSamples);
            this.Controls.Add(this.chart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button button_GenerateSamples;
        private System.Windows.Forms.Button button_DoFilter;
        private System.Windows.Forms.TextBox textBox_bandWidth;
        private System.Windows.Forms.TextBox textBox_CutOffFreq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_SampleRate;
        private System.Windows.Forms.ComboBox comboBox_Length;
    }
}

