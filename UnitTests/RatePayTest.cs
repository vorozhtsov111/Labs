using Employees;
using NUnit.Framework;
using System;

namespace UnitTests
{
    [TestFixture]
    public class RatePayTest
    {
        [Test]
        public void NameTest()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => new RatePayEmployee(null, "Менеджер", 29, 13552.1, 0.25));
            Assert.AreEqual("Имя не может быть пустым значением!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new RatePayEmployee("", "Менеджер", 29, 13552.1, 0.25));
            Assert.AreEqual("Имя не может быть пустым значением!", ex.Message);
            Assert.DoesNotThrow(
                () => new RatePayEmployee("Васильев А.Я.", "Менеджер", 29, 13552.1, 0.25));
        }

        [Test]
        public void PositionTest()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => new RatePayEmployee("Васильев А.Я.", null, 29, 13552.1, 0.25));
            Assert.AreEqual("Должность не может быть пустым значением!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new RatePayEmployee("Васильев А.Я.", "", 29, 13552.1, 0.25));
            Assert.AreEqual("Должность не может быть пустым значением!", ex.Message);
            Assert.DoesNotThrow(
                () => new RatePayEmployee("Васильев А.Я.", "Менеджер", 29, 13552.1, 0.25));
        }

        [Test]
        public void AgeTest()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => new RatePayEmployee("Васильев А.Я.", "Менеджер", -10, 13552.1, 0.25));
            Assert.AreEqual("Возраст не может быть отрицательным!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new RatePayEmployee("Васильев А.Я.", "Менеджер", -100, 13552.1, 0.25));
            Assert.AreEqual("Возраст не может быть отрицательным!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new RatePayEmployee("Васильев А.Я.", "Менеджер", -1, 13552.1, 0.25));
            Assert.AreEqual("Возраст не может быть отрицательным!", ex.Message);
            Assert.DoesNotThrow(
                () => new RatePayEmployee("Васильев А.Я.", "Менеджер", 29, 13552.1, 0.25));
            Assert.DoesNotThrow(
                () => new RatePayEmployee("Васильев А.Я.", "Менеджер", 58, 13552.1, 0.25));
        }

        [Test]
        public void SalaryTest()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => new RatePayEmployee("Васильев А.Я.", "Менеджер", 29, -10, 1));
            Assert.AreEqual("Оклад не может быть отрицательным!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new RatePayEmployee("Васильев А.Я.", "Менеджер", 29, -100, 1));
            Assert.AreEqual("Оклад не может быть отрицательным!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new RatePayEmployee("Васильев А.Я.", "Менеджер", 29, -1, 1));
            Assert.AreEqual("Оклад не может быть отрицательным!", ex.Message);
            Assert.DoesNotThrow(
                () => new RatePayEmployee("Васильев А.Я.", "Менеджер", 29, 913, 1));
            Assert.DoesNotThrow(
                () => new RatePayEmployee("Васильев А.Я.", "Менеджер", 29, 54, 1));
        }

        [Test]
        public void HoursTest()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => new RatePayEmployee("Васильев А.Я.", "Менеджер", 29, 100, -10));
            Assert.AreEqual("Ставка должна быть неотрицательной и не больше 1.5!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new RatePayEmployee("Васильев А.Я.", "Менеджер", 29, 100, -100));
            Assert.AreEqual("Ставка должна быть неотрицательной и не больше 1.5!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new RatePayEmployee("Васильев А.Я.", "Менеджер", 29, 100, -1));
            Assert.AreEqual("Ставка должна быть неотрицательной и не больше 1.5!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new RatePayEmployee("Васильев А.Я.", "Менеджер", 29, 100, 10));
            Assert.AreEqual("Ставка должна быть неотрицательной и не больше 1.5!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new RatePayEmployee("Васильев А.Я.", "Менеджер", 29, 100, 100));
            Assert.AreEqual("Ставка должна быть неотрицательной и не больше 1.5!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new RatePayEmployee("Васильев А.Я.", "Менеджер", 29, 100, 1.6));
            Assert.AreEqual("Ставка должна быть неотрицательной и не больше 1.5!", ex.Message);
            Assert.DoesNotThrow(
                () => new RatePayEmployee("Васильев А.Я.", "Менеджер", 29, 100, 1));
            Assert.DoesNotThrow(
                () => new RatePayEmployee("Васильев А.Я.", "Менеджер", 29, 100, 1.5));
            Assert.DoesNotThrow(
                () => new RatePayEmployee("Васильев А.Я.", "Менеджер", 29, 100, 0.25));
            Assert.DoesNotThrow(
                () => new RatePayEmployee("Васильев А.Я.", "Менеджер", 29, 100, 0.75));
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