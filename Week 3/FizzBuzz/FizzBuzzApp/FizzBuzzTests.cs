﻿using System;
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
        [TestCase(1, "1")]
        [TestCase(2, "1 2")]
        [TestCase(5, "1 2 Fizz 4 Buzz")]
        [TestCase(7, "1 2 Fizz 4 Buzz Fizz 7")]
        [TestCase(10, "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz")]
        public void GivenN_Return_TheExpectedString(int n, string expectedResult)
        {
            Assert.That(Program.FizzBuzz(n), Is.EqualTo(expectedResult));
        }

        [TestCase(3, "1 2 Fizz")]
        [TestCase(6, "1 2 Fizz 4 Buzz Fizz")]
        [TestCase(9, "1 2 Fizz 4 Buzz Fizz 7 8 Fizz")]
        [TestCase(12, "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz")]
        public void GivenNDivisibleBy3_Returns_TheExpectedString(int n, string expectedResult)
        {
            Assert.That(Program.FizzBuzz(n), Is.EqualTo(expectedResult));
        }
    }
}
