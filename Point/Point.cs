using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    internal class Point
    {
        double x;
        double y;
        public double GetX()
        {
            return x; 
        }
        public double GetY() 
        {
            return y;
        }
        public void SetX(double x) 
        {
            this.x = x;
        }
        public void SetY(double y) 
        {
            this.y = y;
        }

        //          Properties:
        public double X
        { 
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        //          Methods:
        public void Print()
        {
            Console.WriteLine($"X={x},\tY={y}");
        }
    }
}
