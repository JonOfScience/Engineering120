using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ControlFlowApp;

namespace OperatorsControlFlowTests
{
    internal class LoopTests
    {
        [TestFixture]
        public class HighestValues : LoopTests
        {
            [Test]
            public void GivenEmptyList_HighestForEachLoop_Throws()
            {
                List<int> nums = new List<int> { };
                Assert.That(() => LoopTypes.HighestForEachLoop(nums), Throws.TypeOf<ArgumentException>());
            }

            [Test]
            public void GivenListWithTheHighestAtTheBeginning_HighestForEachLoop_Returns22()
            {
                List<int> nums = new List<int> { 22, 6, 10, -17, 3 };
                Assert.That(LoopTypes.HighestForEachLoop(nums), Is.EqualTo(22));
            }

            [Test]
            public void GivenListWithTheHighestAtTheEnd_HighestForEachLoop_Returns22()
            {
                List<int> nums = new List<int> { 3, 6, 10, -17, 22 };
                Assert.That(LoopTypes.HighestForEachLoop(nums), Is.EqualTo(22));
            }

            [Test]
            public void GivenListWithAllNegativeValues_HighestForEachLoop_ReturnsMinus3()
            {
                List<int> nums = new List<int> { -3, -6, -22, -17, -10 };
                Assert.That(LoopTypes.HighestForEachLoop(nums), Is.EqualTo(-3));
            }

            [Test]
            public void GivenListWithAllZeroValues_HighestForEachLoop_Returns0()
            {
                List<int> nums = new List<int> { 0, 0, 0, 0, 0 };
                Assert.That(LoopTypes.HighestForEachLoop(nums), Is.EqualTo(0));
            }

            [Test]
            public void GivenListWithAllTheSamePositiveValues_HighestForEachLoop_Returns3()
            {
                List<int> nums = new List<int> { 3, 3, 3, 3, 3 };
                Assert.That(LoopTypes.HighestForEachLoop(nums), Is.EqualTo(3));
            }
        }

        [TestFixture]
        public class LowestValues : LoopTests
        {
            [Test]
            public void GivenEmptyList_LowestForEachLoop_Throws()
            {
                List<int> nums = new List<int> { };
                Assert.That(() => LoopTypes.LowestForEachLoop(nums), Throws.TypeOf<ArgumentException>());
            }
            [Test]
            public void GivenListWithTheLowestAtTheBeginning_LowestForEachLoop_ReturnsMinus17()
            {
                List<int> nums = new List<int> { -17, 6, 10, 22, 3 };
                Assert.That(LoopTypes.LowestForEachLoop(nums), Is.EqualTo(-17));
            }

            [Test]
            public void GivenListWithTheLowestAtTheEnd_LowestForEachLoop_ReturnsMinus17()
            {
                List<int> nums = new List<int> { 3, 6, 10, 22, -17 };
                Assert.That(LoopTypes.LowestForEachLoop(nums), Is.EqualTo(-17));
            }

            [Test]
            public void GivenListWithAllNegativeValues_LowestForEachLoop_ReturnsMinus22()
            {
                List<int> nums = new List<int> { -3, -6, -22, -17, -10 };
                Assert.That(LoopTypes.LowestForEachLoop(nums), Is.EqualTo(-22));
            }

            [Test]
            public void GivenListWithAllZeroValues_LowestForEachLoop_Returns0()
            {
                List<int> nums = new List<int> { 0, 0, 0, 0, 0 };
                Assert.That(LoopTypes.LowestForEachLoop(nums), Is.EqualTo(0));
            }

            [Test]
            public void GivenListWithAllTheSamePositiveValues_LowestForEachLoop_Returns3()
            {
                List<int> nums = new List<int> { 3, 3, 3, 3, 3 };
                Assert.That(LoopTypes.LowestForEachLoop(nums), Is.EqualTo(3));
            }
        }
    }
}
