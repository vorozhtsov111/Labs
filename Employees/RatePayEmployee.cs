using System;

namespace Employees
{
    /// <summary>
    /// Сотрудник с оплатой по ставке
    /// </summary>
    [Serializable]
    public class RatePayEmployee : Employee
    {
        /// <summary>
        /// Оклад
        /// </summary>
        private double salary;

        /// <summary>
        /// Оклад
        /// </summary>
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                    throw new ArgumentException(
                        "Оклад не может быть отрицательным!");
                salary = value;
            }
        }

        /// <summary>
        /// Ставка
        /// </summary>
        private double rate;

        /// <summary>
        /// Ставка
        /// </summary>
        public double Rate
        {
            get { return rate; }
            set
            {
                if (value < 0 || value > 1.5)
                    throw new ArgumentException(
                        "Ставка должна быть неотрицательной и не больше 1.5!");
                rate = value;
            }
        }

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        private RatePayEmployee()
        {

        }

        /// <summary>
        /// Конструктор сотрудника с оплатой по ставке
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="position">Должность</param>
        /// <param name="age">Возраст</param>
        /// <param name="salary">Оклад</param>
        /// <param name="rate">Ставка</param>
        public RatePayEmployee(string name, string position, int age,
            double salary, double rate)
        {
            Name = name;
            Position = position;
            Age = age;
            Salary = salary;
            Rate = rate;
        }

        /// <summary>
        /// Зарплата сотрудника в месяц
        /// </summary>
        /// <returns>Зарплата</returns>
        public override double MonthSalary
        {
            get { return Math.Round(salary * rate, 2); }
        }

        /// <summary>
        /// Вывод информации о сотруднике
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"Имя: {Name}. Должность: {Position}. Возраст: {Age}.\n" +
                $"Оклад: {Salary}. Ставка: {Rate}.\n" +
                $"Зарплата в месяц: {MonthSalary}."); ;
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
            return new RatePayEmployee(name, position, age,
                r.NextDouble() * 1000000, r.NextDouble() * 1.5);
        }
    }
}
