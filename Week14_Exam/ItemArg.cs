using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test15
{
    public class ItemArg: EventArgs
    {
        private DateTime time;
        private int idx;

        public ItemArg(int idx)
        {
            Time = DateTime.Now;
            this.idx = idx;
        }

        public DateTime Time
        {
            get { return time; }
            private set { time = value; }
        }

        public int Index
        {
            get { return idx; }
            private set { idx = value; }
        }
    }
}
