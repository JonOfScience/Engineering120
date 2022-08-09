# Day 31 - 08/08/2022 - Project Presentations & Mocking and Tests

## Mocking and tests

Partial class - you can write the class in two seperate files. At compile time, they're treated like one class

Fast - Run fast
Isolated - No external dependencies
Repeatable - Same results every time
Self-checking - Shouldn't need to check outputs manually
Timely - Write at the same time, quick to write

CRUD Methods - Create, Read? ,Update, Delete

### Databases - Mocking

Fast - DB Queries are slow, especially if the DB isn't local
Isolated - Dependent on code that interacts with the DB
Repeatable - Dependent on the data in the database

#### Using Polymorphism

- Relying on an abstraction (not concrete implementation)
- Using Test Doubles instead of the object itself

https://www.martinfowler.com/bliki/TestDouble.html

Moq framework for mocking objects

Fakes
: In memory databases to test against

#### LUNCH

#### State-Based Testing

State-based testing - what the final state of the system is in after a specified action/s

### Testing Exceptions

```csharp
var mockCustomerService = new Mock<ICustomerService>();
mockCustomerService.Setup(cs => cs.SaveCustomerChanges()).Throws<DataException>();
```

#### Behaviour Based testing (White-Box)

Spy - used in behaviour based testing

**Verify** that the methods expected to be called are being called

```csharp
mockCustomerServer.Verify(cs => cs.SaveCustomerChanges(), Times.Once);
```

Calling the `Update` method in the `CustomerManager` class calls the `SaveCustomerChanges` method once.
(other examples are `Times.Once`, `Times.Exactly(1)`, `Times.AtMostOnce`)

One of the constructors of `Mock` is mock behaviour
Default behaviour is "Loose" behaviour
`MockBehaviour.Strict`
: All methods that are called in the test must be mocked

`MockBehaviour.Loose`
: 

`Strict` behaviour can become brittle

==TEST TOMORROW==

API and Advanced Testing (23 questions) (No coding questions)
- Linq (3)
- Equavalence of a method being inline or out
- Asynchronous programming (5)
- APIs (5 - HTTP requests, Status codes, acronyms)
- RESTsharp (2 questions - What is RESTsharp?)
- Defects (4 questions - What is the definition? Priority and Severity, types of traceability and advantages of each)
- Moq (4 questions - One we just covered (Loose/Strict), Benefits of Moq)
