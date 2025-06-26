using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex03_ManagedObjectToControlExcel
{
    public partial class FormMOE : Form
    {
        public FormMOE()
        {
            InitializeComponent();
        }

        ManagedExcelApp excelApp;
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string wp = System.IO.Directory.GetCurrentDirectory();
            string path = wp + "\\MyExcel.xlsx";
            excelApp = new ManagedExcelApp();
            excelApp.Open(path);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (excelApp != null)
                excelApp.Close();
        }

        private void FormMOE_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(excelApp !=null)
                excelApp.Dispose();
        }
    }
}
