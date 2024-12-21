using Assignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Interface
{
    public class Rectangle: IRectangle
    {
        private double height;
        private double width;

        public Rectangle(double _height, double _width)
        {
            height = _height;
            width = _width;
        }

        public double Area => height * height;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle======> Area = {Area}");
        }
    }
}
