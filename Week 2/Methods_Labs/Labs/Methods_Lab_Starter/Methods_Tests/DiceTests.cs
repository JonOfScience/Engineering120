using NUnit.Framework;
using System;
using Methods_Lib;

namespace Methods_Tests
{
    public class DiceTests
    {
        [Test]
        public void GivenAMillionRolls_RollDice_ReturnsANumberBetween2And12()
        {
            Random rng = new Random();

            //for (int i = 0; i < 1_000_000; i++)
            //{
            //    int result = Methods.RollDice(rng);
            //    Assert.That(result, Is.AtLeast(2));
            //    Assert.That(result, Is.AtMost(12));
            //    //Assert.That(result, Is.InRange(2, 12));
            //}

            int[] nums = new int[1_000_000];
            for (int i = 0; i < 1_000_000; i++)
            {
                nums[i] = Methods.RollDice(rng);
            }
            Assert.That(nums, Is.All.InRange(2, 12));
        }
        [Test]
        public void GivenASeededGenerator_RollDice_ReturnsTheCorrectNumber()
        {
            Random rng = new Random(2);
            int test1 = rng.Next(1, 7);
            int test2 = rng.Next(1, 7);
            
            Random rng2 = new Random(2);
            int result = Methods.RollDice(rng2);
            Assert.That(result, Is.EqualTo(test1 + test2));
        }

    }
}
