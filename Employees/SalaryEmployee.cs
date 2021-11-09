using System;

namespace Employees
{
    /// <summary>
    /// Сотрудник с зарплатой по окладу
    /// </summary>
    [Serializable]
    public class SalaryEmployee: Employee
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
        /// Количество рабочих дней в месяце
        /// </summary>
        private int workingDays;

        /// <summary>
        /// Количество рабочих дней в месяце
        /// </summary>
        public int WorkingDays
        {
            get { return workingDays; }
            set
            {
                if (value < 1 || value > 31)
                    throw new ArgumentException(
                        "Число рабочих дней в диапазоне [1-31]!");
                workingDays = value;
            }
        }

        /// <summary>
        /// Количество фактически отработанных дней в месяце
        /// </summary>
        private int actualDays;

        /// <summary>
        /// Количество фактически отработанных дней в месяце
        /// </summary>
        public int ActualDays
        {
            get { return actualDays; }
            set
            {
                if (value < 0 || value > 31)
                    throw new ArgumentException(
                        "Число отработанных дней в диапазоне [0-31]!");
                actualDays = value;
            }
        }

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        private SalaryEmployee()
        {

        }

        /// <summary>
        /// Конструктор сотрудника с оплатой по окладу
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="position">Должность</param>
        /// <param name="age">Возраст</param>
        /// <param name="salary">Оклад</param>
        /// <param name="workingDays">Количество рабочих дней в месяце</param>
        /// <param name="actualDays">Количество отработанных дней в месяце</param>
        public SalaryEmployee(string name, string position, int age,
            double salary, int workingDays, int actualDays)
        {
            Name = name;
            Position = position;
            Age = age;
            Salary = salary;
            WorkingDays = workingDays;
            ActualDays = actualDays;
        }

        /// <summary>
        /// Зарплата сотрудника в месяц
        /// </summary>
        /// <returns>Зарплата</returns>
        public override double MonthSalary
        {
            get { return Math.Round(salary * workingDays / actualDays, 2); }
        }

        /// <summary>
        /// Вывод информации о сотруднике
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"Имя: {Name}. Должность: {Position}. Возраст: {Age}.\n" +
                $"Оклад: {Salary}. Количество рабочих дней: {WorkingDays}. " +
                $"Количество фактически отработанных дней: {ActualDays}.\n" +
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
            int workingDays = r.Next(20, 24);
            return new SalaryEmployee(name, position, age,
                r.NextDouble() * 1000000, workingDays, r.Next(1, workingDays));
        }
    }
}
