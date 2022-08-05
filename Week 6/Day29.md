# Day 29 - 04/08/2022 - 

[TOC]

Error Model handling
- Either incoporate into the normal object (so errors will be parsed into it)
- Or just Parse into a JObject and query that

Test Coverage
- Remember to test headers

Creating Helper Methods
- Makes it easier for an SDET who is *not* developing the framework to test.

Include in Mini-Project
- How to extend it, how to add another service class

Generic classes and methods are more flexible
- Rather than having to create a class/method for every type of object

## API Test Strategy

Why API Test
- May be used in other products or by the public or both
- Reliability is crucial
- Manual testers can automate calls through Postman

Testing APIs
- API Code - should be covered by unit tests
- We are interested in end-to-end performance (given a request, what is the response) (black box)
- Does the API request / response structure fulfill the requirements /

What to Test
- Correct status codes
- Correct response header
- Correct response body
- JSON is valid
- Reasonable response time
- Non-functional tests
    - Security and authorisation
    - Performance - Load and Stress tests
    - Usability - API plus documentation including code examples

Happy Path - valid input, correct output
- Valid parameters

Unhappy Path - valid input
Unhappy Path - invalid input
Destructive Testing
