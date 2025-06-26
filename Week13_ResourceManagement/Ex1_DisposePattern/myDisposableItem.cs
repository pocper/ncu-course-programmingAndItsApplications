x   using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Ex1_DisposePattern
{
    public class MyDisposableItem : IDisposable
    {
        #region managed objects
        List<int> myValue = new List<int>(5);
        #endregion

        #region unmanaged objects
        IntPtr ptr = Marshal.AllocHGlobal(100);
        #endregion

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    myValue.Clear();
                    myValue = null;
                    Console.WriteLine("dispose managed object");
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.
                Marshal.FreeHGlobal(ptr);
                Console.WriteLine("dispose unmanaged object");
                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        ~MyDisposableItem()
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
            // GC.SuppressFinalize(this);
        }
        #endregion

    }
}
