using Employees;
using System;

namespace ConsoleLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e;

            Console.WriteLine("Сотрудник с почасовой оплатой");
            try
            {
                Console.Write("Введите имя: ");
                string name = Console.ReadLine();

                Console.Write("Введите должность: ");
                string position = Console.ReadLine();

                Console.Write("Введите возраст: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Введите оплату в час: ");
                double hourlyPay = double.Parse(Console.ReadLine().Replace('.', ','));

                Console.Write("Введите количество часов: ");
                double hours = double.Parse(Console.ReadLine().Replace('.', ','));

                e = new HourlyPayEmployee(name, position, age, hourlyPay, hours);

                e.Print();
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Сотрудник с оплатой по окладу");
            try
            {
                Console.Write("Введите имя: ");
                string name = Console.ReadLine();

                Console.Write("Введите должность: ");
                string position = Console.ReadLine();

                Console.Write("Введите возраст: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Введите размер оклада: ");
                double salary = double.Parse(Console.ReadLine().Replace('.', ','));

                Console.Write("Введите количество рабочих дней в месяце: ");
                int workingDays = int.Parse(Console.ReadLine());

                Console.Write("Введите количество отработанных дней в месяце: ");
                int actualDays = int.Parse(Console.ReadLine());

                e = new SalaryEmployee(name, position, age, salary, workingDays, actualDays);

                e.Print();
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Сотрудник с оплатой по ставке");
            try
            {
                Console.Write("Введите имя: ");
                string name = Console.ReadLine();

                Console.Write("Введите должность: ");
                string position = Console.ReadLine();

                Console.Write("Введите возраст: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Введите размер оклада: ");
                double salary = double.Parse(Console.ReadLine().Replace('.', ','));

                Console.Write("Введите размер ставки: ");
                double rate = double.Parse(Console.ReadLine().Replace('.', ','));

                e = new RatePayEmployee(name, position, age, salary, rate);

                e.Print();
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
