using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Discipline
    {
        private string subject;
        private int grade;
        private int hoursOfDiscipline;

        public string Subject
        {
            get { return subject; }
            set
            {
                if (string.IsNullOrEmpty(subject))
                {
                    throw new ArgumentException("Название предмета не может быть пустым");
                }
                subject = value;
            }
        }
        public int Grade
        {
            get { return grade; }
            set
            {
                if (grade < 1 ||  grade > 5)
                {
                    throw new ArgumentException("Оценка должна быть от 1 до 5");
                }
                grade = value;
            }
        }
        public int HoursOfDiscipline
        {
            get { return hoursOfDiscipline; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Значение не может быть отрицательным");
                }
                hoursOfDiscipline = value;
            }
        }
        public Discipline(string subject, int grade, int hoursOfDiscipline)
        {
            Subject = subject;
            Grade = grade;
            HoursOfDiscipline = hoursOfDiscipline;
        }
        public Discipline()
        {

        }
    }
}
