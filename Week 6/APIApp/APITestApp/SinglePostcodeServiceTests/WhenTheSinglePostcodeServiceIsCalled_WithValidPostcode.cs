namespace APITestApp.SinglePostcodeServiceTests;
// Docs: Single Postcode Query returns 100 entries?
public class WhenTheSinglePostcodeServiceIsCalled_WithValidPostcode
{
    SinglePostcodeService _singlePostcodeService;

    [OneTimeSetUp]
    public async Task OneTimeSetupAsync()
    {
        _singlePostcodeService = new SinglePostcodeService();
        await _singlePostcodeService.MakesRequestAsync("EC2Y 5AS");
    }

    [Test]
    public void StatusIs200_InJsonResponse()
    {
        Assert.That(_singlePostcodeService.GetStatusCode(), Is.EqualTo(200));
    }

    [Test]
    public void ObjectStatusIs200()
    {
        Assert.That(_singlePostcodeService.ResponseObject.status, Is.EqualTo(200));
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

    [Test]
    public void Country_IsEngland()
    {
        Assert.That(_singlePostcodeService.ResponseObject.result.country, Is.EqualTo("England"));
    }

    [Test]
    public void Region_IsLondon()
    {
        Assert.That(_singlePostcodeService.ResponseObject.result.region, Is.EqualTo("London"));
    }

    [Test]
    public void ParliamentaryConstituency_IsCitiesOfLondonAndWestminster()
    {
        Assert.That(_singlePostcodeService.ResponseObject.result.parliamentary_constituency, Is.EqualTo("Cities of London and Westminster"));
    }

    [Test]
    public void AdminWard_IsBassishaw()
    {
        Assert.That(_singlePostcodeService.ResponseObject.result.admin_ward, Is.EqualTo("Bassishaw"));
    }

}