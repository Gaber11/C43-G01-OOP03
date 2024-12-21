using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Polymorphism_OverRiding
{
    //TypeA is the direct parent for TypeB
    public class TypeB: TypeA
    {
        public int B { get; set; }
        public TypeB(int a , int b):base(a)
        {
            B = b;
        }
        //Override using New ==> Masking
        //Override using new --> static Binding [Early binding]
        //Compilation Time:Compiler will bind method call based on reference type not object type
        //RunTime: CLR will bind method call based on object type not ref type
        //

        public new void  MyFun01()
        {
            Console.WriteLine("I am derivid [Child]");
        }
        //override using override keyword ===> Parent is public & virtual
        //Override with override keyword --> dynamic binding [late binding
        public override void MyFun02()
        {
            Console.WriteLine($"TypeB ==> A= {A} ,  B= {B}");
        }
    }
}
