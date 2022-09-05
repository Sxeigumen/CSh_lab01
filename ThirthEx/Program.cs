using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirthEx
{
    public class Point
    {
        public Point(int x, int y, string n)
        {
            coordinateX = x;
            coordinateY = y;
            figureName = n;
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

        public string getName
        {
            get
            {
                return figureName;
            }
        }

        public int coordinateX;
        public int coordinateY;
        public string figureName = "";
    }

    public class Figure
    {
        public Figure(Point p01, Point p02, Point p03, Point p04, Point p05)
        {
            p1 = p01;
            p2 = p02;
            p3 = p03;
            p4 = p04;
            p5 = p05;
        }

        public Figure(Point p01, Point p02, Point p03, Point p04)
        {
            p1 = p01;
            p2 = p02;
            p3 = p03;
            p4 = p04;
        }

        public Figure(Point p01, Point p02, Point p03)
        {
            p1 = p01;
            p2 = p02;
            p3 = p03;
        }

        public double LenghtSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.coordinateX - B.coordinateX, 2) + Math.Pow(A.coordinateY - B.coordinateY, 2));
        }
        /*
        public double PerimetrCalculator()
        {
            if(p4.figureName == "")
            {
                return LenghtSide(p1, p2) + LenghtSide(p2, p3) + LenghtSide(p3, p1);
            }
            else if(p5.figureName == "" && p4.figureName != "")
            {
                return LenghtSide(p1, p2) + LenghtSide(p2, p3) + LenghtSide(p3, p4) + LenghtSide(p4, p1);
            }
            return LenghtSide(p1, p2) + LenghtSide(p2, p3) + LenghtSide(p3, p4) + LenghtSide(p4, p5) + LenghtSide(p5, p1);

        }
        */
        public Point p1;
        public Point p2;
        public Point p3;
        public Point p4;
        public Point p5;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(0, 0, "quad");
            Point p2 = new Point(0, 5, "quad");
            Point p3 = new Point(5, 5, "quad");
            Point p4 = new Point(5, 0, "quad");

            Figure fig1 = new Figure(p1, p2, p3, p4);

            Console.WriteLine(fig1.LenghtSide(fig1.p1, fig1.p2));
            Console.WriteLine(fig1.LenghtSide(fig1.p2, fig1.p3));
            Console.WriteLine(fig1.LenghtSide(fig1.p3, fig1.p4));
            Console.WriteLine(fig1.LenghtSide(fig1.p4, fig1.p1));
            //Console.WriteLine(fig1.PerimetrCalculator());
        }
    }
}
