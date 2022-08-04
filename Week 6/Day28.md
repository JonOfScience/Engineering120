# Day 28 - 03/08/2022 - RESTsharp

[TOC]

Request Headers
- Extra instructions about how to interpret the request

Repose Header
- Tells us about the response

## RestSharp & API Testing

API Client
: Program that makes an API request and interprets the response

RestSharp
: Library (popular), HTTPClient (MS version)

http://restsharp.dev

### Headers

Read only collection

### Responses
Responses are strings
- Can convert response to a JObject
- Can convert response to a C# object

https://www.newtonsoft.com/json/help/html/t_newtonsoft_json_linq_jobject.htm
https://www.newtonsoft.com/json/help/html/queryinglinqtojson.htm


==Can use a Response to generate classes: Paste Special -> Paste JSON as Classes==

```csharp
[JsonProperty("status")]
public int Status { get; set; }
``` 
tells it to map the JSON key "status" to the C# property "Status"

#### TASK
Read the documentation for the postcodes.io Lookup Outward Code GET request. Try it out in Postman

Modify your program to create a Lookup Outward Code request, and store the response as
- a Newtonsoft JObject
- one or more deserialised C# objects.

You will need to map several new classes to represent the response.

