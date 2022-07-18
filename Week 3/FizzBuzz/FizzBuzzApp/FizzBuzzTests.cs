using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace FizzBuzzApp
{
    public class FizzBuzzTests
    {
        // 1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz
        [Test]
        public void GivenOne_Return_OneString()
        {
            Assert.That(Program.FizzBuzz(1), Is.EqualTo("1"));
        }

        [Test]
        public void GivenTwo_Return_TwoString()
        {
            Assert.That(Program.FizzBuzz(2), Is.EqualTo("1 2"));
        }

        [Test]
        public void GivenThree_Return_OneTwoFizzString()
        {
            Assert.That(Program.FizzBuzz(3), Is.EqualTo("1 2 Fizz"));
        }

    }
}
