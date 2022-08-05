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
        Assert.That(_singlePostcodeService.Json_Response["status"].ToString(), Is.EqualTo("200"));
    }

    [Test]
    public void ObjectStatusIs200()
    {
        Assert.That(_singlePostcodeService.GetStatus(), Is.EqualTo(200));
    }

    // With JObject
    [Test]
    public void StatusInResponseHeader_IsSameAsInResponseBody()
    {
        Assert.That(_singlePostcodeService.SinglePostcodeDTO.Response.status, Is.EqualTo(_singlePostcodeService.GetStatus()));
    }

    [Test]
    public void Country_IsEngland()
    {
        Assert.That(_singlePostcodeService.GetCountry(), Is.EqualTo("England"));
    }

    [Test]
    public void Region_IsLondon()
    {
        Assert.That(_singlePostcodeService.GetRegion(), Is.EqualTo("London"));
    }

    [Test]
    public void ParliamentaryConstituency_IsCitiesOfLondonAndWestminster()
    {
        Assert.That(_singlePostcodeService.GetConstituency(), Is.EqualTo("Cities of London and Westminster"));
    }

    [Test]
    public void AdminWard_IsBassishaw()
    {
        Assert.That(_singlePostcodeService.GetAdminWard(), Is.EqualTo("Bassishaw"));
    }

    [Test]
    public void NumberOfCodes_IsCorrect()
    {
        Assert.That(_singlePostcodeService.CodeCount(), Is.EqualTo(12));
    }

}