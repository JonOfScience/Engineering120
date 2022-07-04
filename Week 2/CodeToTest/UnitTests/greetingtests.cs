using CodeToTest;

namespace UnitTests
{
    public class Tests
    {
        [TestCase(1, "Good evening!")]
        [TestCase(4, "Good evening!")]
        [TestCase(5, "Good morning!")]
        [TestCase(11, "Good morning!")]
        [TestCase(12, "Good afternoon!")]
        [TestCase(18, "Good afternoon!")]
        [TestCase(19, "Good evening!")]
        [TestCase(24, "Good evening!")]
        public void GivenATime_Greeting_ReturnsAnExpectedResult(int timeOfDay, string expectedResult)
        {
            Assert.That(Program.Greeting(timeOfDay), Is.EqualTo(expectedResult));
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(25)]
        public void GivenAnInvalidTime_Greeting_Throws(int timeOfDay)
        {
            Assert.That(() => Program.Greeting(timeOfDay), Throws.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}