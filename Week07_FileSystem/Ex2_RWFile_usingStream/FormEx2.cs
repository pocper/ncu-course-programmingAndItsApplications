using System;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Ex0_FileDialog
{
    public partial class FormEx2 : Form
    {
        string openedFile = null;

        public FormEx2()
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
            //string content = streamReader.ReadToEnd();
            //textBox_ReadContent.Text = content;

            textBox_ReadContent.Text = "";
            while (streamReader.EndOfStream != true)
            {
                string line = streamReader.ReadLine();
                Console.WriteLine(line);
                textBox_ReadContent.Text += line;
            }

            streamReader.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "儲存一個檔案(練習用)";
            saveFileDialog.Filter = "Common Separate File|*.csv";

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

            using(StreamWriter sw = new StreamWriter(fileStream, Encoding.UTF8))
            {
                string content = textBox_CopiedContent.Text;
                sw.Write(content);
            }
        }

        private void button_CopyContent_Click(object sender, EventArgs e)
        {
            textBox_CopiedContent.Text = textBox_ReadContent.Text;

        }
    }
}
