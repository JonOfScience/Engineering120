# Question Bank

[TOC]

## Week 1
## Week 2
## Week 3
## Week 4

### Efficiency and Recursion
- What is a recursive function?
    - A function that calls itself working down to a base case where it tops
- What is Big-O notation?
    - “A measure of algorithmic complexity”
    - Ignore constants means O(30n) is regarded as the same as O(n)
    - A representation of the worst-case time complexity of an algorithm
- Give an example of an O(n) process. O(1)? O(n squared)?
    - O(n) – Linear search through an array
    - O(1) – Dictionary, a simple operation
    - O(n^2) – A Loop within a loop
- Why are some algorithms considered unreasonable?
    - Because their time requirements are so huge that they could not be calculated in a reasonable amount of time

### General OOP
- What is OOP and why should we use it?
    - Object-Oriented-Programming
    - Modularity for troubleshooting (and testing)
    - Reuse of code through inheritance
    - Flexibility through polymorphism
    - Models the Real-World (problem solving)
- What is the difference between Encapsulation & Abstraction?
    - Encapsulation – Keep implementation details inside (don’t mess with the car’s engine)
    - Abstraction – Rely on an interface rather than having to manipulate methods directly (A car can “drive” we don’t need to know how it does it) 

### Refactoring and Code Smells
- Define the term "Refactoring"
    - Changing the implementation (easier to maintain, easier to read, faster to run) of code without changing it’s behaviour
- When should you refactor your code?
    - If code is hard to understand then you should refactor
    - Red-Green-Refactor
    - https://refactoring.guru/refactoring/when
        - Rule of 3 - "Three strikes and then you refactor", also known as WET "Write Everything Twice"
        - When adding a feature
        - When fixing a bug
        - During a code review
- When should you NOT refactor your code?
    - Just before deadlines
    - When it needs a complete rewrite
- Define the term "Code Smells"
    - Common problematic structures or behaviours in code 
    - “A sign that you should refactor your code”
- Name some Code Smells
    - Data clump, Long method, Shotgun Surgery, Inappropriate Intimacy
- What is a data clump?  How should you refactor your code if you find one?
    - Data clump – Bunches of data that hang around together
    - Solve By:
        - **Extract Class**
        - Preserve Whole Object
        - Introduce Parameter Object
- What is feature envy and what should you do about it?
    - Feature Envy – When a method makes too many calls to other classes to obtain data
    - Solve By:
        - Extract Method
        - Move Method
        - Move Field
- If a class has several methods which contain if/else or switch blocks that test a "type" attribute, what should you do about it?
    - Use polymorphism and make each type a polymorphic object

### Design Patterns
### JSON and XML
- Describe the JSON structure
    - Key-Value pairs, Data focusses
- What C# collection does JSON correspond to?
    - Dictionary
- What data type are the keys in JSON ?
    - Strings
- Describe the XML structure
    - Hierarchical. Between Tags. Have to open and close tags.
- What is the difference between XML and HTML?
    - XML is extensible, HTML has defined tags
- Why are JSON and XML used?
    - JSON – To transfer data – Focussed on content
    - XML – With formatting - Focus on structure

### Files, Logging and Streaming

### SQL

## Week 5
ISTQB

## Week 6
### Lambda Expressions
https://docs.microsoft.com/en-us/ef/ef6/querying/related-data
- How do you load associated objects in a query?
    - `.Include()`
- Why isn’t eager loading enabled by default?
    - *"Eager loading is the process whereby a query for one type of entity also loads related entities as part of the query."*
    - Resources - The time and memory required to load the entire database.
- *"Lazy loading is the process whereby an entity or collection of entities is automatically loaded from the database the first time that a property referring to the entity/entities is accessed."*

https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/delegates-with-named-vs-anonymous-methods
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/delegate-operator
- What is a Lambda expression?  Why is it used in LINQ queries?
    - A *lambda expression* creates an anonymous function (declared in place, cannot be reused, parameter types inferred from context)
    - uses the *lambda declaration operator*: `=>`
    - Expression lambda: has an expression as its body
        ```csharp
        (input-parameters) => expression
        ```
    - Statement lambda: has a statement block as its body.
        ```csharp
        (input-parameters) => { <sequence-of-statements> }
        ```
    - No parameters can be constructed as:
        ```csharp
        () => expression;
        ```
    - See docs for 2 or more parameters
    - They are used in any code that requires delegate types or expression trees. A major use is in LINQ queries.
- What does x => x * x mean?
    - Takes `x` as a parameter and returns `x*x` (x-squared)
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

Bork
- 4 questions HTML, CSS - Basic (syntax to include a style sheet, correct way to make everything tag in red)
    - In the head `<link href="profileStyle.css" rel="stylesheet" />`
- White hat, black hat, grey hat hacking
- ==X== Test automation pyramid
    - Unit (70%), Integration (20%), End-to-End / UI (10%), Manual/Exploratory
- ==X== Why are automated GUI fragile
    - They can fail for a variety of reasons that has nothing specifically to do with the test.
- ==X== What is (device) fragmentation
    - Device vs Platform vs OS all can be different.
    - Cannot just write once and run everywhere
- Where should we focus our scnearios when we are writing automated tests
    - Most used paths
    - Most critical paths with most risk
- ==Element selecting in selenium==
    - HTML Id, CssSelector, linkText, partiallinktext, tagname
- ==Xpath==
    - Works as well as CssSelector but syntax is "complicated and frequently difficult to debug"
- BDD syntax (GWT) (several questions)
    - Given When Then
- What causes SpecFlow tests to fail
    - Apart from bad writing...
    - Server issues, connection issues, undefined steps
- Iterating through SpecFlow table rows
```csharp
public static Dictionary<string, string> ToDictionary(Table table)
        {
            var dictionary = new Dictionary<string, string>();
            foreach (var row in table.Rows)
            {
                dictionary.Add(row[0], row[1]);
            }
            return dictionary;
        }
```
- ==X== Exploratory testing
- What does CI stand for?
- Different types of performance testing

### Test Automation Pyramid and Web Testing
- ==Where do automated GUI tests fit on the test automation pyramid and why?==
    - At the top of the pyramid (but not in the cloud)
- ==Why are automated GUI tests considered flakey?==
    - *"Even with good practices on writing them, end-to-end tests are more prone to non-determinism problems"* - Martin Fowler
    - *"non-deterministic tests - tests that sometimes pass and sometimes fail."* - Martin Folwer
https://martinfowler.com/bliki/TestPyramid.html
https://martinfowler.com/articles/nonDeterminism.html
- What scenarios should be covered with web automation testing?
    - Full user journey (e.g. Login, Add item, Cart, Checkout, Complete)
- ==What is exploratory testing?  What are its advantages?==
    - *"An approach to testing whereby the testers dynamically design and execute tests based on their knowledge, exploration of the test item and the results of previous tests."* - ISTQB Glossary
- ==What is meant by fragmentation?==
    - Device vs. Platform vs. OS
    - *"Fragmentation is the inability to "write once and run anywhere".* —Damith C. Rajapakse (Prof. of Software Engineering, National University of Singapore)

### HTML & CSS
- What is meant by the 'Document Object Model'?
- What is HTML? 
- What is the difference between MTL elements and HTML tags?
- Wy id a tag in HTML?
- What is an anchor tag?
- What is a HTML attribute?
- What is the difference between semantic and non-semantic tags?
- Why should we use IDs?
- What is CSS? 
- What is the CSS box model?
- Where in the HTML document do we link to a CSS file?

### Selenium
- What is the difference between Selenium IDE and Selenium Web Driver?
- How does Selenium cope with different test framework libraries and testing different browsers?
- ==Give some examples of web element selectors.  What is the best?  Least best?==
- ==Why is XPath considered the least useful selector?==

### BDD & SpecFlow
- What does BDD stand for?
- What is the structure of a User Story narrative?
- What is the difference between a SpecFlow feature and a scenario?
- What is the difference between imperative and declarative syntax when writing a Gherkin scenario?
- What is a POM and why is it useful?
- What is SpecFlow for?
- What is Gherkin?

### Performance Testing
- Name 3 types of performance testing.
- Which type of performance testing deals with memory leaks?
- Why would a page have multiple http requests and how can we reduce it?
- What is page weight and how can it be reduced?
- What does Pingdom report on?

### Load & Stress Testing
- What is Load Testing? 
- What is Stress Testing? 
- What is Volume Testing? 
- Why would an organisation want perform load and stress testing on their webpage? 

### Exploratory Testing
- Describe what is meant by exploratory testing 
- Why is ET usually carried out by an experienced tester 
- What are some essential elements to consider with ET 
- How would you start the process of ET 
- How can Heuristics be useful in ET 
- What is the purpose of a Test Charter 
