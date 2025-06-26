using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Ex03_ManagedObjectToControlExcel
{
    public class ManagedExcelApp: IDisposable
    {
        dynamic excelApp = null;
        dynamic workbook = null;

        public ManagedExcelApp()
        {
            excelApp = new Microsoft.Office.Interop.Excel.Application();
        }

        public void Open(string path)
        {
            //excelApp =  Marshal.GetActiveObject("Excel.Application");
            /*如果有系統管理員權限的問題，
             * 先到Office安裝目錄中，找到Microsoft.Office.Interop.Excel.dll並加入參考
             * 再使用下面的方式建立excelApp
             */          
            workbook = excelApp.Workbooks.Open(path);
            excelApp.Visible = true;
        }

        public void Close()
        {
            if (workbook == null)
                return;            
            Console.WriteLine("關閉workbook;");
            workbook.Close();

            if (excelApp == null)
                return;
            
            Console.WriteLine("執行Excel.Quit();");
            excelApp.Quit();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                try
                {
                    //if (workbook == null)
                    //    return;
                    //Console.WriteLine("關閉workbook;");
                    //workbook.Close();

                    if (excelApp == null)
                        return;

                    Console.WriteLine("執行Excel.Quit();");
                    excelApp.Quit();

                    Console.WriteLine("釋放COM物件");
                    Marshal.ReleaseComObject(excelApp);

                }
                catch(Exception ex)
                {
                    System.Environment.Exit(System.Environment.ExitCode);

                }
                finally
                {
                    Console.WriteLine("進行GC回收");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~ManagedExcelApp()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
