using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex0_FileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //openFileDialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory();

            openFileDialog.Title = "開啟一個檔案(練習用)";
            openFileDialog.Filter = "PowerPoint|*.pptx|OldPowerPoint|*.ppt";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                textBox_OpenFilePath.Text = fileName;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "儲存一個檔案(練習用)";
            saveFileDialog.Filter = "PowerPoint|*.pptx|OldPowerPoint|*.ppt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                textBox_SaveFilePath.Text = fileName;
            }

        }
    }
}
