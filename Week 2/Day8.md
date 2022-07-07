



Checkboxes



## Homework Tasks



### Homework 1: Operators and Control Flow Lab

- [x] Function of MyMethod [return ```false``` if the numbers are equal, then ```true``` if ```num1``` is divisible by ```num2```, otherwise return ```false``` ]
- [x] Unit Tests for MyMethod
- [ ] 



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

- [x] Run the tests [Expected: 6.30000019f But was:  6.29999971f : Because either 2.1f or 3.0f cannot be represented exactly as a float]
- [x] Rewrite the test so it passes [Using .Within(1).Ulps]
- [x] Rewritten tests pass

3. 

- [x] Run the FloatToLong tests [passes when given an Integral Long, fails when given a non Integral Float]
- [x] Rewrite FloatToLong to pass both tests [Round to an IntegralFloat before casting]
- [x] FloatToLong tests pass
- [x] Run the UIntToShort tests [passes when given a valid UInt, fails when given an invalid UInt (too big)]
- [x] Rewrite UIntToShort to pass both tests [throw `OverflowException` if the number is more than `short.MaxValue`]
- [x] Rewritten method passes tests

4. 

- [x] Run `IntegerCalc` tests to identify passes & fails [All fails - Non implemented]
- [x] Implement `IntegerCalc.Add` [+, for high: check if either num1 or num2 are Int.MaxValue and the other is positive and mirror for low]
- [x] Tests for `IntegerCalc.Add` pass
- [x] Implement `IntegerCalc.Subtract` [-, mirrored checks to `IntegerCalc.Add`]
- [x] Tests for `IntegerCalc.Subtract` pass
- [x] Implement `IntegerCalc.Multiply` [Has no tests?]
- [ ] 

