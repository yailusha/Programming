using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Discipline
    {
        private string _subject;
        private int _grade;
        private int _hoursOfDiscipline;

        public string Subject
        {
            get { return _subject; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Subject can not be empty");
                }
                _subject = value;
            }
        }
        public int Grade
        {
            get { return _grade; }
            set
            {
                if (_grade < 1 ||  _grade > 5)
                {
                    throw new ArgumentException("Grade only from 1 to 5");
                }
                _grade = value;
            }
        }
        public int HoursOfDiscipline
        {
            get { return _hoursOfDiscipline; }
            set
            {
                if (!Validator.AssertOnPositiveValue(value))
                {
                    throw new ArgumentException("HoursOfDiscipline must contain only positive value");
                }
                _hoursOfDiscipline = value;
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
