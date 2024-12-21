using Demo.Bunding;
using Demo.interfaces;
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

        static void ProcessEmployee(Employee employee)
        {
            if (employee is not null)
            {
                employee.GetEmployeeType(); //Parent
                employee.GetEmployeeData(); //FullTimeEmployee
            }

        }
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

            #region 5 - Not Binding
            //Reference from child ==> Object from parent [casting]
            //Not Binding
            //TypeB typeB = (TypeB)new TypeA(1);
            //Binding
            //TypeA typeA = new TypeB(1, 2);
            //TypeB typeB1 = (TypeB) typeA;  //valid [Assign object from TypeB to reference from 


            #endregion

            #region 6 - Binding Ex 1
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(1, "Gaber", 20, 2000);
            //Console.WriteLine(fullTimeEmployee);
            //ProcessEmployee(fullTimeEmployee);

            //// PartTimeEmployee partTimeEmployee = new PartTimeEmployee();


            ////Object intializer  .NET 6 Features
            //PartTimeEmployee partTimeEmployee1 = new PartTimeEmployee()
            //{
            //    Id = 10,
            //    Name = "Gaber",
            //    Age = 22,
            //    CountOfHours = 20,
            //    HourRate = 19.2

            //};

            //ProcessEmployee(partTimeEmployee1);

            #endregion

            #region 7 - Binding Ex 2
            //TypeB typeB = new TypeC(1, 2, 3); //TypeB is direct parent for TypeC
            //typeB.MyFun01(); // i am child
            //typeB.MyFun02(); //TypeC ==> A,B,C
            //typeB.A = 20;
            //typeB.B = 80;
            // typeB.C = 8;   // Invalid

            //TypeA typeA = new TypeC(5,4,7); //typeA is indirect Parnet of TypeC
            //typeA.MyFun01(); //I am Parent ==> static binding
            //typeA.MyFun02(); // TypeC ==> A,B,C ==> dynamic b
            //typeA.A = 20;
            //typeA.B = 7; //Invalid
            //typeA.C = 9; //Invalid
            //===================================

            //TypeA typeA = new TypeE(1,2,3,4,5);
            //TypeB typeB = new TypeE(1,2,3,4,5);
            //TypeC typeC = new TypeE(1,2,3,4,5);
            //typeA.MyFun01(); //I am Parent
            //typeA.MyFun02(); // TypeC
            //Console.WriteLine("===================================");
            //typeB.MyFun01(); //I am child
            //typeB.MyFun02(); //Type C
            //Console.WriteLine("===================================");

            //typeC.MyFun01(); // I am grand child
            //typeC.MyFun02(); //TypeC

            // TypeD typeD = new TypeE(1, 2, 3, 4, 5);
            // typeD.MyFun01(); //I am child of grand child
            // typeD.MyFun02(); //TypeE [A,B,C,D,E]


            #endregion

            #region 8 - Interface
            // is a code contract between 2 developer
            //  IMyType myType = new IMyType();  ==> invalid
            //You can not create object from interface

          //  IMyType myType; //creation reference
            //Reference located in stack [4bytes]

            //Reference from interface can refer to object from class or struct that implemented

            //IMyType mytype = new MyType();
            //mytype.Id = 10;
            //mytype.MyFun(10);
            //mytype.Print(); //Only way to access defualt implemented method




            #endregion

        }
    }
}
