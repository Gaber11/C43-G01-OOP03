using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.interfaces
{
    internal interface ISeries
    {
        public int Current { get; set; } // Signature for property
        public void GetNext(); //Signature for method
        public void Reset(); //Signature for method

    }
}
