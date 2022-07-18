# Day 6 - 04/07/2022 - C#

[TOC]

## Stand Up

"definition of done" can be applied at different levels
- Product
- Sprint

Note: Can include running out of money or hitting the product deadline.



## Session 1

Single responsibility principle



Making testable code -> 



DAMP code:

- Descriptive
- And
- Meaningful
- Phrases


Remember breakpoints when debugging - Can follow the flow of the program and evolution of variables.


var - for shorthand. Don't break type safety
- For collections
- Or if you don't know the result type


### Access modifiers
- `private` - within class
- `static` - This method belongs to the class, not to instances of the class

=

### NUnit

- R-click solution
- Add (Explore dependencies)
- New Project



Classic mode of assertion		Assert.R...

Constraint model of assertion



## Session 2

Tests should be:
- F - Fast
- I - Independent (of other tests)
- R - Repeatable (as is, for other people)
- S - Self-validating (no second checks needed)
- T - Timely



Minimum # of tests - Dependent on ranges/Boundaries/Conditions



*Exhaustive testing is impossible* - (ISTQB Principle)



Defect clustering - Lots of mistakes happen at the boundaries (80/20 rule)



Partitioning and Boundary Value Analysis 

- Tests on either side of the boundaries of partitions (in values)



## Session 3

Parameterised test



```csharp
[TestCase (5)]
[TestCase (8)]
public void Test (int variable)
{
	... (variable)
}
```



Can use debug breakpoints in tests (run test in debug mode from within Test Explorer)



```csharp
[TestCase (5, "Good morning!")]
```

Multi-parameter tests

