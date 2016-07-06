using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class User
    {
        // Поля.
        private string familia;
        private string imya;
        private string otchestvo;
        private DateTime birthday;// = new DateTime(2015, 7, 20);
        private DateTime age;// = DateTime.Today - birthday;

        // Конструктор.
        public User(string Familia, string Imya, string Otchestvo, DateTime Birthday)
        {
            this.Familia = Familia;
            this.Imya = Imya;
            this.Otchestvo = Otchestvo;
            this.Birthday = Birthday;
        }

        // Методы.
        public string ShowShortInitials()
        {
            return Familia + " " + Imya[0] + "." + Otchestvo[0] + ".";
        }

        public string IsOfAge()
        {
            if (Age >= 18)
                return "совершеннолетний";
            else
                return "не совершеннолетний";
        }

        // Свойства.
        public string Familia { get; set; }
        public string Imya { get; set; }
        public string Otchestvo { get; set; }
        public DateTime Birthday
        {
            get { return birthday; }
            set
            {
                if (value < DateTime.Today)
                {
                    birthday = value;
                }
                else
                {
                    birthday = DateTime.Today;
                }
                Age = Birthday.Year;
            }

        }
        public int Age { private set; get; }
    }
}
