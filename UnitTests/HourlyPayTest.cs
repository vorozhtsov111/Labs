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
                () => new HourlyPayEmployee(null, "��������", 29, 100, 100));
            Assert.AreEqual("��� �� ����� ���� ������ ���������!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new HourlyPayEmployee("", "��������", 29, 100, 100));
            Assert.AreEqual("��� �� ����� ���� ������ ���������!", ex.Message);
            Assert.DoesNotThrow(
                () => new HourlyPayEmployee("�������� �.�.", "��������", 29, 100, 100));
        }

        [Test]
        public void PositionTest()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => new HourlyPayEmployee("�������� �.�.", null, 29, 100, 100));
            Assert.AreEqual("��������� �� ����� ���� ������ ���������!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new HourlyPayEmployee("�������� �.�.", "", 29, 100, 100));
            Assert.AreEqual("��������� �� ����� ���� ������ ���������!", ex.Message);
            Assert.DoesNotThrow(
                () => new HourlyPayEmployee("�������� �.�.", "��������", 29, 100, 100));
        }

        [Test]
        public void AgeTest()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => new HourlyPayEmployee("�������� �.�.", "��������", -10, 100, 100));
            Assert.AreEqual("������� �� ����� ���� �������������!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new HourlyPayEmployee("�������� �.�.", "��������", -100, 100, 100));
            Assert.AreEqual("������� �� ����� ���� �������������!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new HourlyPayEmployee("�������� �.�.", "��������", -1, 100, 100));
            Assert.AreEqual("������� �� ����� ���� �������������!", ex.Message);
            Assert.DoesNotThrow(
                () => new HourlyPayEmployee("�������� �.�.", "��������", 29, 100, 100));
            Assert.DoesNotThrow(
                () => new HourlyPayEmployee("�������� �.�.", "��������", 58, 100, 100));
        }

        [Test]
        public void HourlyTest()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => new HourlyPayEmployee("�������� �.�.", "��������", 29, -10, 100));
            Assert.AreEqual("��������� ������ �� ����� ���� �������������!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new HourlyPayEmployee("�������� �.�.", "��������", 29, -100, 100));
            Assert.AreEqual("��������� ������ �� ����� ���� �������������!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new HourlyPayEmployee("�������� �.�.", "��������", 29, -1, 100));
            Assert.AreEqual("��������� ������ �� ����� ���� �������������!", ex.Message);
            Assert.DoesNotThrow(
                () => new HourlyPayEmployee("�������� �.�.", "��������", 29, 913, 100));
            Assert.DoesNotThrow(
                () => new HourlyPayEmployee("�������� �.�.", "��������", 29, 54, 100));
        }

        [Test]
        public void HoursTest()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => new HourlyPayEmployee("�������� �.�.", "��������", 29, 100, -10));
            Assert.AreEqual("���������� ����� �� ����� ���� �������������!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new HourlyPayEmployee("�������� �.�.", "��������", 29, 100, -100));
            Assert.AreEqual("���������� ����� �� ����� ���� �������������!", ex.Message);
            ex = Assert.Throws<ArgumentException>(
                () => new HourlyPayEmployee("�������� �.�.", "��������", 29, 100, -1));
            Assert.AreEqual("���������� ����� �� ����� ���� �������������!", ex.Message);
            Assert.DoesNotThrow(
                () => new HourlyPayEmployee("�������� �.�.", "��������", 29, 100, 913));
            Assert.DoesNotThrow(
                () => new HourlyPayEmployee("�������� �.�.", "��������", 29, 100, 54));
        }
    }
}