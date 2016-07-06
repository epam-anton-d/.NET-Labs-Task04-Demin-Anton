using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Employer : User
    {
        private int  experience;
        private string position;

        public int Experience { set; get; }
        public string Position { set; get; }

        public Employer(string Familia, string Imya, string Otchestvo, DateTime Birthday, int Experience, string Position)
        {
            this.Familia = Familia;
            this.Imya = Imya;
            this.Otchestvo = Otchestvo;
            this.Birthday = Birthday;
            this.Experience = Experience;
            this.Position = Position;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employer employer = new Employer("Сидоров", "Иван", "Петрович", new DateTime(1988, 10, 14), 8, "Программист");
            Console.WriteLine("Привет!");
            Console.WriteLine("У меня есть знакомый, его зовут {0}.", employer.Imya);
            Console.WriteLine("Его полное имя {0} {1} {2}.", employer.Familia, employer.Imya, employer.Otchestvo);
            Console.WriteLine("А сокращенное: {0}", employer.ShowShortInitials());
            Console.WriteLine("{0}у {1} лет, он {2}", employer.Imya, employer.Age, employer.IsOfAge());
            Console.WriteLine("Он работает {0}ом", employer.Position);
            Console.WriteLine("Его опыт в этой сфере {0} лет", employer.Experience);
            Console.WriteLine("Нажмите клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
