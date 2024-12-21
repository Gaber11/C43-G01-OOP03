using Demo.Polymorphism_OverRiding;

namespace Demo
{
    internal class Program
    {
        #region Functions
        static int SumTwo(int X, int Y)
        {
            return X + Y;
        }
        static int SumThree(int X, int Y, int Z)
        {
            return X + Y + Z;
        }
        static double SumTwoAndDouble(double X, int Y)
        {
            return X + Y;
        } 
        #endregion

        static void Main(string[] args)
        {

            #region 2 - Polymorphism - Overloading

            //  int Result1 = SumTwo(1, 2);
            //  Console.WriteLine(Result1);

            //int  Result2 = SumThree(1, 2, 3);
            //  Console.WriteLine(Result2);

            // double Result3 = SumTwoAndDouble(1.4, 2);
            //  Console.WriteLine(Result3);
            //  Console.WriteLine(true);
            //  Console.WriteLine(1);
            //  Console.WriteLine("Gaber");
            //  Console.WriteLine();
            //  Console.WriteLine(1.5);
            //  Console.WriteLine(1.5f);
            //  Console.WriteLine(1.5m);

            #endregion

            #region 3 - Polymorphism - Overriding
            //TypeA typeA = new TypeA(10);  
            //typeA.MyFun01();
            //typeA.MyFun02();

            //TypeB typeB = new TypeB(11,30);
            //typeB.MyFun01();
            //typeB.MyFun02();




            #endregion

            #region 4 - Binding
            //reference from parent ==> object from child
            //TypeA refBase;
            //create ref from TypeA.
            //in stack [4bytes]
            //refer to null
            //refBase = new TypeB(1, 2);
            //refBase.A = 10;
            //refBase.MyFun01(); //valid [new]
            //refBase.MyFun02(); //valid [override]
             
            //refBase.B = 20; //invalid

            
            
            
            
            
            
            #endregion

        }
    }
}
