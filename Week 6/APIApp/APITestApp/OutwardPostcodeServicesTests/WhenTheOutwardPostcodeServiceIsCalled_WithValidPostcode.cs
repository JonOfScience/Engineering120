namespace APITestApp.SinglePostcodeServiceTests;

public class WhenTheOutwardPostcodeServiceIsCalled_WithValidPostcode
{
    OutwardPostcodeService _outwardPostcodeService;

    [OneTimeSetUp]
    public async Task OneTimeSetupAsync()
    {
        _outwardPostcodeService = new OutwardPostcodeService();
        await _outwardPostcodeService.MakesRequestAsync("PR3");
    }

    [Test]
    public void StatusIs200_InJsonResponse()
    {
        Assert.That(_outwardPostcodeService.GetStatusCode(), Is.EqualTo(200));
    }

    [Test]
    public void ObjectStatusIs200()
    {
        Assert.That(_outwardPostcodeService.ResponseObject.status, Is.EqualTo(200));
    }

    // With JObject
    [Test]
    public void StatusInResponseHeader_IsSameAsInResponseBody()
    {
        var bodyResponseStatusCode = _outwardPostcodeService.ResponseContent["status"].ToString();
        var bodyResponseStatusCodeInt = Int32.Parse(bodyResponseStatusCode.ToString());
        Assert.That(_outwardPostcodeService.GetStatusCode(), Is.EqualTo(bodyResponseStatusCodeInt));
    }

    [Test]
    public void StatusInResponseHeader_IsSameAsInResponseObject()
    {
        Assert.That(_outwardPostcodeService.GetStatusCode(), Is.EqualTo(_outwardPostcodeService.ResponseObject.status));
    }
}