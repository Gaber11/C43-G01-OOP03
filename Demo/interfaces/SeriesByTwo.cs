﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.interfaces
{
    internal class SeriesByTwo : ISeries
    {
        public int Current { get ; set; }

        public void GetNext()
        {
            Current += 2;
        }

        public void Reset()
        {
            Current = 0;
        }
    }
}
