using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondEx
{
    public class Rectangle
    {
        public Rectangle()
        {
            side1 = 0;
            side2 = 0;
        }

        public Rectangle(double sideA, double sideB)
        {
            side1 = sideA;
            side2 = sideB;
        }

        public double AreaCalculator()
        {
            return side1 * side2;
        }

        public double PerimetrCalculator()
        {
            return 2 * side1 + 2 * side2;
        }

        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }

        public double Perimetr
        {
            get
            {
                return PerimetrCalculator();
            }
        }

        public double side1;
        public double side2;
    }
    class Program
    {
        static void Main(string[] args)
        {
            double firstSide;
            double secondSide;

            Console.WriteLine("Введите размер первой стороны: ");
            double.TryParse(Console.ReadLine(), out firstSide);

            Console.WriteLine("Введите размер второй стороны: ");
            double.TryParse(Console.ReadLine(), out secondSide);

            Rectangle r1 = new Rectangle(firstSide, secondSide);

            Console.WriteLine("Площадь прямоугольник равна {0}", r1.Area);
            Console.WriteLine("Периметр прямоугольник равен {0}", r1.Perimetr);

        }
    }
}
