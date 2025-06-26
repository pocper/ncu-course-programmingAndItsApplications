using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ex03_DeadLock
{
    public class Account
    {
        /// <summary>
        /// 餘額
        /// </summary>
        int Balance = 1000;

        /// <summary>
        /// 帳號
        /// </summary>
        string ID;

        public Account(string id, int init_balance)
        {
            this.Balance = init_balance;
            this.ID = id;
        }

        /// <summary>
        /// 提款
        /// </summary>
        /// <param name="amount">提款金額</param>
        /// <returns>剩餘金額</returns>
        public int Withdraw(int amount)
        {
            var thrdId = Thread.CurrentThread.ManagedThreadId;
            System.Threading.Thread.Sleep(1000);
            this.Balance -= amount;

            Console.WriteLine(string.Format("Thrd#{3}: 從帳戶{0}提出{1}, 餘額:{2}", this.ID, amount, this.Balance, thrdId));
            return this.Balance;
        }

        /// <summary>
        /// 存款
        /// </summary>
        /// <param name="amount">存款金額</param>
        /// <returns>剩餘金額</returns>
        public int Deposit(int amount)
        {
            var thrdId = Thread.CurrentThread.ManagedThreadId;
            System.Threading.Thread.Sleep(1000);
            this.Balance += amount;

            Console.WriteLine(string.Format("Thrd#{3}: 從帳戶{0}存入{1}, 餘額:{2}", this.ID, amount, this.Balance, thrdId));
            return this.Balance;
        }

        /// <summary>
        /// 轉帳
        /// </summary>
        /// <param name="from">轉出帳戶</param>
        /// <param name="to">轉入帳戶</param>
        /// <param name="amount">轉帳金額</param>
        public static void Transfer(Account from, Account to, int amount)
        {
            var thrdId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine(string.Format("Thrd#{3}: 預備從帳戶{0}轉帳到帳戶{1}，轉帳金額{2}", from.ID, to.ID, amount, thrdId));
            Console.WriteLine(string.Format("Thrd#{1}: 預備lock 資源: {0}", from.ID, thrdId));
            lock (from)
            {
                Console.WriteLine(string.Format("Thrd#{1}: 已經lock 資源: {0}", from.ID, thrdId));

                Console.WriteLine(string.Format("Thrd#{1}: 預備lock 資源: {0}", to.ID, thrdId));
                lock (to)
                {
                    Console.WriteLine(string.Format("Thrd#{1}: 已經lock 資源: {0}", to.ID, thrdId));
                    from.Withdraw(amount);
                    to.Deposit(amount);

                }
                Console.WriteLine(string.Format("Thrd#{1}: unlock 資源: {0}", to.ID, thrdId));
            }
            Console.WriteLine(string.Format("Thrd#{1}: unlock 資源: {0}", from.ID, thrdId));

            Console.WriteLine(string.Format("Thrd#{3}: 完成從帳戶{0}轉帳到帳戶{1}，轉帳金額{2}", from.ID, to.ID, amount, thrdId));
        }

    }
}
