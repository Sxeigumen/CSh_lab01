using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirthEx
{
    public class Point
    {
        public Point(int x, int y)
        {
            coordinateX = x;
            coordinateY = y;
        }

        public int getX
        {
            get
            {
                return coordinateX;
            }
        }

        public int getY
        {
            get
            {
                return coordinateY;
            }
        }

        public int coordinateX;
        public int coordinateY;
    }

    public class Figure
    {
        public Figure(Point p01, Point p02, Point p03, Point p04, Point p05, string str)
        {
            p1 = p01;
            p2 = p02;
            p3 = p03;
            p4 = p04;
            p5 = p05;
            FigureName = str;
        }

        public Figure(Point p01, Point p02, Point p03, Point p04, string str)
        {
            p1 = p01;
            p2 = p02;
            p3 = p03;
            p4 = p04;
            FigureName = str;
        }

        public Figure(Point p01, Point p02, Point p03, string str)
        {
            p1 = p01;
            p2 = p02;
            p3 = p03;
            FigureName = str;
        }

        public double LenghtSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.coordinateX - A.coordinateX, 2) + Math.Pow(B.coordinateY - A.coordinateY, 2));
        }
       
        public void PerimetrCalculator()
        {
            if(p4 == null)
            {
                Perimetr = LenghtSide(p1, p2) + LenghtSide(p2, p3) + LenghtSide(p3, p1);
            } else if(p4 != null && p5 == null)
            {
                Perimetr = LenghtSide(p1, p2) + LenghtSide(p2, p3) + LenghtSide(p3, p4) + LenghtSide(p4, p1);
            }
            else
            {
                Perimetr = LenghtSide(p1, p2) + LenghtSide(p2, p3) + LenghtSide(p3, p4) + LenghtSide(p4, p5) + LenghtSide(p5, p1);
            }
        }
        
        public Point p1;
        public Point p2;
        public Point p3;
        public Point p4;
        public Point p5;
        public string FigureName;
        public double Perimetr;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 5);
            Point p3 = new Point(5, 5);
            Point p4 = new Point(5, 0);

            Figure fig1 = new Figure(p1, p2, p3, p4, "Квадрат 5X5");

            Console.WriteLine(fig1.FigureName);

            Console.WriteLine("Сторона 1 = " + fig1.LenghtSide(fig1.p1, fig1.p2));
            Console.WriteLine("Сторона 2 = " + fig1.LenghtSide(fig1.p2, fig1.p3));
            Console.WriteLine("Сторона 3 = " + fig1.LenghtSide(fig1.p3, fig1.p4));
            Console.WriteLine("Сторона 4 = " + fig1.LenghtSide(fig1.p4, fig1.p1));

            fig1.PerimetrCalculator();

            Console.WriteLine("Периметр = " + fig1.Perimetr);
        }
    }
}
