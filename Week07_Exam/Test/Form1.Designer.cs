
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
            this.components = new System.ComponentModel.Container();
            this.button_select = new System.Windows.Forms.Button();
            this.textBox_select = new System.Windows.Forms.TextBox();
            this.textBox_No = new System.Windows.Forms.TextBox();
            this.textBox_Y = new System.Windows.Forms.TextBox();
            this.textBox_Z = new System.Windows.Forms.TextBox();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_convert = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.textBox_save = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button_select
            // 
            this.button_select.Location = new System.Drawing.Point(68, 71);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(145, 90);
            this.button_select.TabIndex = 0;
            this.button_select.Text = "選擇";
            this.button_select.UseVisualStyleBackColor = true;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // textBox_select
            // 
            this.textBox_select.Location = new System.Drawing.Point(329, 71);
            this.textBox_select.Multiline = true;
            this.textBox_select.Name = "textBox_select";
            this.textBox_select.Size = new System.Drawing.Size(479, 90);
            this.textBox_select.TabIndex = 1;
            // 
            // textBox_No
            // 
            this.textBox_No.Location = new System.Drawing.Point(183, 235);
            this.textBox_No.Name = "textBox_No";
            this.textBox_No.Size = new System.Drawing.Size(100, 43);
            this.textBox_No.TabIndex = 2;
            // 
            // textBox_Y
            // 
            this.textBox_Y.Location = new System.Drawing.Point(406, 358);
            this.textBox_Y.Name = "textBox_Y";
            this.textBox_Y.Size = new System.Drawing.Size(150, 43);
            this.textBox_Y.TabIndex = 3;
            // 
            // textBox_Z
            // 
            this.textBox_Z.Location = new System.Drawing.Point(656, 358);
            this.textBox_Z.Name = "textBox_Z";
            this.textBox_Z.Size = new System.Drawing.Size(150, 43);
            this.textBox_Z.TabIndex = 4;
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(153, 358);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(150, 43);
            this.textBox_X.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "X=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Y=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(583, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Z=";
            // 
            // button_convert
            // 
            this.button_convert.Location = new System.Drawing.Point(68, 618);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(740, 130);
            this.button_convert.TabIndex = 10;
            this.button_convert.Text = "轉換";
            this.button_convert.UseVisualStyleBackColor = true;
            this.button_convert.Click += new System.EventHandler(this.button_convert_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(68, 471);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(145, 85);
            this.button_save.TabIndex = 11;
            this.button_save.Text = "存檔";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // textBox_save
            // 
            this.textBox_save.Location = new System.Drawing.Point(343, 471);
            this.textBox_save.Multiline = true;
            this.textBox_save.Name = "textBox_save";
            this.textBox_save.Size = new System.Drawing.Size(465, 85);
            this.textBox_save.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 821);
            this.Controls.Add(this.textBox_save);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_convert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_X);
            this.Controls.Add(this.textBox_Z);
            this.Controls.Add(this.textBox_Y);
            this.Controls.Add(this.textBox_No);
            this.Controls.Add(this.textBox_select);
            this.Controls.Add(this.button_select);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.TextBox textBox_select;
        private System.Windows.Forms.TextBox textBox_No;
        private System.Windows.Forms.TextBox textBox_Y;
        private System.Windows.Forms.TextBox textBox_Z;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_convert;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox textBox_save;
        private System.Windows.Forms.Timer timer1;
    }
}

