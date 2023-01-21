# Day 9 - 07/07/2022 - Collections and Data Types

[TOC]

## Session 1 - Strings

`string` is an alias for the `String` class.

`.Length` property

String methods

Strings are immutable
- Methods create a new string even if you assign to the same variable.

### String Builder - A mutable string (a collection)

Benchmark `StringBuilder` against `String`

`StringBuilder` - does <u>not</u> have all of the methods `String` does
- use `StringBuilder` => <span style="color:red">in what cases?</span>

### String Interpolation

```csharp
$"some text that needs a value {variableOrExpression}."
```
`$` is the token for interpolation.

Look at `parse` vs `TryParse`


## Session 2 - Arrays

Arrays are a fixed length.

Define the length, not the items

```csharp
int[] arrayOfInts = new int[10];
```
Where the size, in this case, is length `10`.
This produces an array of 10 zeros

to get n-Dimentional array bounds
```csharp
array.GetLowerBound(nDimension)
```

2D arrays
: are defined as anything with *rows* **&** *columns*

Jagged arrays
: only have to specify size of outer array initially - then inner arrays *after*

(what are CTRL-R and CTRL-F for?)

```csharp
foreach(int[] innerArray in jaggedIntArray)
{
    foreach (int value in innerArray)
    {
        Console.WriteLine(value);
    }
}
```

Use case of Jagged Arrays
- Lists of Lists

Debug through the filling of the array

## Session 3 - DateTime (15:30)

`DateTime` class
```csharp
DateTime.Now
.AddDays()
```

.NET6 and C#10 has `DateOnly` base class
```csharp
DateOnly.FromDateTime(value)
```

Can treat dates like numbers (add and subtract them)

LOOK UP - `DateTime` formatting in C#

(There is also `TimeOnly`)

StopWatch?

`string?` indicates a nullable string `?` is the nullable token

LOOK UP - C# Interactive Window
