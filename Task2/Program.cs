using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Triangle
    {
        //поля. стороны треугольника
        private double a;
        private double b;
        private double c;

        // конструктор
        public Triangle(double A, double B, double C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        // методы
        // периметр
        public double CountPerimeter()
        {
            return A + B + C;
        }

        // площадь
        public double CountSquare()
        {
            double p = CountPerimeter() / 2;
            if ((p <= A) || (p <= B) || (p <= C))
            {
                Console.WriteLine("Площадь определена неверно. Такого треугольника не существует. Введите стороны треугольника заново.");
                return 0;
            }
            else
            {
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }

        // свойства
        public double A
        {
            get { return a; }
            set
            {
                if (value <= 0)
                    a = 1;
                else
                    a = value;
            }
        }

        public double B
        {
            get { return b; }
            set
            {
                if (value <= 0)
                    b = 1;
                else
                    b = value;
            }
        }

        public double C
        {
            get { return c; }
            set
            {
                if (value <= 0)
                    c = 1;
                else
                    c = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(5, 6, 7);
            Console.WriteLine("Задаем треугольник со сторонами:");
            Console.WriteLine("A = {0}", triangle.A);
            Console.WriteLine("B = {0}", triangle.B);
            Console.WriteLine("C = {0}", triangle.C);
            Console.WriteLine("Периметр такого треугольника = {0}", triangle.CountPerimeter());
            Console.WriteLine("Площадь = {0}", triangle.CountSquare());
            Console.WriteLine("Если зададим стороны треугольника:");
            Console.WriteLine("A = {0}", triangle.A);
            Console.WriteLine("B = {0}", triangle.B);
            Console.WriteLine("C = {0}", triangle.C = 20);
            Console.WriteLine("То:");
            Console.WriteLine("Периметр такого треугольника = {0}", triangle.CountPerimeter());
            Console.WriteLine("Площадь = {0}", triangle.CountSquare());
            Console.ReadKey();
        }
    }
}
