// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace TDDKata
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void SimpleTest()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum("2,2");
            Assert.That(value, Is.EqualTo(4), "Wrong actual value");
        }

        [Test]
        public void SimpleTest3Value()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum("22,2,4");
            Assert.That(value, Is.EqualTo(28), "Wrong actual value");
        }

        [Test]
        public void TestIfLenZero()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum("");
            Assert.That(value, Is.EqualTo(0), "Must be 0");
        }

        [Test]
        public void TestIfValueZero()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum("0");
            Assert.That(value, Is.EqualTo(0), "Must be 0");
        }

        [Test]
        public void TestIfValueOne()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum("11");
            Assert.That(value, Is.EqualTo(22), "Must be 2");
        }
    }
}
