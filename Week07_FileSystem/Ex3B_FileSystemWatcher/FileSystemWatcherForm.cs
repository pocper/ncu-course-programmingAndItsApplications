using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Ex3B_FileSystemWatcher
{
    public partial class FileSystemWatcherForm : Form
    {
        string selectedPath = null;
        FileSystemWatcher watcher = new FileSystemWatcher();

        bool isEventRaised = false;
        string log = null;
        

        public FileSystemWatcherForm()
        {
            InitializeComponent();

            watcher.IncludeSubdirectories = false;
            watcher.Filter = "*.*";
            watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.Size
                | NotifyFilters.FileName | NotifyFilters.LastAccess;

            watcher.Changed += Watcher_Changed;
            watcher.Renamed += Watcher_Renamed;

            timer1.Start();
        }

        private void Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            string content = string.Format("{0} is renamed", e.Name);
            log = content;
            isEventRaised = true;
        }

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            string content = string.Format("{0} is changed", e.Name);
            log = content;
            isEventRaised = true;
        }

        private void button_SelectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                selectedPath = dialog.SelectedPath;
                watcher.Path = selectedPath;
                textBox_Dir.Text = selectedPath;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isEventRaised)
            {
                listBox_Log.Items.Add(this.log);

                isEventRaised = false;
            }
        }

        private void checkBox_IsMonitoring_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_IsMonitoring.Checked)
                watcher.EnableRaisingEvents = true;
            else
                watcher.EnableRaisingEvents = false;
        }
    }
}
