using System;

namespace Employees
{
    /// <summary>
    /// Сотрудник с почасовой оплатой
    /// </summary>
    [Serializable]
    public class HourlyPayEmployee : Employee
    {
        /// <summary>
        /// Зарплата в час
        /// </summary>
        private double hourlyPay;
        
        /// <summary>
        /// Зарплата в час
        /// </summary>
        public double HourlyPay
        {
            get { return hourlyPay; }
            set
            {
                if (value < 0)
                    throw new ArgumentException(
                        "Почасовая оплата не может быть отрицательной!");
                hourlyPay = value;
            }
        }

        /// <summary>
        /// Количество часов в месяц
        /// </summary>
        private double hours;

        /// <summary>
        /// Количество часов в месяц
        /// </summary>
        public double Hours
        {
            get { return hours; }
            set
            {
                if (value < 0)
                    throw new ArgumentException(
                        "Количество часов не может быть отрицательным!");
                hours = value;
            }
        }

        private HourlyPayEmployee()
        {

        }

        /// <summary>
        /// Конструктор сотрудника с почасовой оплатой
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="position">Должность</param>
        /// <param name="age">Возраст</param>
        /// <param name="hourlyPay">Зарплата в час</param>
        /// <param name="hours">Количество часов в месяц</param>
        public HourlyPayEmployee(string name, string position, int age,
            double hourlyPay, double hours)
        {
            Name = name;
            Position = position;
            Age = age;
            HourlyPay = hourlyPay;
            Hours = hours;
        }

        /// <summary>
        /// Зарплата сотрудника в месяц
        /// </summary>
        /// <returns>Зарплата</returns>
        public override double MonthSalary
        {
            get { return Math.Round(hourlyPay * hours, 2); }
        }

        /// <summary>
        /// Вывод информации о сотруднике
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"Имя: {Name}. Должность: {Position}. Возраст: {Age}.\n" +
                $"Почасовая оплата: {HourlyPay}. Количество часов: {Hours}.\n" +
                $"Зарплата в месяц: {MonthSalary}.");
        }

        /// <summary>
        /// Создание сотрудника со случайными данными
        /// </summary>
        /// <returns>Сотрудник</returns>
        public static Employee RandomEmployee()
        {
            string name = "", position = "";
            int age = 0;
            RandomBaseInfo(ref name, ref position, ref age);
            Random r = new Random();
            return new HourlyPayEmployee(name, position, age,
                r.NextDouble() * 1000, r.NextDouble() * 160);
        }
    }
}
