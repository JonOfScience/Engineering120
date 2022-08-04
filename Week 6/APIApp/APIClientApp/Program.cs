using RestSharp;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace APIClientApp;

internal class Program
{
    static async Task Main(string[] args)
    {
        //// Encapsulate the information we need to make the API call
        //// We can make authenticated HTTP requests
        //var restClient = new RestClient("https://api.postcodes.io/");
        //// Set up request. Create a request object.
        //var restRequest = new RestRequest();
        //// This is already included as the default method CAN ALSO be added to new RestRequest
        //restRequest.Method = Method.Get;
        //// This is already included as the content type is inferred
        //restRequest.AddHeader("Content-Type", "application/json");
        //var postCode = "EC2Y 5AS";
        //restRequest.Resource = $"/postcodes/{postCode.ToLower().Replace(" ", "")}";
        //// Execute our request
        //var singlePostcodeResponse = await restClient.ExecuteAsync(restRequest);

        //Console.WriteLine("Response content (string)");
        //Console.WriteLine(singlePostcodeResponse.Content);
        //Console.WriteLine("Response code (enum)");
        //Console.WriteLine(singlePostcodeResponse.StatusCode);
        //Console.WriteLine("Response code (int)");
        //Console.WriteLine((int)singlePostcodeResponse.StatusCode);

        //foreach (var item in singlePostcodeResponse.Headers)
        //{
        //    Console.WriteLine(item);
        //}

        //var responseContentType = singlePostcodeResponse.Headers.Where(x => x.Name == "Date")
        //    .Select(h => h.Value.ToString()).FirstOrDefault();
        //Console.WriteLine(responseContentType);
        //var singlePostcodeJSonResponse = JObject.Parse(singlePostcodeResponse.Content);
        //// Console.WriteLine(singlePostcodeResponse);
        //var adminDistrict = singlePostcodeJSonResponse["result"]["admin_district"];
        //Console.WriteLine(adminDistrict);
        //var client = new RestClient();
        //var request = new RestRequest("https://api.postcodes.io/postcodes/", Method.Post);
        //request.AddHeader("Content-Type", "application/json");
        //// request.AddStringBody("{\r\n\"postcodes\" : [\"OX49 5NU\", \"M32 0JG\", \"NE30 1DP\"]\r\n}\r\n", DataFormat.Json);
        //var postcodes = new
        //{
        //    Postcodes = new string[] { "PR3 0SG", "M45 6GN", "EX165BL" }
        //};
        //request.AddJsonBody(postcodes);
        //RestResponse bulkPostcodeResponse = client.Execute(request);
        //Console.WriteLine(bulkPostcodeResponse.Content);

        // Repeat but with Bulk Postcode response
        // Interrogate the JObject (like we've done above)
        // var bulkPostcodeJSonResponse = JObject.Parse(bulkPostcodeResponse.Content);
        // Console.WriteLine(bulkPostcodeJSonResponse);
        //foreach (var result in bulkPostcodeJSonResponse["result"])
        //{
        //    Console.WriteLine(result["result"]["admin_district"]);
        //}

        // A zero-indexed array of results 
        //Console.WriteLine($"Result {bulkPostcodeJSonResponse["result"][1]["result"]["codes"]["admin_county"]}");
        //var singlePostcodeObjectResponse = JsonConvert.DeserializeObject<SinglePostcodeResponse>(singlePostcodeResponse.Content);
        //var bulkPostcodeObjectResponse = JsonConvert.DeserializeObject<BulkPostcodeResponse>(bulkPostcodeResponse.Content);
        //Console.WriteLine("Bulk postcode response:\n");
        //foreach (var p in bulkPostcodeObjectResponse.result)
        //{
        //    Console.WriteLine(p.query);
        //    Console.WriteLine($"{p.result.admin_ward}\n");
        //}
        //var selectedAdminCounty = bulkPostcodeObjectResponse.result.Where(q => q.query == "PR3 0SG")
        //    .FirstOrDefault().result.codes.admin_county;
        //Console.WriteLine(selectedAdminCounty);
        //var selectedAdminCountyAlt = bulkPostcodeObjectResponse.result[0].result.codes.admin_county;
        //Console.WriteLine(selectedAdminCountyAlt);

        //string outcode = "PR3";
        //var clientOutcode = new RestClient();
        //var requestOutcode = new RestRequest($"https://api.postcodes.io/outcodes/{outcode.ToLower()}");
        //requestOutcode.AddHeader("Content-Type", "application/json");
        //RestResponse singleOutcodeResponse = clientOutcode.Execute(requestOutcode);
        //// Console.WriteLine(singleOutcodeResponse.Content);

        //// Recursively unpack and display in a tree style view
        //var singleOutcodeJSonResponse = JObject.Parse(singleOutcodeResponse.Content);

        //var outcodeObjectResponse = JsonConvert.DeserializeObject<OutcodeResponse>(singleOutcodeResponse.Content);
        ////Console.WriteLine($"Admin wards in {outcode}:\n******************");
        ////foreach (var p in outcodeObjectResponse.result.admin_ward)
        ////{
        ////    Console.WriteLine($"{p}");
        ////}

        //Detree(singleOutcodeJSonResponse["result"]);

    }

    //public static void Detree(JObject objectTree, int depth = 0)
    //{
    //    var properties = objectTree.Properties();
    //    foreach (var p in properties)
    //    {
    //        Console.WriteLine(p.Name.PadLeft(depth + p.Name.Length));
    //    }
    //    foreach (var k in objectTree.Children())
    //    {
    //        Detree(k, depth + 1);
    //    }
    //}

    public static void Detree(JToken objectTree, int depth = 0)
    {
        bool isData = false;
        switch (objectTree.Type)
        {
            case JTokenType.Array:
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
            case JTokenType.Property:
                Console.ForegroundColor = ConsoleColor.Green;
                break;
            case JTokenType.String:
                Console.ForegroundColor = ConsoleColor.White;
                isData = true;
                break;
            default:
                Console.ForegroundColor = ConsoleColor.White;
                break;
        }
        Console.Write(objectTree.Type.ToString().PadLeft(depth + objectTree.Type.ToString().Length));
        Console.ForegroundColor = ConsoleColor.White;
        if (isData)
            Console.WriteLine(" - " + objectTree.ToString());
        else
            Console.WriteLine(" - " + objectTree.Path);
        foreach (var k in objectTree.Children<JToken>())
        {
            Detree(k, depth + 1);
        }
    }
}