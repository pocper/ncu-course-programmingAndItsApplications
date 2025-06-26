
namespace Test02
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.buttonPlot = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonFFT = new System.Windows.Forms.Button();
            this.chartTime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartFreq = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFreq)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPlot
            // 
            this.buttonPlot.Location = new System.Drawing.Point(32, 33);
            this.buttonPlot.Name = "buttonPlot";
            this.buttonPlot.Size = new System.Drawing.Size(124, 58);
            this.buttonPlot.TabIndex = 1;
            this.buttonPlot.Text = "Plot";
            this.buttonPlot.UseVisualStyleBackColor = true;
            this.buttonPlot.Click += new System.EventHandler(this.buttonPlot_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(32, 288);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(124, 58);
            this.buttonFilter.TabIndex = 1;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonFFT
            // 
            this.buttonFFT.Location = new System.Drawing.Point(32, 163);
            this.buttonFFT.Name = "buttonFFT";
            this.buttonFFT.Size = new System.Drawing.Size(124, 58);
            this.buttonFFT.TabIndex = 1;
            this.buttonFFT.Text = "FFT";
            this.buttonFFT.UseVisualStyleBackColor = true;
            this.buttonFFT.Click += new System.EventHandler(this.buttonFFT_Click);
            // 
            // chartTime
            // 
            chartArea1.AxisX.Interval = 0.2D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.Maximum = 1D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX2.Interval = 0.1D;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.Crossing = 0D;
            chartArea1.AxisY.Interval = 0.2D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.Maximum = 1.2D;
            chartArea1.AxisY.Minimum = -1.2D;
            chartArea1.Name = "ChartArea1";
            this.chartTime.ChartAreas.Add(chartArea1);
            this.chartTime.Cursor = System.Windows.Forms.Cursors.Cross;
            legend1.Name = "Legend1";
            this.chartTime.Legends.Add(legend1);
            this.chartTime.Location = new System.Drawing.Point(206, 33);
            this.chartTime.Name = "chartTime";
            this.chartTime.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Raw";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Filtered";
            this.chartTime.Series.Add(series1);
            this.chartTime.Series.Add(series2);
            this.chartTime.Size = new System.Drawing.Size(729, 313);
            this.chartTime.TabIndex = 2;
            this.chartTime.Text = "chart1";
            title1.Name = "Time";
            title1.Text = "ChartTime";
            this.chartTime.Titles.Add(title1);
            // 
            // chartFreq
            // 
            chartArea2.AxisX.Interval = 100D;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX.Maximum = 500D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX2.Interval = 20D;
            chartArea2.AxisX2.TitleForeColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.Crossing = 0D;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chartFreq.ChartAreas.Add(chartArea2);
            this.chartFreq.Cursor = System.Windows.Forms.Cursors.Cross;
            legend2.Name = "Legend1";
            this.chartFreq.Legends.Add(legend2);
            this.chartFreq.Location = new System.Drawing.Point(206, 363);
            this.chartFreq.Name = "chartFreq";
            this.chartFreq.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Raw";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Legend = "Legend1";
            series4.Name = "Filtered";
            this.chartFreq.Series.Add(series3);
            this.chartFreq.Series.Add(series4);
            this.chartFreq.Size = new System.Drawing.Size(729, 313);
            this.chartFreq.TabIndex = 2;
            this.chartFreq.Text = "chart1";
            title2.Name = "Freq";
            title2.Text = "ChartFreq";
            this.chartFreq.Titles.Add(title2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 702);
            this.Controls.Add(this.chartFreq);
            this.Controls.Add(this.chartTime);
            this.Controls.Add(this.buttonFFT);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.buttonPlot);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFreq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonPlot;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonFFT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTime;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFreq;
    }
}

