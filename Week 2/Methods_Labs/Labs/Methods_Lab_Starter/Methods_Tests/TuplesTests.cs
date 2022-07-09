using NUnit.Framework;
using Methods_Lib;
using System;

namespace Methods_Tests
{
    public class TuplesTests
    {
        [TestCase(25, 3, 4)]
        [TestCase(0, 0, 0)]
        [TestCase(33, 4, 5)]
        public void GivenANumber_DaysAndWeeks_ReturnsCorrectTuple(
            int totalDays, int expectedWeeks, int expectedDays)
        {
            var answer = Methods.DaysAndWeeks(totalDays);
            Assert.That(answer.weeks, Is.EqualTo(expectedWeeks), "Weeks");
            Assert.That(answer.days, Is.EqualTo(expectedDays), "Days");
        }
        [Test]
        public void GivenANegativeNumber_DaysAndWeeks_ThrowsAnException()
        {
            Assert.That(() => Methods.DaysAndWeeks(-1), Throws.TypeOf<ArgumentOutOfRangeException>()
        .With.Message.Contain("totalDays must not be negative"));
        }

        [TestCase(0, 0, 0, 0.0)]
        [TestCase(1, 1, 1, 1.0)]
        [TestCase(2, 4, 8, 1.414213562373095)]
        [TestCase(4, 16, 64, 2.0)]
        public void GivenANumber_PowersRoot_ReturnsCorrectTuple(
            int number, int expectedSquare, int expectedCube, double expectedSquareRoot)
        {
            var answer = Methods.PowersRoot(number);
            Assert.That(answer.square, Is.EqualTo(expectedSquare));
            Assert.That(answer.cube, Is.EqualTo(expectedCube));
            Assert.That(answer.squareRoot, Is.EqualTo(expectedSquareRoot).Within(1).Ulps);
        }
        [Test]
        public void GivenANegativeNumber_PowersRoot_ThrowsAnException()
        {
            Assert.That(() => Methods.PowersRoot(-1), Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Message.Contain("number must not be negative"));
        }
    }
}