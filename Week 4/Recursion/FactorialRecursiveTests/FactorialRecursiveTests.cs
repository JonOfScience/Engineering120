using RecursionApp;
namespace FactorialRecursiveTests;

public class Tests
{
    [TestCase(-1)]
    [TestCase(0)]
    [Category("Sad Path")]
    public void GivenNLess1_FactorialRecursive_Throws(int input)
    {
        Assert.That(() => Program.FactorialRecursive(input), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("n has to be between 1 and 16"));
    }

    [Test]
    [Category("Sad Path")]
    public void GivenNGreaterThan21_FactorialRecursive_Throws()
    {
        Assert.That(() => Program.FactorialRecursive(22), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("n has to be between 1 and 16"));
    }

    [TestCase(5)]
    [Category("Happy Path")]
    public void GivenValidN_FactorialRecursive_ReturnsExpected(int input)
    {
        Assert.That(Program.FactorialRecursive(input), Is.EqualTo(120));
    }
}