using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Polymorphism_OverRiding
{
    //TypeA ====> indirect Parent
    //TypeB ====> indirect Parent
    //TypeC ====> direct Parent

    public class TypeD : TypeC
    {

        public int D { get; set; }

        public TypeD(int a , int b, int c, int d) :base(a,b,c)
        {
            D = d;

        }
        public new void MyFun01()
        {
            Console.WriteLine("I am a derived [child of grand child]");


        }
        //new ===> End of sequance 
        //virtual ===> Start of new sequance
        public new  virtual void MyFun02()
        {
            Console.WriteLine($"TypeD ==> A : {A} , B: {B} , C : {C} , D : {D}");

        }

    }
}
