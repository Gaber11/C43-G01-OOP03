using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Polymorphism_OverRiding
{
    //TypeC : direct parent [TypeB]
    //TypeC : indirect parent [TypeA]

    public class TypeC : TypeB
    {
        public int C { get; set; }
        public TypeC(int a, int b, int c) : base(a, b)
        {
            C = c;
        }
        public new void MyFun01()
        {
            Console.WriteLine("I am derivid [Grand child]");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"TypeC ==> A : {A} , B: {B} , C : {C}");
        }
    }
}
