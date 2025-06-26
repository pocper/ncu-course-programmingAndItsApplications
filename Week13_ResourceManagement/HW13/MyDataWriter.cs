using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW13
{
    public class MyDataWriter:IDisposable
    {
        StreamWriter writer;
        string File;

        public MyDataWriter(string file)
        {
            File = file;
        }

        public void Open()
        {
            writer = new StreamWriter(File);
            Console.WriteLine("<檔案已被鎖定>");
        }

        public void WriteData(string data)
        {
            writer.WriteLine(data);
        }

        public void Close()
        {
            if (writer == null)
                return;
            writer.Close();
            Console.WriteLine("<檔案權限已釋出>");
        }

        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: 處置受控狀態 (受控物件)
                }

                // TODO: 釋出非受控資源 (非受控物件) 並覆寫完成項
                // TODO: 將大型欄位設為 Null
                disposedValue = true;

                try
                {
                    if (writer == null)
                        return;
                }
                catch(Exception ex)
                {
                    System.Environment.Exit(System.Environment.ExitCode);
                }
                finally
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
            }
        }

        // // TODO: 僅有當 'Dispose(bool disposing)' 具有會釋出非受控資源的程式碼時，才覆寫完成項
        // ~MyDataWriter()
        // {
        //     // 請勿變更此程式碼。請將清除程式碼放入 'Dispose(bool disposing)' 方法
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // 請勿變更此程式碼。請將清除程式碼放入 'Dispose(bool disposing)' 方法
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
