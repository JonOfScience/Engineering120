# Day 7 - 05/07/2022 - C#

[TOC]

## Stand Up

Look into:

- string.Equals()
- string.Equals(input, "password", ....IgnoreOrdinalCase)



## Session 1

### Increment/Decrement Operators

```a=x++``` 	assign x to a <u>then</u> increment x.

```b++x```		increment x <u>then</u> assign to b.



Prefix vs. suffix order only comes into play if it is being assigned.



### Integer division

```csharp
var a = 5 / 2;

a = 2
```

```csharp
var b = 5.0 / 2;

b = 2.5
```

If either argument is a `double` then the result will be inferred to also be a double by `var`.


### Segmenting code
```csharp
#region
    <code>
#endregion
```

Allows us to section off related areas of code.

(Beware developers et al. saying "we don't need tests, we write working code")


### APPROACH: Reset a cycling count

```csharp
x = ++x % (max_value)
```

When `x` reaches `max_value` then `x % max_value = 0` therefore `x` resets to `0`.


### Good-Practice - Function design and readable code
Split out functions to make your intention clear
- To make your code readable



Operators: `+=` , `-=` , `/=` (?) , `%=`, `*=`


### Accessibility Modifier
`internal` means that it is accessible within a project (an assembly)



## Session 2

### Good-Practice - Class division between files
Best convention is that there is one class file (```.cs```) per class.

### Logical Operators

| operator | usage |
|-|-|
| `&&` | short circuit conditions | 
| `&`  | check (and run) all conditions [Used primarily with binary/bitwise operations] |

Be aware of the difference between single and double logical operators
- Short circuit can be used to prevent errors on evaluating an expression that could be null.



### Ternary Operator

```csharp
boolean condition to check ? result if true : result if false
```

Ternary chains:

```csharp
condition_1 ? condition_2 ? condition_2_true : condition_2_false : condition_1_false
```



## Session 3 - Selection (`switch` vs. `if`)

`switch` behaviour is mode dependent
- in debug mode - Handled like `if`s
- in release mode - Handled through a jump table (O(1))



```csharp
switch (level)
{
	case 3:
		result_actions;
		break;
    default:
        break;
}
```

Deciding when to us `switch` and when to use `if`/`else`
- Use `switch` for `const` (e.g. `enum`) or `int` values that can be used for `case` values.
- Use `if`/`else` for ranges.



## Session 4 - Iterations

`static` classes cannot be instantiated -> so all methods must also be `static` (e.g. `Math`).

R-click on unimplemented methods to *generate* them using "Quick Actions and Refactorings"



HWK: Create a method for each type of loop which returns the highest number in an *unordered* list.



`foreach` only works for **read-only** purposes.



`[nums[0]]` if nums is an empty list


## Homework Assignment

=> Lowest in each list

=> Refactor methods so far

=> Code kata

=> TFE (Test First Exercises)

=> Coding websites (Advent of Code)
