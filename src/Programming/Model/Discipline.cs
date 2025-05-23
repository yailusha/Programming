using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные об учебном предмете.
    /// </summary>
    internal class Discipline
    {
        /// <summary>
        /// Название предмета.
        /// </summary>
        private string _subject;
        /// <summary>
        /// Оценка.
        /// </summary>
        private int _grade;
        /// <summary>
        /// Длительность предмета (в часах).
        /// </summary>
        private int _hoursOfDiscipline;
        /// <summary>
        /// Возвращает и задает название предмета. Не может быть пустым.
        /// </summary>
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
        /// <summary>
        /// Возвращает и задает оценку. Должна быть в интервале от 1 до 5.
        /// </summary>
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
        /// <summary>
        /// Возвращает и задает длительность предмета. Значение должно быть только положительным.
        /// </summary>
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
        /// <summary>
        /// Создает экземпляр класса <see cref="Discipline"/>
        /// </summary>
        /// <param name="subject">Предмет. Не может быть пустым.</param>
        /// <param name="grade">Оценка. Должна быть в интервале от 1 до 5.</param>
        /// <param name="hoursOfDiscipline">Длительность предмета. Не может быть отрицательным.</param>
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
