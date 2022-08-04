namespace APITestApp.SinglePostcodeServiceTests;

public class WhenTheSinglePostcodeServiceIsCalled_WithInvalidPostcode
{
    SinglePostcodeService _singlePostcodeService;

    [OneTimeSetUp]
    public async Task OneTimeSetupAsync()
    {
        _singlePostcodeService = new SinglePostcodeService();
        await _singlePostcodeService.MakesRequestAsync("hjidss");
    }

    [Test]
    public void StatusIs404_InJsonResponse()
    {
        Assert.That(_singlePostcodeService.GetStatusCode(), Is.EqualTo(404));
    }

    [Test]
    public void ObjectStatusIs404()
    {
        Assert.That(_singlePostcodeService.ResponseObject.status, Is.EqualTo(404));
    }

    // With JObject
    [Test]
    public void StatusInResponseHeader_IsSameAsInResponseBody()
    {
        var bodyResponseStatusCode = _singlePostcodeService.ResponseContent["status"].ToString();
        var bodyResponseStatusCodeInt = Int32.Parse(bodyResponseStatusCode.ToString());
        Assert.That(_singlePostcodeService.GetStatusCode(), Is.EqualTo(bodyResponseStatusCodeInt));
    }

    [Test]
    public void StatusInResponseHeader_IsSameAsInResponseObject()
    {
        Assert.That(_singlePostcodeService.GetStatusCode(), Is.EqualTo(_singlePostcodeService.ResponseObject.status));
    }
}