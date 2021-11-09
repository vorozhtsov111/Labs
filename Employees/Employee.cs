using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Employees
{
    /// <summary>
    /// Интерфейс "сотрудник"
    /// </summary>
    [XmlInclude(typeof(HourlyPayEmployee))]
    [XmlInclude(typeof(SalaryEmployee))]
    [XmlInclude(typeof(RatePayEmployee))]
    [Serializable]
    public abstract class Employee
    {
        /// <summary>
        /// Имя сотрудника
        /// </summary>
        private string name;

        /// <summary>
        /// Имя сотрудника
        /// </summary>
        [DisplayName("ФИО")]
        public string Name 
        { 
            get { return name; } 
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException(
                        "Имя не может быть пустым значением!");
                name = value;
            }
        }

        /// <summary>
        /// Должность сотрудника
        /// </summary>
        private string position;

        /// <summary>
        /// Имя сотрудника
        /// </summary>
        [DisplayName("Должность")]
        public string Position
        {
            get { return position; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException(
                        "Должность не может быть пустым значением!");
                position = value;
            }
        }

        /// <summary>
        /// Возраст сотрудника
        /// </summary>
        private int age;

        /// <summary>
        /// Возраст сотрудника
        /// </summary>
        [DisplayName("Возраст")]
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                    throw new ArgumentException(
                        "Возраст не может быть отрицательным!");
                age = value;
            }
        }

        /// <summary>
        /// Зарплата сотрудника в месяц
        /// </summary>
        /// <returns>Зарплата</returns>
        [DisplayName("Зарплата")]
        public abstract double MonthSalary
        {
            get;
        }

        /// <summary>
        /// Вывод информации о сотруднике
        /// </summary>
        public abstract void Print();

        /// <summary>
        /// Создание случайной базовой информации
        /// </summary>
        /// <param name="name">ФИО</param>
        /// <param name="position">Должность</param>
        /// <param name="age">Возраст</param>
        protected static void RandomBaseInfo(ref string name,
            ref string position, ref int age)
        {
            Random r = new Random();

            List<string> m_surnames = new List<string>()
            {
                "Алексеев", "Борисов", "Васильев", "Гордеев", "Демьянов",
                "Ежов", "Жигунов", "Зибров", "Константинов", "Литвинов",
                "Мазаев", "Носков", "Ованезов", "Петров", "Родионов"
            };
            List<string> w_surnames = new List<string>()
            {
                "Андреева", "Биткина", "Викторова", "Грушина", "Дягилева",
                "Елкина", "Жамнова", "Зудина", "Кречетова", "Ляпунова",
                "Михеева", "Ноткина", "Окунёва", "Подозёрова", "Раскольникова"
            };
            List<char> initials = new List<char>()
            {
                'А', 'Б', 'В', 'Г', 'Д', 'Е', 'З', 'И', 'К', 'Л',
                'М', 'Н', 'О', 'П', 'Р', 'C', 'Т'
            };

            if (r.Next(0, 2) == 0)
                name = m_surnames[r.Next(0, m_surnames.Count)];
            else
                name = w_surnames[r.Next(0, m_surnames.Count)];
            name += " " + initials[r.Next(0, initials.Count)]
                + "." + initials[r.Next(0, initials.Count)] + ".";

            List<string> positions = new List<string>()
            {
                "Бухгалтер", "Системный администратор", "Программист",
                "Менеджер", "Руководитель отдела", "Стажёр"
            };
            position = positions[r.Next(0, positions.Count)];

            age = r.Next(18, 66);
        }
    }
}
