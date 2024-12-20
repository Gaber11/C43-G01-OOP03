using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Polymorphism_OverRiding
{
    public class TypeB: TypeA
    {
        public int B { get; set; }
        public TypeB(int a , int b):base(a)
        {
            B = b;
        }
        //Override using New ==> Masking
        public new void  MyFun01()
        {
            Console.WriteLine("I am derivid [Child]");
        }
        //override using override keyword ===> Parent is public & virtual
        public override void MyFun02()
        {
            Console.WriteLine($"TypeB ==> A= {A} ,  B= {B}");
        }
    }
}
