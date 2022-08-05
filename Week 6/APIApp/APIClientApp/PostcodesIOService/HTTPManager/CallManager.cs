using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIClientApp.PostcodesIOService.HTTPManager
{
    public class CallManager
    {
        #region Properties
        private readonly RestClient _client;
        public RestResponse Response { get; set; }
        #endregion

        public CallManager()
        {
            _client = new RestClient(AppConfigReader.BaseUrl);
        }

        public async Task<string> MakePostcodeRequestAsync(Resource resource, string postcode)
        {
            //set up a request
            var request = new RestRequest();
            request.AddHeader("Content-Type", "application/json");
            switch (resource)
            {
                case Resource.POSTCODES:
                    request.Resource = $"postcode/{postcode.ToLower().Replace(" ", "")}";
                    break;
                default:
                    throw new ArgumentException();
            }
            //executing request
            Response = await _client.ExecuteAsync(request);
            return Response.Content;
        }
    }
}
