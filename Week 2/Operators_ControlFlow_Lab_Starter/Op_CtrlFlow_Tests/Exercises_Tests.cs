using NUnit.Framework;
using Op_CtrlFlow;
using System.Collections.Generic;
using System;

namespace Op_CtrlFlow_Tests
{
    public class Exercises_Tests
    {
        // write unit test(s) for MyMethod here
        // if num1 == num2 return false
        [Test]
        public void GivenNum1EqualsNum2_MyMethod_ReturnsFalse()
        {
            Assert.That(Exercises.MyMethod(2, 2), Is.EqualTo(false));
        }
        
        // else return false if num1 is not divisible by num2
        [Test]
        public void GivenNum1IsNotEqualToOrDivisibleByNum2_MyMethod_ReturnsFalse()
        {
            Assert.That(Exercises.MyMethod(5, 2), Is.EqualTo(false));
        }
        
        // else return true if num1 is divisible by num2
        [Test]
        public void GivenNum1IsNotEqualToButIsDivisibleByNum2_MyMethod_ReturnsTrue()
        {
            Assert.That(Exercises.MyMethod(4, 2), Is.EqualTo(true));
        }

        [Test]
        public void Average_ReturnsCorrectAverage()
        {
            var myList = new List<int>() { 3, 8, 1, 7, 3 };
            Assert.That(Exercises.Average(myList), Is.EqualTo(4.4));
        }

        // Conflicts with changed requirement in Exceptions Lab homework
        //[Test]
        //public void WhenListIsEmpty_Average_ReturnsZero()
        //{
        //    var myList = new List<int>() {};
        //    Assert.That(Exercises.Average(myList), Is.EqualTo(0));
        //}

        [Test]
        public void WhenListIsEmpty_Average_ThrowAnArgumentException()
        {
            var myList = new List<int>() { };
            Assert.That(() => Exercises.Average(myList), Throws.TypeOf<ArgumentException>());
        }


        [TestCase(100, "OAP")]
        [TestCase(60, "OAP")]
        [TestCase(59, "Standard")]
        [TestCase(18, "Standard")]
        [TestCase(17, "Student")]
        [TestCase(13, "Student")]
        [TestCase(12, "Child")]
        [TestCase(5, "Child")]
        [TestCase(4, "Free")]
        [TestCase(0, "Free")]
        public void TicketTypeTest(int age, string expected)
        {
            var result = Exercises.TicketType(age);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(-1)]
        [TestCase(-101)]
        public void WhenAgeIsNegative_TicketType_ThrowsArgumentOutOfRangeException(int age)
        {
            Assert.That(() =>  Exercises.TicketType(age), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [TestCase(0, "Fail")]
        [TestCase(39, "Fail")]
        [TestCase(40, "Pass")]
        [TestCase(59, "Pass")]
        [TestCase(60, "Pass with Merit")]
        [TestCase(74, "Pass with Merit")]
        [TestCase(75, "Pass with Distinction")]
        [TestCase(100, "Pass with Distinction")]
        public void GivenMarks_Grade_ReturnsExpectedResults(int mark, string expected)
        {
            Assert.That(Exercises.Grade(mark), Is.EqualTo(expected));
        }

        [TestCase(-1)]
        [TestCase(-101)]
        public void WhenMarkIsNegative_Grade_ThrowsArgumentOutOfRangeException(int mark)
        {
            Assert.That(() => Exercises.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [TestCase(101)]
        [TestCase(201)]
        public void WhenMarkIsAbove100_Grade_ThrowsArgumentOutOfRangeException(int mark)
        {
            Assert.That(() => Exercises.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [TestCase(0, 200)]
        [TestCase(1, 100)]
        [TestCase(2, 50)]
        [TestCase(3, 50)]
        [TestCase(4, 20)]
        public void GivenLevel_GetScottishMaxWeddingNumbers_ReturnsExpectedResults(int level, int expected)
        {
            Assert.That(Exercises.GetScottishMaxWeddingNumbers(level), Is.EqualTo(expected));
        }
        
        [TestCase(-1)]
        [TestCase(5)]
        [TestCase(100)]
        public void WhenCovidLevelIsOutsideSpecification_GetScottishMaxWeddingNumbers_ThrowsArgumentOutOfRangeException(int level)
        {
            Assert.That(() => Exercises.GetScottishMaxWeddingNumbers(level), Throws.TypeOf<ArgumentException>());
        }

    }
}
