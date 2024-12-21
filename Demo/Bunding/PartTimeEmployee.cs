using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Bunding
{
    public class PartTimeEmployee : Employee
    {
        public int CountOfHours { get; set; }
        public double HourRate { get; set; }
        public new void GetEmployeeType()
        {
            Console.WriteLine("I am part Time Employee ");


        }
        public override void GetEmployeeData()
        {
            Console.WriteLine($"PartTime Employee ==> Id: {Id} , Name: {Name} , Age: {Age} ,CountOfHours: {CountOfHours} , HourRate : {HourRate} ");
        }

    }
}
