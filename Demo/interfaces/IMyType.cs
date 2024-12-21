using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.interfaces
{
    //Access modifier : internal[defualt] - public
    //Access modifier inside interface :All allowed except Private

    //by default in interface is public 
    //What you can write inside the interfac?
    //1.signature for method 

    //2.signature for property
    //3.Default implemented method  [C# 8.0]
    internal interface IMyType
    {
        public int Id { get; set; }
        //inside class , struct ===> Automatic property [compiler will generate]
        //inside interface ===> Signature for property

        //2.signature for property
        public void MyFun(int X);

        //3.Default implemented method  [C# 8.0]
        void Print()
        {
            Console.WriteLine("Hello from Defualt implemnted method");
        }

    }
}
