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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_DoFilter = new System.Windows.Forms.Button();
            this.button_Record = new System.Windows.Forms.Button();
            this.button_openFile = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_bandWidth = new System.Windows.Forms.TextBox();
            this.textBox_CutOffFreq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart_original = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_filter = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_filter)).BeginInit();
            this.SuspendLayout();
            // 
            // button_DoFilter
            // 
            this.button_DoFilter.Location = new System.Drawing.Point(102, 862);
            this.button_DoFilter.Margin = new System.Windows.Forms.Padding(8);
            this.button_DoFilter.Name = "button_DoFilter";
            this.button_DoFilter.Size = new System.Drawing.Size(483, 162);
            this.button_DoFilter.TabIndex = 1;
            this.button_DoFilter.Text = "Filter";
            this.button_DoFilter.UseVisualStyleBackColor = true;
            this.button_DoFilter.Click += new System.EventHandler(this.button_DoFilter_Click);
            // 
            // button_Record
            // 
            this.button_Record.Location = new System.Drawing.Point(102, 80);
            this.button_Record.Name = "button_Record";
            this.button_Record.Size = new System.Drawing.Size(483, 162);
            this.button_Record.TabIndex = 5;
            this.button_Record.Text = "Record";
            this.button_Record.UseVisualStyleBackColor = true;
            this.button_Record.Click += new System.EventHandler(this.button_Record_Click);
            // 
            // button_openFile
            // 
            this.button_openFile.Location = new System.Drawing.Point(102, 649);
            this.button_openFile.Name = "button_openFile";
            this.button_openFile.Size = new System.Drawing.Size(483, 162);
            this.button_openFile.TabIndex = 6;
            this.button_openFile.Text = "Open";
            this.button_openFile.UseVisualStyleBackColor = true;
            this.button_openFile.Click += new System.EventHandler(this.button_openFile_Click);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(102, 280);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(483, 162);
            this.button_stop.TabIndex = 7;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 570);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "band width factor";
            // 
            // textBox_bandWidth
            // 
            this.textBox_bandWidth.Location = new System.Drawing.Point(357, 562);
            this.textBox_bandWidth.Margin = new System.Windows.Forms.Padding(8);
            this.textBox_bandWidth.Name = "textBox_bandWidth";
            this.textBox_bandWidth.Size = new System.Drawing.Size(228, 43);
            this.textBox_bandWidth.TabIndex = 2;
            this.textBox_bandWidth.Text = "1.6";
            this.textBox_bandWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CutOffFreq
            // 
            this.textBox_CutOffFreq.Location = new System.Drawing.Point(357, 492);
            this.textBox_CutOffFreq.Margin = new System.Windows.Forms.Padding(8);
            this.textBox_CutOffFreq.Name = "textBox_CutOffFreq";
            this.textBox_CutOffFreq.Size = new System.Drawing.Size(228, 43);
            this.textBox_CutOffFreq.TabIndex = 2;
            this.textBox_CutOffFreq.Text = "250";
            this.textBox_CutOffFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 500);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "cut off freq.";
            // 
            // chart_original
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.Name = "ChartArea1";
            this.chart_original.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_original.Legends.Add(legend1);
            this.chart_original.Location = new System.Drawing.Point(679, 80);
            this.chart_original.Name = "chart_original";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Original";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            this.chart_original.Series.Add(series1);
            this.chart_original.Size = new System.Drawing.Size(1230, 450);
            this.chart_original.TabIndex = 8;
            this.chart_original.Text = "chart1";
            // 
            // chart_filter
            // 
            chartArea2.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.Name = "ChartArea1";
            this.chart_filter.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_filter.Legends.Add(legend2);
            this.chart_filter.Location = new System.Drawing.Point(679, 608);
            this.chart_filter.Name = "chart_filter";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Filtered";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            this.chart_filter.Series.Add(series2);
            this.chart_filter.Size = new System.Drawing.Size(1230, 416);
            this.chart_filter.TabIndex = 9;
            this.chart_filter.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2028, 1137);
            this.Controls.Add(this.chart_filter);
            this.Controls.Add(this.chart_original);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_openFile);
            this.Controls.Add(this.button_Record);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_CutOffFreq);
            this.Controls.Add(this.textBox_bandWidth);
            this.Controls.Add(this.button_DoFilter);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_filter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_DoFilter;
        private System.Windows.Forms.Button button_Record;
        private System.Windows.Forms.Button button_openFile;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_bandWidth;
        private System.Windows.Forms.TextBox textBox_CutOffFreq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_original;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_filter;
    }
}

