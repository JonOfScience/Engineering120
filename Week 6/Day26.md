# Day 26 - 01/08/2022

https://www.geeksforgeeks.org/advantages-and-disadvantages-of-test-driven-development-tdd/

## Lambdas

https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions

- Have no name
- Is declared in the place where it is used
- Cannot be reused anywhere else
- The types of parameters are inferred from context

Query results are `IEnumerable`
Query syntax vs. Method Syntax
We will mostly use Method Syntax

`.Count()` expects a method that returns a bool
`.Sum()` expects a method that returns a number
`.Where()` expects a method that returns a bool
`.OrderBy()` expects a method that returns a key

Can use a `delegate` keyword to define an anonymous function

A Linq method can take a method as an argument
- We don't use anonymous methods
- We use Lambda expressions

[==CHECK "Range Variables", Expression Body Lambdas==]

Queries are executed when they are iterated over/called
- Deferred query execution
- Command tree is created when we create a Linq query
- Command tree is executed when it is iterated over
- If we use `.Count()` or other method this forces the query to execute.

[==CHECK `.FirstOrDefault()`==]

Methods with only one line can be written with lambdas to prevent having to write them over 3-4 lines.


