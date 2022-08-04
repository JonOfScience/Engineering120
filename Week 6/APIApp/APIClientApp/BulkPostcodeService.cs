using RestSharp;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIClientApp
{
    public class BulkPostcodeService
    {
        #region Properties
        // RestSharp object that handles comms with the API
        public RestClient Client { get; set; }
        // Capture the response
        public RestResponse Response { get; set; }
        // capture the response body JSON
        public JObject ResponseContent { get; set; }
        #endregion

        public BulkPostcodeResponse ResponseObject { get; set; }

        public BulkPostcodeService()
        {
            Client = new RestClient(AppConfigReader.BaseUrl);
        }

        public async Task MakesRequestAsync(string[] postcodesIn)
        {
            // set up the request
            var request = new RestRequest();
            request.AddHeader("Content-Type", "application/json");
            request.Method = Method.Post;
            request.Resource = "postcodes/";
            var postcodes = new
            {
                Postcodes = postcodesIn
            };
            request.AddJsonBody(postcodes);

            // Make request
            Response = Client.Execute(request);

            // Parse JSON body to ResponseContent
            ResponseContent = JObject.Parse(Response.Content);

            // An object model of the response
            ResponseObject = JsonConvert.DeserializeObject<BulkPostcodeResponse>(Response.Content);
        }

        public int GetStatusCode()
        {
            return (int)Response.StatusCode;
        }
    }
}
