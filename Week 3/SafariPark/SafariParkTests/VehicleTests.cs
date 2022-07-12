using SafariParkApp;

namespace SafariParkTests
{
    internal class VehicleTests
    {
        //  Required tests
        [Test]
        public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
        {
            Vehicle v = new Vehicle();
            var result = v.Move(2);
            Assert.AreEqual(20, v.Position);
            Assert.AreEqual("Moving along 2 times", result);
        }
        [Test]
        public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
        {
            Vehicle v = new Vehicle(5, 40);
            var result = v.Move();
            Assert.AreEqual(40, v.Position);
            Assert.AreEqual("Moving along", result);
        }

        // Extended tests
        [TestCase(-1)]
        [TestCase(1)]
        public void GivenADefaultVehicle_WhenPassengersAreAdded_ItThrows(int numPassengers)
        {
            Vehicle v = new Vehicle();
            Assert.That(() => v.NumPassengers = numPassengers, Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void GivenANegativeCapacity_Vehicle_Throws()
        {
            Assert.That(() => new Vehicle(-1), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void GivenAVehicleWithACapacityOf2_WhenAPassengersAreAdded_ItAccepts(int numPassengers)
        {
            Vehicle v = new Vehicle(2);
            v.NumPassengers = numPassengers;
            Assert.That(v.NumPassengers, Is.EqualTo(numPassengers));
        }

        [TestCase(-10, -10)]
        [TestCase(-1, -1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(10, 10)]
        public void GivenAVehicleWithACapacityAndASpeed_Move_ReturnsExpectedAnswers(int speed, int expectedResult)
        {
            Vehicle v = new Vehicle(1, speed);
            v.Move();
            Assert.That(v.Position, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GivenAVehicleWithACapacityAndASpeed_MoveNegativeTimes_Throws()
        {
            Vehicle v = new Vehicle(1);
            Assert.That(() => v.Move(-1), Throws.InstanceOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void GivenAVehicleWithACapacityAndASpeed_MoveZeroTimes_DoesntMove()
        {
            Vehicle v = new Vehicle(1);
            v.Move(0);
            Assert.That(v.Position, Is.EqualTo(0));
        }

        [TestCase(-10, 2, -20)]
        [TestCase(-1, 2, -2)]
        [TestCase(0, 2, 0)]
        [TestCase(1, 2, 2)]
        [TestCase(10, 2, 20)]
        public void GivenAVehicleWithACapacityAndASpeed_MoveNTimes_ReturnsExpectedAnswers(int speed, int times, int expectedResult)
        {
            Vehicle v = new Vehicle(1, speed);
            v.Move(times);
            Assert.That(v.Position, Is.EqualTo(expectedResult));
        }
    }
}

