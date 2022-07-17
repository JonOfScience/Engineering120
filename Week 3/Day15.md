# Day 15 - 2022/07/15

[TOC]

## Stand-Up

- Linked lists don't implement IList (so not have an index)
- Normal lists can get fragmented in memory (if in non-contiguous blocks)
- Linked lists are linked by reference
- Liskov how to do interfaces and implement polymorphism correctly

- IEnumerable is a query, has only one method, needs to be iterated through (or `.ToList()`) to return the actual object.

## Session 1 - Collections Part 2

### Queues (FIFO)

### Stack (LIFO)

- `.Push()` items on the stack
- `.Pop()` items off of the stack
- `.Peek()` at the top item on the stack

### Hash Set (unordered)

- (Like Sets in Python)
- Doesn't have an index - Have to loop through
- Very fast access (O(1)?)
- Hash codes for entries in a `HashSet` must be unique even if the data inside the entry is not.

- `.UnionWith()` returns all elements
- `.IntersectWith()` returns shared elements
- `.IsSubsetOf()` or `.IsSupersetOf()`

### Dictionaries (unordered, <key, value> pairs)

`.Add()`
`.Keys`
`.Values`

## After Lunch - Advanced Unit Testing

- `Using NUnit.Framework` - Don't have to create a different project
- Tools -> Nuget Package Manager -> NUnit (Test SDK, NUnit, NUnit3TestAdapter) (NUnit.Analyzers)
- SDK - Exposes test methods (MS)
- NUnit - Main functionality
- NUnit3 Test Adapter - Running tests in the IDE

(Resharper - JetBrains)

- Tests from the command line
- `dotnet test --list-tests`
- `dotnet test`

- Constraint model testing reads like a sentence (DAMP)
- Classing model testing doesn't

- Can define a subject under test as an instantiated object then...
- test methods on that object

- Assert using the `Is` keyword and the `Does`

- FIRST testing

- Testing with `a, Is.EqualTo(b)` is better than `a == b` because `a ==b` just returns if the condition is True or False compared to an expected True or False, `Is.EqualTo()` provides information on ***how*** it is different from the expected result.

- Can assert contains on collections too

- Coverlet for coverage report
