namespace APITestApp.SinglePostcodeServiceTests;

public class WhenTheOutwardPostcodeServiceIsCalled_WithEmptyOutcode
{
    OutwardPostcodeService _outwardPostcodeService;

    [OneTimeSetUp]
    public async Task OneTimeSetupAsync()
    {
        _outwardPostcodeService = new OutwardPostcodeService();
        await _outwardPostcodeService.MakesRequestAsync("");
    }

    [Test]
    public void StatusIs400_InJsonResponse()
    {
        Assert.That(_outwardPostcodeService.GetStatusCode(), Is.EqualTo(400));
    }

    [Test]
    public void ObjectStatusIs400()
    {
        Assert.That(_outwardPostcodeService.ResponseObject.status, Is.EqualTo(400));
    }

    [Test]
    public void StatusInResponseHeader_IsSameAsInResponseObject()
    {
        Assert.That(_outwardPostcodeService.GetStatusCode(), Is.EqualTo(_outwardPostcodeService.ResponseObject.status));
    }

    [Test]
    [Category("Error - Empty Outcode")]
    public void Error_IsInvalidLongitudeLatitudeSubmitted()
    {
        Assert.That(_outwardPostcodeService.ResponseContent["error"].ToString(), Contains.Substring("Invalid longitude/latitude submitted"));
    }
}