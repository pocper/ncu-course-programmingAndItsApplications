using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace UsingSQLite
{
    class Program
    {

        public delegate int CallBack(IntPtr pData, int columenCount, string[] columnValue, string[] columnName);

        [DllImport("sqlite3.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int sqlite3_open(string filename, out IntPtr ppDb_handle);

        [DllImport("sqlite3.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int sqlite3_close(IntPtr ppDb);
        [DllImport("sqlite3.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int sqlite3_exec(IntPtr ppDb, string sql, IntPtr callback, IntPtr callback_ptr, out string err_msg);

        [DllImport("sqlite3.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void sqlite3_free(IntPtr p);

        static void Main(string[] args)
        {
            IntPtr db = IntPtr.Zero;
            int rc;
            string file = "week16.db";
            string sqlQuery = "Insert into record Values ('Agesdger','45') ";
            string err_msg;

            rc = sqlite3_open(file, out db);
            if (rc != 0)
                sqlite3_close(db);

            rc = sqlite3_exec(db, sqlQuery, IntPtr.Zero, IntPtr.Zero, out err_msg);

            if (rc != 0)
            {
                sqlite3_free(db);
                Console.WriteLine(err_msg);
                Console.ReadKey();
            }

            sqlite3_close(db);

            return;

        }


    }
}
