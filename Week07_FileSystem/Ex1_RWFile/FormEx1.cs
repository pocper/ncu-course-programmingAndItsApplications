using System;
using System.Windows.Forms;
using System.IO;

namespace Ex0_FileDialog
{
    public partial class FormEx1 : Form
    {
        string openedFile = null;

        public FormEx1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //openFileDialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory();

            openFileDialog.Title = "開啟一個檔案(練習用)";
            openFileDialog.Filter = "Common Separate File|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
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
            string[] lines = System.IO.File.ReadAllLines(openedFile);

            listBox_Content.Items.Clear();
            foreach (string line in lines)
            {
                listBox_Content.Items.Add(line);
            }
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
            string content = textBox_CopiedContent.Text;

            //1
            string[] lines = content.Split('\n');
            System.IO.File.WriteAllLines(fileName, lines);

            //2
            //File.WriteAllText(fileName, content);
        }

        private void button_CopyContent_Click(object sender, EventArgs e)
        {
            textBox_CopiedContent.Text = "";
            foreach (object line in listBox_Content.Items)
            {
                string str = line as string;
                textBox_CopiedContent.Text += str + Environment.NewLine;

            }
        }
    }
}
