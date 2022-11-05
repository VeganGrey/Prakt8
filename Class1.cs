using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt8
{
    internal class Rabotnik : Ihuman, IComparable,ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Pol { get; set; }
        public string Dolzhnost { get; set; }

        public Rabotnik()
        {
            FirstName = "Пусто";
            LastName = "Пусто";
            Age = 0;
            Pol = "Пусто";
            Dolzhnost = "Пусто";
        }
        public Rabotnik(string firstName, string lastName, int age, string pol, string dolzhnost)
        {
            FirstName = firstName;
            LastName = lastName;
            //if (pol != "М" || pol != "Ж") throw new ArgumentException();
            if (pol == "М") Pol = "Мужской";
            if (pol == "Ж") Pol = "Женский";
            if (Pol != "Мужской" && Pol != "Женский") throw new ArgumentException();
            if (age > 16) Age = age;
            else throw new ArgumentException();
            Dolzhnost = dolzhnost;
        }

        public string GetInfo()
        {
            string info = "";
            info = $"Имя работника {FirstName}\n Фамилия работника {LastName}\n Возраст работника {Age}\n Пол:{Pol}\n Занимаемая должность: {Dolzhnost}";
            return info;
        }

        public int CompareTo(object obj)
        {
            Rabotnik temp = (Rabotnik)obj;
            if(this.LastName != temp.LastName) return -1;
            if(this.LastName == temp.LastName) return 0;
            return -1;
        }

        public Rabotnik ShallowClone()
        {
            return (Rabotnik)this.MemberwiseClone();
        }

        public object Clone()
        {
            Rabotnik clone = new Rabotnik(this.FirstName,this.LastName,this.Age,this.Pol,this.Dolzhnost);
            return clone;
        }
    }
    internal class RabotnikDet : Rabotnik,Ihuman,IComparable,ICloneable
    {
        public int Childrens { get ; set; }
        public RabotnikDet(string firstName, string lastName, int age, string pol, string dolzhnost,int childrens)
        {
            FirstName = firstName;
            LastName = lastName;
            //if (pol != "М" || pol != "Ж") throw new ArgumentException();
            if (pol == "М") Pol = "Мужской";
            if (pol == "Ж") Pol = "Женский";
            if (Pol != "Мужской" && Pol != "Женский") throw new ArgumentException();
            if (age > 16) Age = age;
            else throw new ArgumentException();
            Dolzhnost = dolzhnost;
            Childrens = childrens;
        }

        public new string GetInfo()
        {
            string info = "";
            info = $"Имя работника {FirstName}\n Фамилия работника {LastName}\n Возраст работника {Age}\n Пол:{Pol}\n Занимаемая должность: {Dolzhnost}\n Кол-во детей {Childrens}";
            return info;
        }

        public new object Clone()
        {
            RabotnikDet clone = new RabotnikDet(this.FirstName,this.LastName,this.Age,this.Pol,this.Dolzhnost,this.Childrens);
            return this;
        }
    }
}
