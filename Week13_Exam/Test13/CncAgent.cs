using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCU.ME;

namespace Test13
{
    public class CncAgent : IDisposable
    {
        CncSimulator simulator = null;

        string IP;
        int PORT;
        int Count;

        public int spd = 0;
        public int temp = 0;
        public int sec = 0;
        public short h = 0;
        public CncAgent(string ip, int port)
        {
            IP = ip;
            PORT = port;
        }

        public bool Connect()
        {
            int ec;
            simulator = new CncSimulator();
            ec = simulator.AllocHandle(IP, PORT, ref h);
            return ec == 0;
        }
        public void GetSpeed()
        {
            simulator.GetSpeed(h, ref spd);
        }

        public void GetTemp()
        {
            simulator.GetTemperature(h, ref temp);
        }

        public void GetRuntime()
        {
            simulator.GetRuntime(h, ref sec);
        }

        public void SetDisconnect(int count)
        {
            Count = count;
        }


        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)//只操作一次
            {
                if (disposing)//手動
                {
                    // TODO: 處置受控狀態 (受控物件)
                    Console.WriteLine("Disconnected");
                    try
                    {
                        for (short i = 1; i < Count+1; i++)
                        {
                            simulator.ReleaseHandle(i);
                            Console.WriteLine("Releasing Handle " + i);
                        }
                    }
                    catch
                    {
                        Console.WriteLine(string.Format("{0} Connection Failed", DateTime.Now));
                    }
                }

                // TODO: 釋出非受控資源 (非受控物件) 並覆寫完成項
                // TODO: 將大型欄位設為 Null

                Console.WriteLine("dispose unmanaged object");
                disposedValue = true;
            }
        }

        // // TODO: 僅有當 'Dispose(bool disposing)' 具有會釋出非受控資源的程式碼時，才覆寫完成項
        ~CncAgent()
        {
            // 請勿變更此程式碼。請將清除程式碼放入 'Dispose(bool disposing)' 方法
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // 請勿變更此程式碼。請將清除程式碼放入 'Dispose(bool disposing)' 方法
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
