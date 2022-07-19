namespace CalculatorApp;

public class CalculatorTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("", 0)]
    [TestCase("1", 1)]
    [TestCase("1,2", 3)]
    [TestCase("1,2,3", 6)]
    public void GivenValues_Add_ReturnsExpectedResult(string input, int expectedResult)
    {
        Assert.That(Program.Add(input), Is.EqualTo(expectedResult));
    }


    [TestCase("1\n2,3", 6)]
    public void GivenValuesSeperatedByNewLine_Add_ReturnsExpectedResult(string input, int expectedResult)
    {
        Assert.That(Program.Add(input), Is.EqualTo(expectedResult));
    }

    [TestCase("//;\n1;2", 3)]
    [TestCase("//[***]\n1***2***3", 6)]
    public void GivenValuesSeperatedByACustomDelimiter_Add_ReturnsExpectedResult(string input, int expectedResult)
    {
        Assert.That(Program.Add(input), Is.EqualTo(expectedResult));
    }

    [TestCase("-1")]
    public void GivenASingleNegativeString_Add_Throws(string input)
    {
        Assert.That(() => Program.Add(input), Throws.TypeOf<ArgumentOutOfRangeException>().And.Message.Contains($"negatives not allowed : {input}"));
    }
    
    [TestCase("-1,-2")]
    public void GivenAStringOfMultipleNegatives_Add_Throws(string input)
    {
        Assert.That(() => Program.Add(input), Throws.TypeOf<ArgumentOutOfRangeException>().And.Message.Contains("negatives not allowed : -1,-2"));
    }

    [TestCase("1,1001,2", 3)]
    public void GivenAStringContainignNumebrsOver1000_Add_Ignoresnumber(string input, int expectedResult)
    {
        Assert.That(Program.Add(input), Is.EqualTo(expectedResult));
    }

    [TestCase("//[*][%]\n1*2%3", 6)]
    public void GivenValuesSeperatedByMultipleCustomDelimiters_Add_ReturnsExpectedResult(string input, int expectedResult)
    {
        Assert.That(Program.Add(input), Is.EqualTo(expectedResult));
    }
}