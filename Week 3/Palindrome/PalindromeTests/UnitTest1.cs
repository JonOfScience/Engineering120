using PalindromeApp;

namespace PalindromeTests;

public class IsPalindrome
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GivenEmptyString_ThrowsArgumentException()
    {
        Assert.That(() => Program.IsPalindrome(""), Throws.TypeOf<ArgumentException>());
    }

    [TestCase("a")]
    [TestCase("A")]
    [TestCase("1")]
    public void GivenLength1String_ReturnsTrue(string stringToTest)
    {
        Assert.That(Program.IsPalindrome(stringToTest), Is.True);
    }

    [TestCase("11")]
    [TestCase("22")]
    [TestCase("99")]
    public void GivenLength2Numbers_ReturnsTrue(string stringToTest)
    {
        Assert.That(Program.IsPalindrome(stringToTest), Is.True);
    }

    [TestCase("an")]
    [TestCase("at")]
    [TestCase("in")]
    [TestCase("of")]
    [TestCase("to")]
    public void GivenLength2Words_ReturnsFalse(string stringToTest)
    {
        Assert.That(Program.IsPalindrome(stringToTest), Is.False);
    }

    [TestCase("bib")]
    [TestCase("gag")]
    [TestCase("gig")]
    [TestCase("ewe")]
    [TestCase("eye")]
    [TestCase("nun")]
    [TestCase("pip")]
    [TestCase("pop")]
    public void GivenLength3Palindromes_ReturnsTrue(string stringToTest)
    {
        Assert.That(Program.IsPalindrome(stringToTest), Is.True);
    }

    [TestCase("apt")]
    [TestCase("bin")]
    [TestCase("can")]
    [TestCase("dip")]
    [TestCase("eat")]
    [TestCase("fit")]
    public void GivenLength3Words_ReturnsFalse(string stringToTest)
    {
        Assert.That(Program.IsPalindrome(stringToTest), Is.False);
    }

    [TestCase("tool")]
    public void GivenLength4WordsWithSameCentre_ReturnsFalse(string stringToTest)
    {
        Assert.That(Program.IsPalindrome(stringToTest), Is.False);
    }

    [TestCase("deed")]
    [TestCase("noon")]
    [TestCase("peep")]
    [TestCase("sees")]
    [TestCase("toot")]
    [TestCase("hannah")]
    [TestCase("pullup")]
    public void GivenSingleWordEvenPalindromes_ReturnsTrue(string stringToTest)
    {
        Assert.That(Program.IsPalindrome(stringToTest), Is.True);
    }

    [TestCase("civic")]
    [TestCase("kayak")]
    [TestCase("level")]
    [TestCase("madam")]
    [TestCase("put-up")]
    [TestCase("radar")]
    [TestCase("rotor")]
    [TestCase("tenet")]
    [TestCase("deified")]
    [TestCase("racecar")]
    [TestCase("reviver")]
    [TestCase("rotator")]
    [TestCase("deleveled")]
    [TestCase("redivider")]
    [TestCase("rotavator")]
    public void GivenSingleWordOddPalindromes_ReturnsTrue(string stringToTest)
    {
        Assert.That(Program.IsPalindrome(stringToTest), Is.True);
    }

    [TestCase("put-up")]
    [TestCase("pull-up")]
    public void GivenSingleWordPalindromesWithNonAlphabetics_ReturnsTrue(string stringToTest)
    {
        Assert.That(Program.IsPalindrome(stringToTest), Is.True);
    }

    [TestCase("A man, a plan, a canal, Panama!")]
    [TestCase("Rise to vote, sir.")]
    [TestCase("Madam, I'm Adam.")]
    public void GivenPalindromePhrasesWithNonAlphabetics_ReturnsTrue(string stringToTest)
    {
        Assert.That(Program.IsPalindrome(stringToTest), Is.True);
    }
}