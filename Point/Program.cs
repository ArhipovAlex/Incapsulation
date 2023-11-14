using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point A=new Point();
            A.SetX(2);
            A.SetY(3);
            A.Print();

            A.X = 22;
            A.Y = 33;
            A.Print();
        }
    }
}
