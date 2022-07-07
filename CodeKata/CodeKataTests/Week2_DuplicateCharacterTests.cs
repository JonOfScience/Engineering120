using CodeKata;

namespace CodeKataTests
{
    public class Tests
    {
        [Test]
        public void GivenNishantMandal_FindDupicateCharacters_ReturnsAN()
        {
            char[] duplicates = new char[] { 'a', 'n' };
            Program.FindDuplicateCharacters("Nishant Mandal");
            Assert.That(Program.FindDuplicateCharacters("Nishant Mandal"), Is.EqualTo(duplicates));
        }
    }
}