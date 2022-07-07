using OperatorsApp;

namespace OperatorsControlFlowTests
{
    public class Tests
    {
        // GetStones Tests
        [TestCase(156, 11)]
        [TestCase(0, 0)]
        [TestCase(13, 0)]
        [TestCase(14, 1)]
        [TestCase(15, 1)]
        public void GivenSomePounds_GetStones_ReturnsExpectedAnswer(int totalPounds, int expectedAnswer)
        {
            Assert.That(Methods.GetStones(totalPounds), Is.EqualTo(expectedAnswer));
        }

        [TestCase(-1)]
        [TestCase(-101)]
        public void GivenNegativePounds_GetStones_Throws(int totalPounds)
        {
            Assert.That(() => Methods.GetStones(totalPounds), Throws.TypeOf<ArgumentOutOfRangeException>());
        }


        // GetPounds Tests
        [TestCase(156, 2)]
        [TestCase(0, 0)]
        [TestCase(13, 13)]
        [TestCase(14, 0)]
        [TestCase(15, 1)]
        public void GivenSomePounds_GetPounds_ReturnsExpectedAnswer(int totalPounds, int expectedAnswer)
        {
            Assert.That(Methods.GetPounds(totalPounds), Is.EqualTo(expectedAnswer));
        }

        [TestCase(-1)]
        [TestCase(-101)]
        public void GivenNegativePounds_GetPounds_Throws(int totalPounds)
        {
            Assert.That(() => Methods.GetPounds(totalPounds), Throws.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}