using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Darbas
{
    public class PersonClass
    {
        protected string name;
        protected string surname;
        protected DateTime birthDate;


        public PersonClass(string name, string surname, DateTime birthDate)
        {

            if (name == "" && surname == "")
                throw new Exception("Name and surname can't be empty!");

            if (name == "")
                throw new Exception("Name can't be empty!");

            if (surname == "")
                throw new Exception("Surname can't be empty!");

            if (birthDate >= DateTime.Today)
                throw new Exception("Birthday bigger than today date!");
            if ((int)((DateTime.Now - birthDate).TotalDays / 365) < 14)
                throw new Exception("Your age less 14!");

            this.name = name;
            this.surname = surname;
            this.birthDate = birthDate;

        }

        public int GetAge()
        {
            return (int)((DateTime.Now - birthDate).TotalDays / 365);
        }

        public string GetName()
        {
            return name;
        }

        public string GetSurname()
        {
            return surname;
        }
        public String GetBirthdate()
        {
            return birthDate.ToString("yyyy/MM/dd");
        }
        public int GetDaysUntilBirthday()
        {
            int nextBirthDayYear;
            if (DateTime.Now.Month == birthDate.Month && DateTime.Now.Day >= birthDate.Day
                || DateTime.Now.Month > birthDate.Month)
            {
                nextBirthDayYear = DateTime.Now.Year + 1;

            }
            else
            {
                nextBirthDayYear = DateTime.Now.Year;
            }

            DateTime nextBirthDay = new DateTime(nextBirthDayYear, birthDate.Month, birthDate.Day);
            return (int)((nextBirthDay - DateTime.Now).TotalDays);

        }
    }
}
