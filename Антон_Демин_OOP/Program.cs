using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Round
    {
        // поля
        private double x;
        private double y;
        private double r;

        // конструктор по-умочанию
        public Round ()
        {
            this.X = 0.0;
            this.Y = 0.0;
            this.R = 5.5;
        }

        // пользовательский конструктор
        public Round(double X, double Y, double R)
        {
            this.X = X;
            this.Y = Y;
            this.R = R;
        }

        // методы 
        public double CircuitLength()
        {
            return 2 * Math.PI * R;
        }
        public double CircuitSquare()
        {
            return Math.Pow(R, 2.0) * Math.PI;
        }

        // свойства
        public double X { set; get; }
        public double Y { set; get; }
        public double R
        {
            //if (r < 0) 
            get { return r; }
            set 
            {
                if (value <= 0)
                    r = 1.0;
                else
                    r = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Round round1 = new Round(1.25, 12.4, -5);
            Round round2 = new Round();

            Console.WriteLine("пример 1. окружность round1:");
            Console.WriteLine("x = {0}", round1.X);
            Console.WriteLine("y = {0}", round1.Y);
            Console.WriteLine("r = {0}", round1.R);
            Console.WriteLine("параметры окружности заданы пользовательским конструктором Round(1.25,12.4,-5).");
            Console.WriteLine("Сойства не позволяют присваивать радиусу r отрицательные значения (в этом случае присваевается 1).");
            round1.R = 6.5;
            Console.WriteLine("При r = {0}", round1.R);
            Console.WriteLine("Длинна окружности = {0}", round1.CircuitLength());
            Console.WriteLine("Площадь круга = {0}", round1.CircuitSquare());
            Console.WriteLine();
            Console.WriteLine("пример 2. окружность round2:");
            Console.WriteLine("x = {0}", round2.X);
            Console.WriteLine("y = {0}", round2.Y);
            Console.WriteLine("r = {0}", round2.R);
            Console.WriteLine("параметры окружности заданы конструктором по-умолчанию.");
            Console.WriteLine("Длинна окружности = {0}", round2.CircuitLength());
            Console.WriteLine("Площадь круга = {0}", round2.CircuitSquare());
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }
}
