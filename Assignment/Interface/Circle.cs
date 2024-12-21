using Assignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Interface
{
    internal class Circle : ICircle
    {
        private double radius;

        public Circle(double _radius)
        {
            radius = _radius;
        }

      public double Area => 3.14 * radius * radius;
        
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle====>, Area = {Area}");
        }
    }

}
