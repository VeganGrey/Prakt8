using System;

namespace Prakt8
{
    internal class Rabotnik : IHuman, IComparable, ICloneable
    {
        protected int _age;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age
        {
            get => _age;
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Значение не может быть отрицательным или быть равным 0");
                }
                _age = value;
            }
        }
        public string Pol { get; set; }
        public string Dolzhnost { get; set; }
        public Rabotnik()
        {

        }
        public Rabotnik(string firstName, string lastName, int age, string pol, string dolzhnost)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Pol = pol;
            Dolzhnost = dolzhnost;
        }

        public string GetInfo()
        {
            return $"Имя работника {FirstName}\n Фамилия работника {LastName}\n Возраст работника {Age}\n Пол:{Pol}\n Занимаемая должность: {Dolzhnost}";
        }

        public int CompareTo(object obj)
        {
            Rabotnik temp = (Rabotnik)obj;
            if (this.LastName != temp.LastName) return -1;
            if (this.LastName == temp.LastName) return 0;
            return -1;
        }

        public Rabotnik ShallowClone()
        {
            return (Rabotnik)this.MemberwiseClone();
        }

        public object Clone()
        {
            Rabotnik clone = new Rabotnik(this.FirstName, this.LastName, this.Age, this.Pol, this.Dolzhnost);
            return clone;
        }
    }
    
}
