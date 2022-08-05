using RestSharp;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIClientApp.PostcodesIOService.DataHandling;
using APIClientApp.PostcodesIOService.HTTPManager;

namespace APIClientApp
{
    public enum Resource { POSTCODES, OUTCODES };
    public class SinglePostcodeService
    {

        #region Properties

        public CallManager CallManager { get; set; }
        public JObject Json_Response { get; set; }
        public DTO<SinglePostcodeResponse> SinglePostcodeDTO { get; set; }
        public string PostcodeResponse { get; set; }
        #endregion

        public SinglePostcodeResponse ResponseObject { get; set; }

        public SinglePostcodeService()
        {
            CallManager = new CallManager();
            SinglePostcodeDTO = new DTO<SinglePostcodeResponse>();
        }

        /// <summary>
        /// Defines and makes the API request, and stores the response
        /// </summary>
        /// <param name="postcode"></param>
        /// <returns></returns>

        public async Task MakesRequestAsync(string postcode)
        {
            PostcodeResponse = await CallManager.MakePostcodeRequestAsync(Resource.POSTCODES, postcode);
            Json_Response = JObject.Parse(PostcodeResponse);
            // Use DTO to convert JSON string to object tree
            SinglePostcodeDTO.DeserialiseResponse(PostcodeResponse);
        }

        public int GetStatus()
        {
            return (int)CallManager.Response.StatusCode;
        }

        public int CodeCount()
        {
            return Json_Response["result"]["codes"].Count();
        }
        public string GetAdminWard()
        {
            return Json_Response["result"]["admin_ward"].ToString();
        }

        public string GetCountry()
        {
            return Json_Response["result"]["country"].ToString();
        }

        public string GetConstituency()
        {
            return Json_Response["result"]["parliamentary_constituency"].ToString();
        }

        public string GetRegion()
        {
            return Json_Response["result"]["region"].ToString();
        }
    }
}
