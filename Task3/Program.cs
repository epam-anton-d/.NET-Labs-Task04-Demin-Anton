using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{    
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Сидоров", "Иван", "Петрович", new DateTime(1988, 10, 14));
            Console.WriteLine("Привет!");
            Console.WriteLine("У меня есть знакомый, его зовут {0}.", user.Imya);
            Console.WriteLine("Его полное имя {0} {1} {2}.", user.Familia, user.Imya, user.Otchestvo);
            Console.WriteLine("А сокращенное: {0}", user.ShowShortInitials());
            Console.WriteLine("{0}у {1} лет, он {2}", user.Imya, user.Age, user.IsOfAge());
            Console.WriteLine("Нажмите клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
