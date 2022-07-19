using JonSortApp;

namespace SortingTests
{
    public class Tests
    {
        private Sorter _sorter;

        [SetUp]
        public void Setup()
        {
            _sorter = new Sorter();
        }

        // Empty array - Immutable please

        [TestCaseSource(nameof(SadCases))]
        public void GivenInValidSortingInput_BubbleSort_Throws(int[] input)
        {
            Assert.That(() => _sorter.BubbleSort(input), Throws.TypeOf<ArgumentException>().With.Message.Contains("Input must contain at least one element"));
        }
        static object[] SadCases =
        {
            new object[] { new int[] { } }
        };

        [TestCaseSource(nameof(HappyCases))]
        public void GivenValidSortingInput_BubbleSort_ReturnsExpectedResult(int[] input, int[] expectedResult)
        {
            Assert.That(_sorter.BubbleSort(input), Is.EquivalentTo(expectedResult).With.Ordered.Ascending);
        }

        static object[] HappyCases =
        {
            // single element array
            new object[] { new int[]  { 1 }, new int[] { 1 } },
            // array of all 1s
            new object[] { new int[]  { 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1 } },
            // array of all -1s
            new object[] { new int[]  { -1, -1, -1, -1, -1 }, new int[] { -1, -1, -1, -1, -1 } },
            // Random order
            new object[] { new int[]  { 5, 1, 3, 2, 4 }, new int[] { 1, 2, 3, 4, 5 } },
            // almost sorted
            new object[] { new int[]  { 1, 3, 2, 4, 6, 5 }, new int[] { 1, 2, 3, 4, 5, 6 } },
            // inverse sorted
            new object[] { new int[]  { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 } },
            // few unique values
            new object[] { new int[]  { 1, 2, 3, 3, 1, 2 }, new int[] { 1, 1, 2, 2, 3, 3 } },
        };
    }
}