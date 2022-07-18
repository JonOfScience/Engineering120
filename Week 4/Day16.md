# Day 16 - 18/07/2022

[TOC]

## Advanced NUnit - Attributes

- Things in square bracket (https://docs.nunit.org/articles/nunit/writing-tests/attributes.html)

### `[TestFixture]`
- Put it in front of a class
- There are more complex things we can do with `TestFixture` 

### `[OneTimeSetup]`
- Once when it runs the class it runs `OneTimeSetup`

### `[Setup]`
- Runs before each test

### `[TearDown]`
- Run at the end of each test

### `[OneTimeTearDown]`
- Run once at the end of all tests

QUESTION: Priority of execution for `OneTimeSetup`, `Setup`, `TearDown`, `OneTimeTearDown`?

- We don't know the run order of tests (https://docs.nunit.org/articles/nunit/writing-tests/attributes/order.html)
- So they must be **I**solated
- The result of one must NOT depend on another

A constructor may interfere with execution order
- So use `SetUp` etc. to ensure clean test runs

### `[Ignore]`
- Tells the test runner to ignore the following test(s) e.g.,
```csharp
[TestFixture]
[Ignore("Reason for ignoring tests")]
public class CounterTests
{
 
}
```

If there is a SetUp run by some tests but not all... create as separate method and then just call in each test that actually uses it

## Characteristics of a Good Test

According to Microsoft (https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices#characteristics-of-a-good-unit-test)

## FIRST @ 1205

### F- Fast
- Tests run within a few miliseconds (ideally)

### I - Isolated
- There should be no interaction between tests
- Stand-alone, no dependencies (e.g. on a file existing in a file system)
- Isolate data as well as functionality

### R - Repeatable
- Should produce the same result every time. No matter who runs it.

### S - Self-validating
- Don't need to check results manually
- The test informs of the Pass/Fail case

### T - Timely / Thorough
Timely
- The test doesn't take a long time to write
- Not overly complex
- Otherwise code may be too complex and may need refactoring

Thorough
- Covers edge cases, etc.

## Naming

Class names should be descriptive
Tests should be cohesive
Each method should describe its intent
Structure of testing and naming is dependent on the organisation you are working for

### `[Category("Test Type")]`

Can choose how to group in Test Explorer (Click on "Group By", then select "Traits")
For example ("Happy Path", "Sad Path", "Alternative Path")


https://www.youtube.com/watch?v=B2o2YFq6C2Y

Set up a test, and test in calculator - Test for division - Happy path, Error (sad) path (division by zero)

### `[TestCaseSource]`

`[TestCase]` to `[TestCaseSource("NameOfSourceObject")]'

then
```csharp
private static object[] AddCases = 
{
    new int[] {2, 4, 6},
    new int[] {-2, 4, 2}
};
```
Takes each int array and then passes it to the test function.

Can pass in objects.

Make sure parameter list in the `TestCaseSource` matches the function. (Positional arguments)

HINT: USE THESE FOR THE SORT MANAGER PROJECT
HINT: Implement these in future projects rather than just `.EqualsTo()`

## Test Driven Development

Unit testing
- Test every branch of your code
- Tests will act as documentation for your code
- Forces you to adopt good coding practices

The Test Automation Pyramid

When taking over a project
- Run all the existing tests
- Set up all of the other tests first before trying to change anything

Red, Green, Refactor
- Don't work any harder than you need to at each stage

https://docs.nunit.org/articles/vs-test-adapter/Index.html

- Write test
- Write just enough code (including hardcoding) to get it to pass
- Add second test
- Add to code to pass both tests
- (refactor)
- Add third test
- ...
