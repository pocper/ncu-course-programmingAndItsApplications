using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Ex03_ManageResource
{
    public partial class Form1 : Form
    {
        dynamic excelApp = null;
        dynamic workbook = null;
       // dynamic worksheet = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            //excelApp =  Marshal.GetActiveObject("Excel.Application");
            /*如果有系統管理員權限的問題，
             * 先到Office安裝目錄中，找到Microsoft.Office.Interop.Excel.dll並加入參考
             * 再使用下面的方式建立excelApp
             */
            excelApp = new Microsoft.Office.Interop.Excel.Application();  

            string wp = System.IO.Directory.GetCurrentDirectory();
            workbook = excelApp.Workbooks.Open(wp+"\\MyExcel.xlsx");
            excelApp.Visible = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Console.WriteLine("關閉workbook;");
            workbook.Close();

            Console.WriteLine("執行Excel.Quit();");
            excelApp.Quit();

            //Console.WriteLine("釋放COM物件");
            Marshal.ReleaseComObject(excelApp);

            Console.WriteLine("進行GC回收");
            GC.Collect();
            GC.WaitForPendingFinalizers();

        }
    }
}


