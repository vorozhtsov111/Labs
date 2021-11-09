using Employees;
using NUnit.Framework;
using System;

namespace UnitTests
{
    [TestFixture]
    public class SalaryPayTest
    {
        [Test]
        public void NameTest()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => new SalaryEmployee(null, "Менеджер", 29, 13552.1, 23, 23));
            Assert.AreEqual("Имя не может быть пустым значением!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new SalaryEmployee(null, "Менеджер", 29, 13552.1, 23, 23));
            Assert.AreEqual("Имя не может быть пустым значением!", ex.Message);
            Assert.DoesNotThrow(
                () => new SalaryEmployee(null, "Менеджер", 29, 13552.1, 23, 23));
        }

        [Test]
        public void PositionTest()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => new SalaryEmployee("Васильев А.Я.", null, 29, 13552.1, 23, 23));
            Assert.AreEqual("Должность не может быть пустым значением!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new SalaryEmployee("Васильев А.Я.", "", 29, 13552.1, 23, 23));
            Assert.AreEqual("Должность не может быть пустым значением!", ex.Message);
            Assert.DoesNotThrow(
                () => new SalaryEmployee("Васильев А.Я.", "Менеджер", 29, 13552.1, 23, 23));
        }

        [Test]
        public void AgeTest()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => new SalaryEmployee("Васильев А.Я.", "Менеджер", -10, 13552.1, 23, 23));
            Assert.AreEqual("Возраст не может быть отрицательным!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new SalaryEmployee("Васильев А.Я.", "Менеджер", -100, 13552.1, 23, 23));
            Assert.AreEqual("Возраст не может быть отрицательным!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new SalaryEmployee("Васильев А.Я.", "Менеджер", -1, 13552.1, 23, 23));
            Assert.AreEqual("Возраст не может быть отрицательным!", ex.Message);
            Assert.DoesNotThrow(
                () => new SalaryEmployee("Васильев А.Я.", "Менеджер", 29, 13552.1, 23, 23));
            Assert.DoesNotThrow(
                () => new SalaryEmployee("Васильев А.Я.", "Менеджер", 58, 13552.1, 23, 23));
        }

        [Test]
        public void SalaryTest()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => new SalaryEmployee("Васильев А.Я.", "Менеджер", 29, 13552.1, 23, 23));
            Assert.AreEqual("Оклад не может быть отрицательным!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new SalaryEmployee("Васильев А.Я.", "Менеджер", 29, 13552.1, 23, 23));
            Assert.AreEqual("Оклад не может быть отрицательным!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new SalaryEmployee("Васильев А.Я.", "Менеджер", 29, 13552.1, 23, 23));
            Assert.AreEqual("Оклад не может быть отрицательным!", ex.Message);
            Assert.DoesNotThrow(
                () => new SalaryEmployee("Васильев А.Я.", "Менеджер", 29, 13552.1, 23, 23));
            Assert.DoesNotThrow(
                () => new SalaryEmployee("Васильев А.Я.", "Менеджер", 29, 13552.1, 23, 23));
        }

        [Test]
        public void WorkingDaysTest()
        {

        }
        
        [Test]
        public void MonthSalaryTest()
        {
            RatePayEmployee e = new RatePayEmployee("Васильев А.Я.", "Менеджер", 29,
                100, 1);
            Assert.AreEqual(100, e.MonthSalary);
            e.Salary = 0;
            e.Rate = 1.3;
            Assert.AreEqual(0, e.MonthSalary);
            e.Salary = 42351.84;
            e.Rate = 0;
            Assert.AreEqual(0, e.MonthSalary);
            e.Salary = 552.1;
            e.Rate = 1.1;
            Assert.AreEqual(607.31, e.MonthSalary);
            e.Salary = 9212.43;
            e.Rate = 0.75;
            Assert.AreEqual(6909.32, e.MonthSalary);
        }
    }
}