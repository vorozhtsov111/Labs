using Employees;
using NUnit.Framework;
using System;

namespace UnitTests
{
    [TestFixture]
    public class HourlyPayTest
    {
        [Test]
        public void NameTest()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => new HourlyPayEmployee(null, "Менеджер", 29, 100, 100));
            Assert.AreEqual("Имя не может быть пустым значением!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new HourlyPayEmployee("", "Менеджер", 29, 100, 100));
            Assert.AreEqual("Имя не может быть пустым значением!", ex.Message);
            Assert.DoesNotThrow(
                () => new HourlyPayEmployee("Васильев А.Я.", "Менеджер", 29, 100, 100));
        }

        [Test]
        public void PositionTest()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => new HourlyPayEmployee("Васильев А.Я.", null, 29, 100, 100));
            Assert.AreEqual("Должность не может быть пустым значением!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new HourlyPayEmployee("Васильев А.Я.", "", 29, 100, 100));
            Assert.AreEqual("Должность не может быть пустым значением!", ex.Message);
            Assert.DoesNotThrow(
                () => new HourlyPayEmployee("Васильев А.Я.", "Менеджер", 29, 100, 100));
        }

        [Test]
        public void AgeTest()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => new HourlyPayEmployee("Васильев А.Я.", "Менеджер", -10, 100, 100));
            Assert.AreEqual("Возраст не может быть отрицательным!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new HourlyPayEmployee("Васильев А.Я.", "Менеджер", -100, 100, 100));
            Assert.AreEqual("Возраст не может быть отрицательным!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new HourlyPayEmployee("Васильев А.Я.", "Менеджер", -1, 100, 100));
            Assert.AreEqual("Возраст не может быть отрицательным!", ex.Message);
            Assert.DoesNotThrow(
                () => new HourlyPayEmployee("Васильев А.Я.", "Менеджер", 29, 100, 100));
            Assert.DoesNotThrow(
                () => new HourlyPayEmployee("Васильев А.Я.", "Менеджер", 58, 100, 100));
        }

        [Test]
        public void HourlyTest()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => new HourlyPayEmployee("Васильев А.Я.", "Менеджер", 29, -10, 100));
            Assert.AreEqual("Почасовая оплата не может быть отрицательной!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new HourlyPayEmployee("Васильев А.Я.", "Менеджер", 29, -100, 100));
            Assert.AreEqual("Почасовая оплата не может быть отрицательной!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new HourlyPayEmployee("Васильев А.Я.", "Менеджер", 29, -1, 100));
            Assert.AreEqual("Почасовая оплата не может быть отрицательной!", ex.Message);
            Assert.DoesNotThrow(
                () => new HourlyPayEmployee("Васильев А.Я.", "Менеджер", 29, 913, 100));
            Assert.DoesNotThrow(
                () => new HourlyPayEmployee("Васильев А.Я.", "Менеджер", 29, 54, 100));
        }

        [Test]
        public void HoursTest()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => new HourlyPayEmployee("Васильев А.Я.", "Менеджер", 29, 100, -10));
            Assert.AreEqual("Количество часов не может быть отрицательным!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new HourlyPayEmployee("Васильев А.Я.", "Менеджер", 29, 100, -100));
            Assert.AreEqual("Количество часов не может быть отрицательным!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new HourlyPayEmployee("Васильев А.Я.", "Менеджер", 29, 100, -1));
            Assert.AreEqual("Количество часов не может быть отрицательным!", ex.Message);
            Assert.DoesNotThrow(
                () => new HourlyPayEmployee("Васильев А.Я.", "Менеджер", 29, 100, 913));
            Assert.DoesNotThrow(
                () => new HourlyPayEmployee("Васильев А.Я.", "Менеджер", 29, 100, 54));
        }

        [Test]
        public void MonthSalaryTest()
        {
            HourlyPayEmployee e = new HourlyPayEmployee("Васильев А.Я.", "Менеджер", 29,
                100, 100);
            Assert.AreEqual(10000, e.MonthSalary);
            e.HourlyPay = 0;
            e.Hours = 101;
            Assert.AreEqual(0, e.MonthSalary);
            e.HourlyPay = 101;
            e.Hours = 0;
            Assert.AreEqual(0, e.MonthSalary);
            e.HourlyPay = 552.1;
            e.Hours = 11;
            Assert.AreEqual(6073.1, e.MonthSalary);
            e.HourlyPay = 92.12;
            e.Hours = 43.7;
            Assert.AreEqual(4025.64, e.MonthSalary);
        }
    }
}