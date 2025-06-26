using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Ex0_FileDialog
{
    public partial class FormEx2B : Form
    {
        string openedFile = null;
        List<MyDataSet> myData = new List<MyDataSet>();

        public FormEx2B()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "開啟一個檔案(練習用)";
            openFileDialog.Filter = "Common Separate File|*.csv";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                openedFile = openFileDialog.FileName;
                textBox_OpenFilePath.Text = openedFile;

                if (File.Exists(openedFile))
                    ReadContent(openedFile);
                else
                    textBox_OpenFilePath.Text = "File does not exist!";
            }
        }

        private void ReadContent(string openedFile)
        {
            FileStream fileStream = new FileStream(openedFile, FileMode.Open, FileAccess.Read);

            StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8);

            textBox_ReadContent.Text = "";
            int i = 0;
            myData.Clear();
            while (streamReader.EndOfStream != true)
            {
                string line = streamReader.ReadLine();

                if (i != 0)
                {
                    string[] elements = line.Split(',');
                    MyDataSet data = new MyDataSet();
                    data.Int = Int32.Parse(elements[0]);
                    data.Short = Int16.Parse(elements[1]);
                    data.Byte = Byte.Parse(elements[2]);
                    myData.Add(data);
                }
                i++;

                //Console.WriteLine(line);
                textBox_ReadContent.Text += line;
            }
            streamReader.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "儲存一個檔案(練習用)";
            saveFileDialog.Filter = "Binary data|*.bindata";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                textBox_SaveFilePath.Text = fileName;
                SaveContent(fileName);
            }

        }

        private void SaveContent(string fileName)
        {
            FileStream fileStream 
                = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            BinaryWriter bw = new BinaryWriter(fileStream, Encoding.UTF8);
            foreach(var data in myData)
            {
                bw.Write(data.Int);
                bw.Write(data.Short);
                bw.Write(data.Byte);
            }
            bw.Close();


        }

        private void button_CopyContent_Click(object sender, EventArgs e)
        {
            textBox_CopiedContent.Text = textBox_ReadContent.Text;

        }
    }
}
