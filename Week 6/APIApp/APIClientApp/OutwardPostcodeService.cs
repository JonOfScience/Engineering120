﻿using RestSharp;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIClientApp;

public class OutwardPostcodeService
{
    #region Properties
    // RestSharp object that handles comms with the API
    public RestClient Client { get; set; }
    // Capture the response
    public RestResponse Response { get; set; }
    // capture the response body JSON
    public JObject ResponseContent { get; set; }
    #endregion

    public OutcodeResponse ResponseObject { get; set; }

    public OutwardPostcodeService()
    {
        Client = new RestClient(AppConfigReader.BaseUrl);
    }

    public async Task MakesRequestAsync(string outcode)
    {
        // set up the request
        var request = new RestRequest();
        request.AddHeader("Content-Type", "application/json");
        request.Resource = $"outcodes/{outcode.ToLower().Replace(" ", "")}";

        // Make request
        Response = await Client.ExecuteAsync(request);

        // Parse JSON body to ResponseContent
        ResponseContent = JObject.Parse(Response.Content);

        // An object model of the response
        ResponseObject = JsonConvert.DeserializeObject<OutcodeResponse>(Response.Content);
    }

    public int GetStatusCode()
    {
        return (int)Response.StatusCode;
    }
}
