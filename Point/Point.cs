using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    internal class Point
    {
        //const - константа, которая обязательно должна быть инициализирована непосредственно при объявлении
        //        const-поля автоматически статические
        //readonly - нестатическое поле, только для чтения. Существуют только в объектах
        public const int X_MAX = 1366;
        public const int Y_MAX = 768;
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
            if (x > X_MAX) x = X_MAX;
            if (x < 0) x = 0;
            this.x = x;
        }
        public void SetY(double y)
        {
            if (y > Y_MAX) y = Y_MAX;
            if (y < 0) y = 0;
            this.y = y;
        }

        //          Constructors:
        /*static Point()//статический конструктор
        {//если X(Y)_MAX были бы readonly
            X_MAX = 1366;
            Y_MAX = 768;
        }*/
        public Point(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
            Console.WriteLine("Constructor:\t" + this.GetHashCode());
        }
        public Point(Point other)
        {
            this.x = other.x;
            this.y = other.y;
            Console.WriteLine("Constructor:\t" + this.GetHashCode());
        }
        ~Point()
        {
            Console.WriteLine("Finalizer:\t" + this.GetHashCode());
        }
        //          Properties:
        public double X
        {
            get { return x; }
            set
            {
                if (value > 1366) value = 1366;
                if (value < 0) value = 0;
                x = value;
            }
        }
        public double Y
        {
            get { return y; }
            set
            {
                if (value > 768) value = 768;
                if (value < 0) value = 0;
                y = value;
            }
        }

        //          Operators:
        public static Point operator +(Point A, Point B)
        {
            return new Point(A.X + B.X, A.Y + B.Y);
        }
        public static Point operator -(Point A, Point B)
            => new Point(A.X - B.X, A.Y - B.Y);
        public static Point operator++(Point point)
        {
            point.x++;
            point.y++;
            return point;
        }
        //          Methods:
        public void Print()
        {
            Console.WriteLine($"X={x},\tY={y}");
        }
        public double Distance(Point point)
        {
            return Math.Sqrt(Math.Pow(point.x - x,2)+Math.Pow(point.y-y,2));
        }
    }
}
