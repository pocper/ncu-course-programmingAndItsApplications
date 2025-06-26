using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02_EventHandler
{
    public class NumberArgs: EventArgs
    {
        public DateTime DateTime = DateTime.Now;
        public int Value;
    }
}
