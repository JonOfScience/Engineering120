# Question Bank

## Week 1
## Week 2
## Week 3
## Week 4
## Week 5
## Week 6
### Lambda Expressions
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/delegates-with-named-vs-anonymous-methods
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/delegate-operator
- ENTITY FRAMEWORK: How do you load associated objects in a query?
- ENTITY FRAMEWORK: Why isn’t eager loading enabled by default?
- What is a Lambda expression?  Why is it used in LINQ queries?
    - A declaration of an anonymous function (declared in place, cannot be reused, parameters inferred from context)
    - They are used in LINQ queries as delegate types or expression trees may be used.
- What does x => x * x mean?
    - x goes to x which is multiplied by x
- What is an anonymous method? (C# 2.0)
    - Defined using the delegate keyword
    - Defining an inline function with the option of taking a parameter
- What is Expression body syntax?
    - A body to the right of the => and returns the result of the expression
- When using Lambda statements do NOT need a `return` statement

### Async Programming
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/async-return-types
- Why do we need to use asynchronous methods?
    - API Calls
    - Web requests/services
    - If the outcome of a method is dependent on a service that takes time
    - To improve the execution speed of tasks that can be run in parallel.
- What keywords should an asynchronous method use (and where?)
    - await (in the body)
    - _ _ Task NameWithAsync()
- What return types are allowed for asynchronous methods?
    - Task, Task<T>, void (event handler), object (with GetAwaiter), IAsyncEnumerable<T> (returns an Async stream)
- What effect does the await keyword have?
    - Waits for a task to be complete
    - Returns to the caller method while waiting
- What is the naming convention for asynchronous methods?
    - ____Async() in the method name
    - Use of async and await keywords
 

### Serialisation
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/
- What is serialisation?
    - Converting an object into a stream of bytes to store the object or transmit it to a database, memory or a file
- What are the advantages and disadvantages of using binary object serialisation? JSON Serialisation? / XML Serialisation?
    - Binary – Fast and compact for use in storage and socket-based network streams. BinaryFormatter cannot be secured and shouldn’t be used for trusted data.
    - XML – Human Readable - 
    - JSON – Human Readable - 

### API and REST
- What does API stand for?
    - Application Programming Interface
- What are the HTTP verbs and what are their CRUD equivalents?
    - POST - Create
    - GET - Read
    - PUT - Update
    - DELETE - Delete
- What is the structure of an HTTP request?  An HTTP response?
    - Request: request line, headers, empty line, body (optional)
    - Response: status code, headers, empty line, body (optional)
- What are the categories of HTTP response status code?
- https://developer.mozilla.org/en-US/docs/Web/HTTP/Status
    - 1xx – Informational responses
    - 2xx – Successful responses
    - 3xx – Redirection messages
    - 4xx – Client error responses
    - 5xx – Server error responses
- What does REST stand for in the context of RESTful APIs?
    - REpresentational State Transfer
- What are the characteristics of a REST API?
    - Stateless – Client and Server understand messages without needing to know about previous messages
    - Separation of Client and Server – Only the message structure matters, client and server can be set up or changed independently of each other.
    - Specifies resource using URI
- For the endpoint myapi.com/api/customers what would you expect a GET request to do?  A POST request?  PUT? DELETE?
    - GET – List of customers or a specific customer
    - POST – Create a new customer/customers
    - PUT – Update customer information
    - DELETE – Remove a customer from the database
- What do we mean by caching?
    - Local storage of query items so they can be used quickly and without having to send extra requests for them
- What should the RESTful endpoint myresource.io/Employees/6/Order/2 GET?
    - Employee Id 6 with order Id 2
- Give some examples of header elements that can be used to control caching
    - max-age, no-cache, no-store

### RestSharp
- What does the RestSharp library do?
    - HTTP REST API client library for .NET
    - Automatic serialization/deserialization
    - Request and response type detection
    - Authentication and other features
- What does a testhosts.dll.config file do?  Why is it useful?
    - Loads settings for the app using ConfigurationManager
- Why did we create separate data handling and call manager folders in our Restsharp test framework?
    - Separate API calls from the serialisation/deserialisation code

### Test Doubles using Fakes and Moq
- What are the 5 types of test doubles?
    - Dummy, Fake, Stubs, Spies, Mocks
- What does a Fake do?
    - Implemented but with shortcuts
- Why should you use an in-memory database for testing?
    - In-Memory means it is controllable and fast
    - Testing against a real database replicates the actual functionality related to the test (either as an environment or as the object under test)
- Why should you use the Moq framework for testing?
        - Can isolate a class under test by mocking its dependencies and verifying its calls
- DID WE?: Why did we refactor our WPF-EF system to use a Service class?
- How does Dependency injection aid unit testing?
    - We can use doubles for dependencies far more easily
- When would we want to use a dummy?
    - To fill a parameter list
    - A dummy is an object that is passed around but never used
- What does a Stub do?
    - Provides canned answers to expected calls.
    - No responses to anything outside the test
- How can we use a Moq to check if a method is called with the correct parameters?
- What is the difference between strict and loose mocking behaviour?
    - Loose mocks don’t have to implement every method on an object. Strict mocks do.
- What is returned if a method is not set up (loose)
    - Doesn’t throw exceptions
    - Returns default values (pr empty arrays, enumerables, etc.)
- What is returned if a method is not set up (strict)
    - Throws exception


### Requirements Traceability Matrix (RTM)
- Forward – Maps requirements to test cases
    - Confirms – Test coverage for requirements, Project trajectory
- Backward – Maps test cases to requirements
    - Avoids – Scope Creep
- Bi-Directional Traceability – Both of the above in a single document
    - Establishes each requirement has relating test cases

## Week 7
