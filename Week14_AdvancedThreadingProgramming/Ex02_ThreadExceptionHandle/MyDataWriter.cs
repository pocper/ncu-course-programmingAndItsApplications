using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Ex02_DeadLock
{
    public class MyDataWriter: IDisposable
    {
        StreamWriter sw = null;
        string filePath = null;
        public MyDataWriter(string path)
        {
            this.filePath = path;
        }

        public void Open()
        {            
            sw = new StreamWriter(filePath);           
        }

        public void WriteData(string data)
        {
            sw.WriteLine(data);
        }

        public void Close()
        {
            sw.Close();
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
                    if(sw != null)
                    {
                        sw.Close();
                    }
                    sw.Dispose();
                }
                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        ~MyDataWriter()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(false);
        }

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
