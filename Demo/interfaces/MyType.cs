using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.interfaces
{

    //class : class ==>inhiret
    // struct : interface ==> implement
    // class : interface ==> implement
    //interface : interface ==>inhiret

    internal class MyType : IMyType
    {
        //Automatic property [ will generate backing field]
        public int Id { get ; set ; }
         
        public void MyFun(int X)
        {
            Console.WriteLine($" MYType ===> X= {X}");
        }
    }
}
