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

        [TestCase(19)]
        public void GivenASub20Mark_Grade_ReturnsAFailWithNoRetake(int mark)
        {
            Assert.That(Program.Grade(mark), Is.EqualTo("Failed no retake"));
        }

        [TestCase(20)]
        [TestCase(64)]
        public void GivenASubMarkBetween20And64_Grade_ReturnsAFailWithRetake(int mark)
        {
            Assert.That(Program.Grade(mark), Is.EqualTo("Fail with retake"));
        }

        [TestCase(65)]
        [TestCase(84)]
        public void GivenASubMarkBetween64And84_Grade_ReturnsAPass(int mark)
        {
            Assert.That(Program.Grade(mark), Is.EqualTo("Pass"));
        }

        [TestCase(85)]
        public void GivenAMarkAbove85_Grade_ReturnsADistinction(int mark)
        {
            Assert.That(Program.Grade(mark), Is.EqualTo("Distinction"));
        }
    }
}
