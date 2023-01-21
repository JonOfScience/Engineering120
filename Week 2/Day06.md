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



**DAMP** code:

- **D**escriptive
- **A**nd
- **M**eaningful
- **P**hrases


Remember breakpoints when debugging - Can follow the flow of the program and evolution of variables.


`var` 
- for shorthand. Doesn't break type safety.
- For collections

```csharp 
foreach (var num in numbers){}
```

- Or if you don't know the result type

```csharp
var result = class.someMethod();
```


### Access modifiers
- `private` - within class
- `static` - This method belongs to the class, not to instances of the class

=

### NUnit

- R-click solution
- Add (Explore dependencies)
- New Project



Classic model of assertion is: `Assert.R...`

Constraint model of assertion is: 

```csharp
Assert.That(variableA, Is.EqualTo(VariableB));
```



## Session 2

Tests should be:
- **F** - Fast
- **I** - Independent (of other tests)
- **R** - Repeatable (as is, for other people)
- **S** - Self-validating (no second checks needed)
- **T** - Timely



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



Can use debug breakpoints in tests (run test in debug mode from within Test Explorer) to follow flow and interrogate the value of variables during execution.



```csharp
[TestCase (5, "Good morning!")]
```

Can construct multi-parameter tests

