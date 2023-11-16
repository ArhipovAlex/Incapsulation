//#define CONSTRUCTORS
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
#if CONSTRUCTORS
            Point A=new Point();
            A.SetX(2);
            A.SetY(3);
            A.Print();

            A.X = 22;
            A.Y = 33;
            A.Print();

            Point B=new Point(700,800);
            B.Print();
#endif //CONSTRUCTORS

            Point A= new Point(2,3);
            Point B= new Point(7,8);
            Point C= new Point(B-A);
            A.Print();
            B.Print();
            C.Print();
            ++C;
            C.Print();
        }
    }
}
