using NUnit.Framework;
using TestFirstExercises;

namespace TestFirstExercises_Tests
{
    public class OperatorTests
    {
        // Test 0's
        [TestCase(0, 0, true)]
        // Test negatives
        [TestCase(-1, -5, true)]
        [TestCase(5, 2, true)]
        [TestCase(2, 5, false)]
        [TestCase(5, 5, true)]
        public void GivenTwoNumbersXY_GreaterEqual_ReturnsWhetherXIsGreatorOrEqualToY(int x, int y, bool expResult)
        {
            Assert.That(Methods.GreaterEqual(x, y), Is.EqualTo(expResult));
        }

        // -1 due to squaring leading to positive result
        [TestCase(-1, 10.571)]
        [TestCase(0, 10.429)]
        [TestCase(10, 24.714)]
        public void GivenNumber_BODMAS_ReturnsTheExpectedResult(int num, double expResult)
        {
            Assert.That(Methods.BODMAS(num), Is.EqualTo(expResult));
        }

        [TestCase(-2)]
        [TestCase(0)]
        [TestCase(2)]
        [TestCase(348)]
        public void WhenTheArgumentIsEven_EvenOdd_ReturnsTrue(int x)
        {
            var result = Methods.EvenOdd(x);
            Assert.IsTrue(result);
        }

        [TestCase(-3)]
        [TestCase(-1)]
        [TestCase(1)]
        [TestCase(347)]
        public void WhenTheArgumentIsOdd_EvenOdd_ReturnsFalse(int x)
        {
            var result = Methods.EvenOdd(x);
            Assert.IsFalse(result);
        }
    }
}
