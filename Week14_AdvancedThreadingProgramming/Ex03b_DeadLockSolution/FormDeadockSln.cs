using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Ex03_DeadLock
{
    public partial class FormDeadockSln : Form
    {
        Account A = new Account("101", 1000);
        Account B = new Account("109", 1000);
        public FormDeadockSln()
        {
            InitializeComponent();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            Task taskA = new Task(
                () =>
                {
                    for(int i=0;i<10;i++)
                        Account.Transfer(A, B, 100);
                }
                );
            Task taskB = new Task(
                () =>
                {
                    for (int i = 0; i < 10; i++)
                        Account.Transfer(B, A, 10);
                }
                );
            taskB.Start();
            taskA.Start();
            
        }

    }
}
