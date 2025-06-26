
namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.input_txt = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Convert = new System.Windows.Forms.Button();
            this.output_txt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input_txt
            // 
            this.input_txt.Location = new System.Drawing.Point(83, 39);
            this.input_txt.Name = "input_txt";
            this.input_txt.Size = new System.Drawing.Size(445, 622);
            this.input_txt.TabIndex = 0;
            this.input_txt.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 24F);
            this.label3.Location = new System.Drawing.Point(135, 807);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 80);
            this.label3.TabIndex = 5;
            this.label3.Text = "CNC code";
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(703, 798);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(305, 128);
            this.Convert.TabIndex = 6;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // output_txt
            // 
            this.output_txt.Location = new System.Drawing.Point(657, 39);
            this.output_txt.Name = "output_txt";
            this.output_txt.Size = new System.Drawing.Size(445, 622);
            this.output_txt.TabIndex = 7;
            this.output_txt.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(250, 682);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(838, 682);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 1050);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output_txt);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox input_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.RichTextBox output_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

