using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt8
{
    internal class RabotnikDet : Rabotnik, IHuman, IComparable, ICloneable
    {
        protected int _childrens;
        public int Childrens
        {
            get => _childrens;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Значение не может быть отрицательным или быть равным 0");
                }
                _childrens = value;
            }
        }
        public RabotnikDet()
        {

        }
        public RabotnikDet(string firstName, string lastName, int age, string pol, string dolzhnost, int childrens)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Pol = pol;
            Dolzhnost = dolzhnost;
            Childrens = childrens;
        }
        public new string GetInfo()
        {
            return $"Имя работника {FirstName}\nФамилия работника {LastName}\nВозраст работника {Age}\nПол:{Pol}\nЗанимаемая должность: {Dolzhnost}\nКол-во детей {Childrens}";
        }

        public new object Clone()
        {
            RabotnikDet clone = new RabotnikDet();
            clone.FirstName = this.FirstName;
            clone.LastName = this.LastName;
            clone.Pol = this.Pol;
            clone.Age = this.Age;
            clone.Dolzhnost = this.Dolzhnost;
            clone.Childrens = this.Childrens;
            return clone;
        }
    }
}
