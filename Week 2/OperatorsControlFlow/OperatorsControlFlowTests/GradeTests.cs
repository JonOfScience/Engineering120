using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ControlFlowApp;

namespace OperatorsControlFlowTests
{
    internal class GradeTests
    {
        [TestCase(-1)]
        public void GivenASub0Mark_Grade_Throws(int mark)
        {
            Assert.That(() => Program.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [TestCase(19, "Failed no retake")]
        public void GivenASub20Mark_Grade_ReturnsAFailWithNoRetake(int mark, string expectedResult)
        {
            Assert.That(Program.Grade(mark), Is.EqualTo(expectedResult));
        }

        [TestCase(20, "Fail with retake")]
        [TestCase(64, "Fail with retake")]
        public void GivenASubMarkBetween20And64_Grade_ReturnsAFailWithRetake(int mark, string expectedResult)
        {
            Assert.That(Program.Grade(mark), Is.EqualTo(expectedResult));
        }

        [TestCase(65, "Pass")]
        [TestCase(84, "Pass")]
        public void GivenASubMarkBetween64And84_Grade_ReturnsAPass(int mark, string expectedResult)
        {
            Assert.That(Program.Grade(mark), Is.EqualTo(expectedResult));
        }

        [TestCase(85, "Distinction")]
        public void GivenAMarkAbove85_Grade_ReturnsADistinction(int mark, string expectedResult)
        {
            Assert.That(Program.Grade(mark), Is.EqualTo(expectedResult));
        }
    }
}
