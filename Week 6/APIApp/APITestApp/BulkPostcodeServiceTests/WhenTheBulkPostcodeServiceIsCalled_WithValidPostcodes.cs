namespace APITestApp.SinglePostcodeServiceTests;

public class WhenTheBulkPostcodeServiceIsCalled_WithValidPostcodes
{
    BulkPostcodeService _bulkPostcodeService;

    [OneTimeSetUp]
    public async Task OneTimeSetupAsync()
    {
        _bulkPostcodeService = new BulkPostcodeService();
        await _bulkPostcodeService.MakesRequestAsync(new string[] { "PR3 0SG", "M45 6GN", "EX165BL" });
    }

    [Test]
    public void StatusIs200_InJsonResponse()
    {
        Assert.That(_bulkPostcodeService.GetStatusCode(), Is.EqualTo(200));
    }

    [Test]
    public void ObjectStatusIs200()
    {
        Assert.That(_bulkPostcodeService.ResponseObject.status, Is.EqualTo(200));
    }

    // With JObject
    [Test]
    public void StatusInResponseHeader_IsSameAsInResponseBody()
    {
        var bodyResponseStatusCode = _bulkPostcodeService.ResponseContent["status"].ToString();
        var bodyResponseStatusCodeInt = Int32.Parse(bodyResponseStatusCode.ToString());
        Assert.That(_bulkPostcodeService.GetStatusCode(), Is.EqualTo(bodyResponseStatusCodeInt));
    }

    [Test]
    public void StatusInResponseHeader_IsSameAsInResponseObject()
    {
        Assert.That(_bulkPostcodeService.GetStatusCode(), Is.EqualTo(_bulkPostcodeService.ResponseObject.status));
    }

    [Test]
    [Category("Error - Missing Data")]
    public void AdminCountyForM456GN_IsNull()
    {
        Assert.That(_bulkPostcodeService.ResponseObject.result[1].result.admin_county, Is.Null);
    }
}