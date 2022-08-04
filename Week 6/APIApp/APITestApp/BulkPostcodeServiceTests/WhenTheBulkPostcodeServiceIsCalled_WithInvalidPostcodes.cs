namespace APITestApp.SinglePostcodeServiceTests;

// Docs: Bulk Postcode accepts up to 100 codes... what about 101?

public class WhenTheBulkPostcodeServiceIsCalled_WithInvalidPostcodes
{
    BulkPostcodeService _bulkPostcodeService;

    [OneTimeSetUp]
    public async Task OneTimeSetupAsync()
    {
        _bulkPostcodeService = new BulkPostcodeService();
        await _bulkPostcodeService.MakesRequestAsync(new string[] { "dhskjad" });
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

    [Test]
    public void ObjectResultIsNull()
    {
        Assert.That(_bulkPostcodeService.ResponseObject.result[0].result, Is.Null);
    }
}