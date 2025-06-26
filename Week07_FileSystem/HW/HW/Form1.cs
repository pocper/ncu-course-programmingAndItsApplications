using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HW
{
    public partial class Form1 : Form
    {
        string SelectedPath = null;
        int FilesNum = 0;
        int FoldersNum = 0;
        int FilesSize = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }


        private void button_selectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                SelectedPath = dialog.SelectedPath;
                textBox_SelectedDir.Text = SelectedPath;
            }
        }

        private void CheckedFiles(string Dir)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(Dir);
            var filesInfo = dirInfo.GetFiles();
            FilesNum += filesInfo.Length;

            foreach (var files in filesInfo)
            {
                FilesSize += Convert.ToInt32(files.Length);
            }

            FoldersNum += dirInfo.GetDirectories().Length;

            foreach (var subDir in dirInfo.GetDirectories())
            {
                CheckedFiles(subDir.FullName);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SelectedPath != null)
            {
                FilesNum = 0;
                FoldersNum = 0;
                FilesSize = 0;
                CheckedFiles(SelectedPath);
                FilesSize /= 1000;
                textBox_FileNum.Text = FilesNum.ToString();
                textBox_FolderNum.Text = FoldersNum.ToString();
                textBox_FileSize.Text = FilesSize.ToString();
            }
        }
    }
}
