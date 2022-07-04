﻿using CodeToTest;

namespace UnitTests
{
    public class Classification_Tests
    {
        //Original Requirements Tests
        //[TestCase(11, "U, PG & 12 films are available.")]
        //[TestCase(12, "U, PG, 12 & 15 films are available.")]
        //[TestCase(14, "U, PG, 12 & 15 films are available.")]
        //[TestCase(18, "All films are available.")]
        //public void GivenAnAge_AvailableClassifications_ReturnsAnExpectedResult(int age, string expectedResult)
        //{
        //    Assert.That(Program.AvailableClassifications(age), Is.EqualTo(expectedResult));
        //}

        //BBFC Requirements Tests
        // U & PG for all
        // 12A (at the cinema) and 12 (on video) for over 12s
        // 15 for over 15s
        // All for 18s
        //[TestCase(11, "U, PG & 12A (Cinema) films are available.")]
        //[TestCase(12, "U, PG, 12A & 12 films are available.")]
        //[TestCase(14, "U, PG, 12A & 12 films are available.")]
        //[TestCase(15, "U, PG, 12A, 12 & 15 films are available.")]
        //[TestCase(18, "All films are available.")]
        //public void GivenAnAge_AvailableClassifications_ReturnsAnExpectedResult(int age, string expectedResult)
        //{
        //    Assert.That(Program.AvailableClassifications(age), Is.EqualTo(expectedResult));
        //}

        //Tests including BBFC Requirements and Boundaries
        // 0-11  - U, PG & 12A (Cinema)
        // 12-14 - U, PG, 12A & 12
        // 15-17 - U, PG, 12A, 12, 15
        // 18+   - All films
        [TestCase(0, "U, PG & 12A (Cinema) films are available.")]
        [TestCase(11, "U, PG & 12A (Cinema) films are available.")]
        [TestCase(12, "U, PG, 12A & 12 films are available.")]
        [TestCase(14, "U, PG, 12A & 12 films are available.")]
        [TestCase(15, "U, PG, 12A, 12 & 15 films are available.")]
        [TestCase(17, "U, PG, 12A, 12 & 15 films are available.")]
        [TestCase(18, "All films are available.")]
        public void GivenAnAge_AvailableClassifications_ReturnsAnExpectedResult(int age, string expectedResult)
        {
            Assert.That(Program.AvailableClassifications(age), Is.EqualTo(expectedResult));
        }

    }
}
