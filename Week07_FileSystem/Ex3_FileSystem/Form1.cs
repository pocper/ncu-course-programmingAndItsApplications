using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex3_FileSystem
{
    public partial class Form1 : Form
    {
        string file = null;
        System.IO.FileSystemWatcher watcher = new System.IO.FileSystemWatcher();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                file = dialog.FileName;

                if (System.IO.File.Exists(file) == false)
                {
                    textBoxFileInfo.Text = "File doest not exist";
                    return;
                }

                System.IO.FileInfo fi = new System.IO.FileInfo(file);
                textBoxFileInfo.Text = string.Format("File name: {0} , Size: {1} , Created on: {2}",
                    fi.Name, fi.Length, fi.CreationTime.ToString());
            }
        
        }

        private void buttonDirInfo_Click(object sender, EventArgs e)
        {
            System.IO.FileInfo fi = new System.IO.FileInfo(file);
            System.IO.DirectoryInfo dirInfo
                = new System.IO.DirectoryInfo(fi.DirectoryName);

            var files = dirInfo.GetFiles();
            var dirs = dirInfo.GetDirectories();
        }

        private void buttonCurDir_Click(object sender, EventArgs e)
        {
            string text = "Hello world";
            System.IO.File.WriteAllText("helloWorld.txt", text);

            string curDir = System.IO.Directory.GetCurrentDirectory();
            textBoxCurDir.Text = curDir;
        }     
    }
}
