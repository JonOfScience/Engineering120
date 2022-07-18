using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace AdvancedNUnit
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup() { }

        [TestCaseSource("AddCases")]
        [Category("Happy Path")]
        public void Add_Always_ReturnsExpectedResult(int x, int y, int expectedResult)
        {
            // Arrange
            var subject = new Calculator { Num1 = x, Num2 = y };
            // Act
            var result = subject.Add();
            // Assert
            Assert.That(result, Is.EqualTo(expectedResult), "optional failure message");
        }

        private static object[] AddCases =
            {
                new int[] {2, 4, 6},
                new int[] {-2, 4, 2}
            };

        [Test]
        public void SomeConstraints()
        {
            var _sut = new Calculator { Num1 = 6 }; // subject under test
            Assert.That(_sut.DivisibleBy3());

            _sut.Num1 = 7;
            Assert.That(_sut.DivisibleBy3(), Is.False);

            Assert.That(_sut.ToString(), Does.Contain("Calculator"));
        }

        [Test]
        public void stringConstraints()
        {
            var subject = new Calculator { Num1 = 2, Num2 = 4 };
            var strResult = subject.ToString();

            Assert.That(strResult, Is.EqualTo("AdvancedNUnit.Calculator"));
            Assert.That(strResult, Does.Contain("Calculator"));
            // Assert.That(strResult, Does.Not.Contain("Calculator"));
            Assert.That(strResult, Is.EqualTo("advancednunit.calculator").IgnoreCase);
            Assert.That(strResult, Is.Not.Empty);
        }

        [Test]
        public void TestArrayOfStrings()
        {
            var fruit = new List<string> { "apple", "pear", "banana", "peach" };

            Assert.That(fruit, Does.Contain("pear"));
            Assert.That(fruit, Does.Not.Contain("kiwi"));
            Assert.That(fruit, Has.Count.EqualTo(4));
            Assert.That(fruit, Has.Exactly(2).StartsWith("pea"));
        }

        [Test]
        public void TestRange()
        {
            Assert.That(8, Is.InRange(1, 10));

            List<int> nums = new List<int> { 4, 2, 7, 5, 9 };

            Assert.That(nums, Is.All.InRange(1, 10));
            Assert.That(nums, Has.Exactly(2).InRange(1, 4));
        }

        [TestCase(2, 1)]
        [Category("Happy Path")]
        public void Divide_ResturnsExpectedResult(int Num1, int Num2)
        {
            var subject = new Calculator { Num1 = Num1, Num2 = Num2 };
            Assert.That(subject.Divide(), Is.EqualTo(2));
        }

        [TestCase(2, 0)]
        [Category("Error Path")]
        public void DivideByZero_Throws(int Num1, int Num2)
        {
            var subject = new Calculator { Num1 = Num1, Num2 = Num2 };
            Assert.That(() => subject.Divide(), Throws.TypeOf<ArgumentException>());
        }
    }
}
