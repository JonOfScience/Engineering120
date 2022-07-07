namespace ExceptionsDataTypesTests
{
    public class Tests
    {
        [TestCase(-1)]
        [TestCase(-100)]
        public void WhenMarkIsLessThatZero_Grade_ThrowsAnArgumentOutOfRangeException(int mark)
        {
            Assert.That(() => Program.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Allowed range 0 - 100"));
            Assert.That(() => Program.Grade(mark), Throws.InstanceOf<Exception>().With.Message.Contains("Allowed range 0 - 100"));
        }

        [TestCase(101)]
        [TestCase(1001)]
        public void WhenMarkIsMoreThat100_Grade_ThrowsAnArgumentOutOfRangeException(int mark)
        {
            Assert.That(() => Program.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Allowed range 0 - 100"));
        }
    }
}