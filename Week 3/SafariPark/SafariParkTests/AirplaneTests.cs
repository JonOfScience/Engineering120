using SafariParkApp;

namespace SafariParkTests;

internal class AirplaneTests
{
    // TODO: Split tests
    [TestCase (500, 500)]
    public void GivenANewAirplane_Ascending_SetsAltitude(int distance, int expectedResult)
    {
        var aPlane = new Airplane(200);
        aPlane.Ascend(distance);
        Assert.That(aPlane.Altitude, Is.EqualTo(expectedResult));
    }

    [Test]
    public void GivenAnAirplaneAt500M_Move_ReturnsExpectedResult()
    {
        var aPlane = new Airplane(200);
        aPlane.Ascend(500);
        Assert.That(aPlane.Move(), Is.EqualTo("Moving along at an altitude of 500 metres."));
    }

    [TestCase(3, "Moving along 3 times at an altitude of 500 metres.")]
    public void GivenAnAirplaneAt500M_MoveNTimes_ReturnsExpectedResult(int times, string expectedResult)
    {
        var aPlane = new Airplane(200);
        aPlane.Ascend(500);
        Assert.That(aPlane.Move(times), Is.EqualTo(expectedResult));
    }

    [TestCase (500, "Thank you for flying JetsRUs: SafariParkApp.Airplane capacity: 200 passengers: 150 speed: 100 position: 0 altitude: 500.")]
    public void GivenAnAirplaneAtAltitude_ToString_ReturnsExpectedResult(int altitude, string expectedResult)
    {
        var aPlane = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
        aPlane.Ascend(altitude);
        Assert.That(aPlane.ToString(), Is.EqualTo(expectedResult));
    }

    [TestCase (500, 200, 300)]
    public void GivenAnAirplaneAtAltitude_Descending_SetsAltitude(int initialAltitude, int descendBy, int finalAltitude)
    {
        var aPlane = new Airplane(200);
        aPlane.Ascend(initialAltitude);
        aPlane.Descend(descendBy);
        Assert.That(aPlane.Altitude, Is.EqualTo(finalAltitude));
    }

    [TestCase(500, 200, "Thank you for flying JetsRUs: SafariParkApp.Airplane capacity: 200 passengers: 150 speed: 100 position: 0 altitude: 300.")]
    public void GivenAnAirplaneThatBothAscendsAndDesceds_ToString_ReturnsExpectedResult(int ascendBy, int descendBy, string expectedResult)
    {
        var aPlane = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
        aPlane.Ascend(ascendBy);
        aPlane.Descend(descendBy);
        Assert.That(aPlane.ToString(), Is.EqualTo(expectedResult));
    }

    [Test]
    public void GivenANewAirplane_AscendingANegativeDistance_Throws()
    {
        var aPlane = new Airplane(200);
        Assert.That(() => aPlane.Ascend(-1), Throws.TypeOf<ArgumentException>());
    }

    [Test]
    public void GivenAnAirplaneAtAltitude_AscendingANegativeDistanceGreaterThanItsAltitude_Throws()
    {
        var aPlane = new Airplane(200);
        aPlane.Ascend(100);
        Assert.That(() => aPlane.Ascend(-150), Throws.TypeOf<ArgumentException>());
    }
}
