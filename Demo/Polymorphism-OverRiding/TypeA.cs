using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Polymorphism_OverRiding
{
    //
    public class TypeA
    {
        public TypeA(int a)
        {
            A = a;
        }

        public int A { get; set; }
        //project member method
        public void MyFun01()
        {

           Console.WriteLine("I am base [Parent]");
        }
      
        
        //object member method
        public virtual void MyFun02()
        {

            Console.WriteLine($"TypeA===> A = {A}");
        }

    }
}
