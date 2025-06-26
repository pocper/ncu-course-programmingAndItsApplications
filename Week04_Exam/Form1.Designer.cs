namespace WindowsFormsApp2
{
    partial class Form1
    {
        private const string V = "Form1";

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
            this.checkedListBox_Field = new System.Windows.Forms.CheckedListBox();
            this.comboBox_Condition = new System.Windows.Forms.ComboBox();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Filter = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox_Field
            // 
            this.checkedListBox_Field.FormattingEnabled = true;
            this.checkedListBox_Field.Items.AddRange(new object[] {
            "ID",
            "Name",
            "E-mail",
            "Birth Year",
            "Department",
            "Note"});
            this.checkedListBox_Field.Location = new System.Drawing.Point(56, 30);
            this.checkedListBox_Field.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.checkedListBox_Field.Name = "checkedListBox_Field";
            this.checkedListBox_Field.Size = new System.Drawing.Size(313, 284);
            this.checkedListBox_Field.TabIndex = 0;
            this.checkedListBox_Field.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_Field_SelectedIndexChanged);
            // 
            // comboBox_Condition
            // 
            this.comboBox_Condition.FormattingEnabled = true;
            this.comboBox_Condition.Items.AddRange(new object[] {
            "機械系",
            "中文系",
            "企管系",
            "全部"});
            this.comboBox_Condition.Location = new System.Drawing.Point(56, 400);
            this.comboBox_Condition.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.comboBox_Condition.Name = "comboBox_Condition";
            this.comboBox_Condition.Size = new System.Drawing.Size(316, 38);
            this.comboBox_Condition.TabIndex = 1;
            this.comboBox_Condition.SelectedIndexChanged += new System.EventHandler(this.comboBox_Condition_SelectedIndexChanged);
            // 
            // dGV
            // 
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.StudentName,
            this.Email,
            this.BirthYear,
            this.Depart,
            this.Note});
            this.dGV.Location = new System.Drawing.Point(395, 30);
            this.dGV.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.dGV.Name = "dGV";
            this.dGV.RowHeadersWidth = 102;
            this.dGV.RowTemplate.Height = 24;
            this.dGV.Size = new System.Drawing.Size(1945, 1120);
            this.dGV.TabIndex = 2;
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "ID";
            this.StudentID.MinimumWidth = 12;
            this.StudentID.Name = "StudentID";
            this.StudentID.Width = 250;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Name";
            this.StudentName.MinimumWidth = 12;
            this.StudentName.Name = "StudentName";
            this.StudentName.Width = 250;
            // 
            // Email
            // 
            this.Email.HeaderText = "E-mail";
            this.Email.MinimumWidth = 12;
            this.Email.Name = "Email";
            this.Email.Width = 250;
            // 
            // BirthYear
            // 
            this.BirthYear.HeaderText = "Birth Year";
            this.BirthYear.MinimumWidth = 12;
            this.BirthYear.Name = "BirthYear";
            this.BirthYear.Width = 250;
            // 
            // Depart
            // 
            this.Depart.HeaderText = "Department";
            this.Depart.MinimumWidth = 12;
            this.Depart.Name = "Depart";
            this.Depart.Width = 250;
            // 
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.MinimumWidth = 12;
            this.Note.Name = "Note";
            this.Note.Width = 250;
            // 
            // button_Filter
            // 
            this.button_Filter.Location = new System.Drawing.Point(56, 498);
            this.button_Filter.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.button_Filter.Name = "button_Filter";
            this.button_Filter.Size = new System.Drawing.Size(320, 128);
            this.button_Filter.TabIndex = 3;
            this.button_Filter.Text = "Filter";
            this.button_Filter.UseVisualStyleBackColor = true;
            this.button_Filter.Click += new System.EventHandler(this.button_Filter_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2626, 1180);
            this.Controls.Add(this.button_Filter);
            this.Controls.Add(this.dGV);
            this.Controls.Add(this.comboBox_Condition);
            this.Controls.Add(this.checkedListBox_Field);
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "Form1";
            this.Text = "資料篩選器";
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox_Field;
        private System.Windows.Forms.ComboBox comboBox_Condition;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.Button button_Filter;
        private System.Windows.Forms.Timer timer1;
    }
}

