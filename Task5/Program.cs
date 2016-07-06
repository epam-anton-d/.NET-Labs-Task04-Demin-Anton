using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Line
    {
        private double x1;
        private double y1;
        private double x2;
        private double y2;
        private const string figureType = "Линия";

        public double X1 { set; get; }
        public double Y1 { set; get; }
        public double X2 { set; get; }
        public double Y2 { set; get; }

        public Line(double X1, double Y1, double X2, double Y2)
        {
            this.X1 = X1;
            this.Y1 = Y1;
            this.X2 = X2;
            this.Y2 = Y2;
        }

        public void Draw(double x1, double y1, double x2, double y2)
        {
            Console.WriteLine("Я рисую линию, соединяющую две точки (x1; y1) = ( {0}; {1} ) и (x2; y2) = ( {2}; {3} )", x1, y1, x2, y2);
        }

        public void ShowTypeAndParameters()
        {
            Console.WriteLine("Тип фигуры {0}", figureType);
            Console.WriteLine("Координаты первой точки ( {0}; {1} )", X1, Y1);
            Console.WriteLine("Координаты второй точки ( {0}; {1} )", X2, Y2);
        }

    }

    class Round
    {
        private double x1;
        private double y1;
        private double r;
        private const string figureType = "Окружность";

        public double X1 { set; get; }
        public double Y1 { set; get; }
        public double R { set; get; }

        public Round(double X1, double Y1, double R)
        {
            this.X1 = X1;
            this.Y1 = Y1;
            this.R = R;
        }

        public void Draw(double x1, double y1, double r)
        {
            Console.WriteLine("Я рисую Окружность, при заданном центре (x1; y1) = ( {0}; {1} ) и радиусе r = {2} )", X1, Y1, R);
        }

        public void ShowTypeAndParameters()
        {
            Console.WriteLine("Тип фигуры {0}", figureType);
            Console.WriteLine("Координаты центра окружности ( {0}; {1} )", X1, Y1);
            Console.WriteLine("Радиус r = {0}", R);
        }
    }

    class Rectangle
    {
        private double x1;
        private double y1;
        private double x2;
        private double y2;
        private const string figureType = "Прямоугольник";

        public double X1 { set; get; }
        public double Y1 { set; get; }
        public double X2 { set; get; }
        public double Y2 { set; get; }

        public Rectangle(double X1, double Y1, double X2, double Y2)
        {
            this.X1 = X1;
            this.Y1 = Y1;
            this.X2 = X2;
            this.Y2 = Y2;
        }

        public void Draw(double x1, double y1, double x2, double y2)
        {
            Console.WriteLine("Я рисую четыре линии - стороны прямоугольника (x1; y1) = ( {0}; {1} ) и (x2; y2) = ( {2}; {3} )", x1, y1, x2, y2);
            Console.WriteLine("Первая линия (x1; y1) = ( {0}; {1} ), (x2, y1) = ( {2}; {1} )", X1, Y1, X2);
            Console.WriteLine("Вторая линия (x2; y1) = ( {0}; {1} ), (x2, y2) = ( {0}; {2} )", X2, Y1, Y2);
            Console.WriteLine("Третья линия (x2; y2) = ( {0}; {1} ), (x1, y2) = ( {2}; {1} )", X2, Y2, X1);
            Console.WriteLine("Четвертая линия (x1; y2) = ( {0}; {1} ), (x1, y1) = ( {0}; {2} )", X1, Y2, Y1);
        }

        public void ShowTypeAndParameters()
        {
            Console.WriteLine("Тип фигуры {0}", figureType);
            Console.WriteLine("Координаты первой точки ( {0}; {1} )", X1, Y1);
            Console.WriteLine("Координаты второй точки ( {0}; {1} )", X2, Y2);
        }
    }

    class Circle
    {
        private double x1;
        private double y1;
        private double r;
        private string color;
        private const string figureType = "Круг";

        public double X1 { set; get; }
        public double Y1 { set; get; }
        public double R { set; get; }
        public string Color { set; get; }

        public Circle(double X1, double Y1, double R, string Color)
        {
            this.X1 = X1;
            this.Y1 = Y1;
            this.R = R;
            this.Color = Color;
        }

        public void Draw(double x1, double y1, double r, string color)
        {
            Console.WriteLine("Я рисую круг с заданным центром (x1; y1) = ( {0}; {1} ) , радиусом r = {2} и заданного цвета {3} )", X1, Y1, R, Color);
        }

        public void ShowTypeAndParameters()
        {
            Console.WriteLine("Тип фигуры {0}", figureType);
            Console.WriteLine("Координаты центра окружности ( {0}; {1} )", X1, Y1);
            Console.WriteLine("Радиус r = {0}", R);
            Console.WriteLine("Цвет {0}", Color);
        }
    }

    class Ring
    {
        private double x1;
        private double y1;
        private double rBig;
        private double rSmall;
        private string color;
        private const string figureType = "Кольцо";

        public double X1 { set; get; }
        public double Y1 { set; get; }
        public double RBig { set; get; }
        public double RSmall { set; get; }
        public string Color { set; get; }

        public Ring(double X1, double Y1, double RBig, double RSmall, string Color)
        {
            this.X1 = X1;
            this.Y1 = Y1;
            this.RBig = RBig;
            this.RSmall = RSmall;
            this.Color = Color;
        }

        public void Draw(double x1, double y1, double rBig, double rSmall, string color)
        {
            Console.WriteLine("Я рисую кольцо с заданным центром (x1; y1) = ( {0}; {1} ) , радиусом внешней окружности r1 = {2},\nзаданного цвета {3} ", X1, Y1, RBig, Color);
            Console.WriteLine("и внутренней окружности сцентром в той же точке (x1; y1) = ( {0}; {1} ) и радиусом r2 = {2} )", X1, Y1, RSmall, Color);
        }

        public void ShowTypeAndParameters()
        {
            Console.WriteLine("Тип фигуры {0}", figureType);
            Console.WriteLine("Координаты центра окружности ( {0}; {1} )", X1, Y1);
            Console.WriteLine("Радиус внешней окружности r1 = {0}", RBig);
            Console.WriteLine("Радиус внутренней окружности r1 = {0}", RSmall);
            Console.WriteLine("Цвет {0}", Color);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Line line = new Line(3.5, 4.8, 5.3, -7.1);
            Console.WriteLine("Пример рисования линии. Метод Draw");
            line.Draw(3.5, 4.8, 5.3, -7.1);
            Console.WriteLine();
            Console.WriteLine("Параметры фигуры");
            line.ShowTypeAndParameters();
            Console.WriteLine();

            Round round = new Round(4.3, 5.2, 8.1);
            Console.WriteLine("Пример рисования окружности. Метод Draw");
            round.Draw(4.3, 5.2, 8.1);
            Console.WriteLine();
            Console.WriteLine("Параметры фигуры");
            round.ShowTypeAndParameters();
            Console.WriteLine();

            Rectangle rectangle = new Rectangle(3.2, 4.8, 4.1, -1.2);
            Console.WriteLine("Пример рисования прямоугольника. Метод Draw");
            rectangle.Draw(3.2, 4.8, 4.1, -1.2);
            Console.WriteLine();
            Console.WriteLine("Параметры фигуры");
            rectangle.ShowTypeAndParameters();
            Console.WriteLine();

            Circle circle = new Circle(1.8, 2.6, 6.3, "Red");
            Console.WriteLine("Пример рисования круга. Метод Draw");
            circle.Draw(1.8, 2.6, 6.3, "Red");
            Console.WriteLine();
            Console.WriteLine("Параметры фигуры");
            circle.ShowTypeAndParameters();
            Console.WriteLine();

            Ring ring = new Ring(4.5, 3.8, 7.3, 2.3, "White");
            Console.WriteLine("Пример рисования кольца. Метод Draw");
            ring.Draw(4.5, 3.8, 7.3, 2.3, "White");
            Console.WriteLine();
            Console.WriteLine("Параметры фигуры");
            ring.ShowTypeAndParameters();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
