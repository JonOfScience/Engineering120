# Day 8 - 06/07/2022

"*Try to concentrate on the here and now.*" - Nish

[TOC]

## Stand up

- `do...while` is primarily used in console applications.
- Rewrite my earlier methods using ternary operators.
- Test cases only accept immutable types
- Include tests for 1 element in an array or list.



## Session 1 - Exceptions

At <u>compile</u> time we identify

- Syntax errors
- Logic errors

Definition: An exception is an error (failure) found at <u>runtime</u>.



Exception hierarchy -> Exists with `SystemException` at the top.



- Checked exception -> Exception will be thrown
- Unchecked exception -> Exception can be thrown

[Throw Exceptions to prevent silent failures]



`() =>` denotes a Lambda expression



- `Throws.TypeOf<>` Requires us to specify the exact type of exception thrown.
- `Throws.InstanceOf<>` Can include Hierarchy members (e.g. `ArgumentException` for `ArgumentOutOfRangeException`)

 Can check for specific messages in Exception using `.With.Message.Contains("test message")`



[Nish has agreed to provide an extra session on using WPF to create desktop applications]



### Exception Handling

```csharp
try 
{
    <Code that might throw an exception>
}
catch (ExceptionType as ex)
{
    <Code to handle the exception using the ex object>
}
finally
{
    <Code that will be run both with and without an exception>
}
```

- There is lots of useful data about the exception on the `ex` object.
- Can catch multiple exception types using separate `catch` blocks.
- Order from more specific exception types to less specific exception types, e.g.

```csharp
catch (ArgumentOutOfRangeException as ex)
{
    ...
}
catch (ArgumentException)
{
    ...
}
```



## Session 2 - Talk from Daniel Webb

[TODO]



## Session 3 - Numerical Types

### For Quality Gates: "Why is C# described as a strongly typed language?"

1. Statically typed: Once you define the type you can't change it
2. Type safe: We can't assign a different type to a variable that already has a type assigned
3. Memory safe: (Memory is managed for us) We are restricted in the memory we can access

C# is Class based - All methods must be within a class



### Implicit and explicit typing:

- `var` - Implicitly typed 
- - Can't be used for private member variables
  - Can make declarations shorter
  - Doesn't always make intent clear

- `int` - Explicitly typed



### Integral numeric types (Integer numbers)

Types: Different memory requirements -> define -> different max/min values

There are 8 bits (binary digits) in a byte

Be aware of Integer Overflow

Generally, just use `Int32`

Unsigned numbers for variables that can't be negative

Can state type on assignment, e.g. `var c = 3d` where '`d`' denotes a decimal

Can split up large numbers with underscores, e.g `int c = 2_000;`

Floating point values (all have '`.`' in them)

- `float` (smaller than double)
- `double`
- `decimal` (most precise)

When merging operations from lower precision types to high -> Smaller type gets promoted (if possible)



Safe casting 

- Smaller data type into large -> No loss of data
- Implicit casting : char -> int -> long -> float -> double

Unsafe casting

- Larger data type to smaller -> Possible loss of data
- Explicit casting: double -> float -> long -> int -> char
- - e.g. `double c = 3.1 ; int d = (int)c`

**Must explicitly cast if there is the potential for data loss.**



## Session 4 - Integer Over/Underflow

[TODO]





## Homework Tasks



### Homework 1: Operators and Control Flow Lab

- [x] Function of MyMethod [return ```false``` if the numbers are equal, then ```true``` if ```num1``` is divisible by ```num2```, otherwise return ```false``` ]
- [x] Unit Tests for MyMethod
- [ ] 

[TODO]



### Homework 2: Exceptions

#### 02a ```Greeting``` method

- [x] Unit tests for ```ArgumentOutOfRangeException``` already exist
- [x]  ```ArgumentOutOfRangeException``` throwing for method already exists
- [x] Unit tests pass

#### 02a `AvailableClassifications` method

- [x] Add unit tests for `ArgumentOutOfRangeException` in cases of age is equal to -1 and -101
- [x] Unit tests fail (no exception is thrown)
- [x] Add Exception throwing to 02a ```AvailableClassifications``` method
- [x] Unit tests pass for Exceptions tests

#### 03 (Lesson) ```GetStones``` method

- [x] Unit tests for ```ArgumentOutOfRangeException``` already exist
- [x]  ```ArgumentOutOfRangeException``` throwing for method already exists
- [x] Unit tests pass

#### 03 (Lesson) ```GetPounds``` method

- [x] Unit tests for ```ArgumentOutOfRangeException``` already exist
- [x]  ```ArgumentOutOfRangeException``` throwing for method already exists
- [x] Unit tests pass

#### 03 (Lab) `Average` method

- [x] Add unit test for `ArgumentException` if the array is empty [`using system` was missing so couldn't find `ArgumentException`]
- [x] Unit tests fail (no exception is thrown)
- [x] Add exception throwing to the method
- [x] Unit tests pass for exceptions tests

#### 03 (Lab) `TicketType` method

- [x] Add unit test for `ArgumentOutOfRangeException` when age is less than 0.
- [x] Unit tests fail (no exception is thrown)
- [x] Add exception throwing to the method
- [x] Unit tests pass for exceptions tests

#### 03 (Lab) `Grade` method

- [x] Add unit test for `ArgumentOutOfRangeException` when grade is less than 0 or more than 100.
- [x] Unit tests fail (no exception is thrown)
- [x] Add exception throwing to the method
- [x] Unit tests pass for exceptions tests

#### 03 (Lab) `GetScottishMaxWeddingNumbers` method

- [x] Add unit test for `ArgumentException` when level is -1, 5, and 100.
- [x] Unit tests fail (no exception is thrown)
- [x] Add exception throwing to the method
- [x] Unit tests pass for exceptions tests



### Homework 3: Data Types Lab

1. 

- [x] Create unit tests for `Methods.Factorial`
- [x] Unit tests fail for unimplemented method
- [x] Implement `Methods.Factorial` [by changing return type to `long` as int and unit cannot hold the result]
- [x] Implementation passes unit tests

2. 

- [x] Run the tests [Expected: `6.30000019f` But was:  `6.29999971f` : Because either 2.1f or 3.0f cannot be represented exactly as a `float`]
- [x] Rewrite the test so it passes [`Using .Within(1).Ulps`]
- [x] Rewritten tests pass

3. 

- [x] Run the `FloatToLong` tests [passes when given an Integral Long, fails when given a non-Integral Float]
- [x] Rewrite `FloatToLong` to pass both tests [Round to an integral float before casting]
- [x] `FloatToLong` tests pass
- [x] Run the `UIntToShort` tests [passes when given a valid `uint`, fails when given an invalid `uint` (too big)]
- [x] Rewrite `UIntToShort` to pass both tests [throw `OverflowException` if the number is more than `short.MaxValue`]
- [x] Rewritten method passes tests

4. 

- [x] Run `IntegerCalc` tests to identify passes & fails [All fails - Non implemented]
- [x] Implement `IntegerCalc.Add` [+, for high: check if either num1 or num2 are `Int.MaxValue` and the other is positive and mirror for low]
- [x] Tests for `IntegerCalc.Add` pass
- [x] Implement `IntegerCalc.Subtract` [-, mirrored checks to `IntegerCalc.Add`]
- [x] Tests for `IntegerCalc.Subtract` pass
- [x] Implement `IntegerCalc.Multiply` [Has no tests?]
- [ ] 

