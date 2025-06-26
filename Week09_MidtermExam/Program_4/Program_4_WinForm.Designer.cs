
namespace Program_4
{
    partial class Program_4_WinForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeopleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 97);
            this.button1.TabIndex = 1;
            this.button1.Text = "讀取";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sex,
            this.Birth,
            this.PeopleName});
            this.dataGridView1.Location = new System.Drawing.Point(399, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 45;
            this.dataGridView1.Size = new System.Drawing.Size(1223, 531);
            this.dataGridView1.TabIndex = 2;
            // 
            // Sex
            // 
            this.Sex.HeaderText = "Sex";
            this.Sex.MinimumWidth = 12;
            this.Sex.Name = "Sex";
            this.Sex.Width = 250;
            // 
            // Birth
            // 
            this.Birth.HeaderText = "Birth";
            this.Birth.MinimumWidth = 12;
            this.Birth.Name = "Birth";
            this.Birth.Width = 250;
            // 
            // PeopleName
            // 
            this.PeopleName.HeaderText = "Name";
            this.PeopleName.MinimumWidth = 12;
            this.PeopleName.Name = "PeopleName";
            this.PeopleName.Width = 250;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(73, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 98);
            this.button2.TabIndex = 3;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Program_4_WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1954, 869);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Program_4_WinForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeopleName;
        private System.Windows.Forms.Button button2;
    }
}

