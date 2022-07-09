# Day 7 - 05/07/2022 - C#



## Stand Up

Look into:

- string.Equals()
- string.Equals(input, "password", ....IgnoreOrdinalCase)



## Session 1

```a=x++``` 	assign x to a <u>then</u> increment x.

```b++x```		increment x <u>then</u> assign to b.



Prefix vs. suffix only comes into play if it is being assigned.



Integer division

```var a = 5 / 2 ``` 		-> 	```2```

```var b = 5.0 / 2``` 	->	```2.5```

If either argument is a ```double``` then the result will be inferred to also be a double by ```var```.



```csharp
#region
    <code>
#endregion
```

Allows us to section off related areas of code.



APPROACH: Rest a cycling count

```csharp
x = ++x % (max_value)
```

So when ```x``` -> ```max_value``` then ```x % max_value = 0``` therefore ```x``` resets.



Split up functions to make your intention clear

- To make your code readable



Operators: ```+=``` , ```-=``` , ```/=``` (?) , ```%=```, ```*=```



``internal`` means that it is accessible within a project (an assembly)



## Session 2

Best convention is that there is one class file (```.cs```) per class.



```&&```	-> 	short circuit conditions

```&```		->	check (and run) all conditions [Used primarily with binary operations]



Be aware of the difference between single and double logical operators

- Can use short circuit to prevent errors on evaluating an expression that could be null.



### Ternary Operator

```boolean condition to check ? result if true : result if false```

Ternary chains

```condition_1 ? condition_2 ? condition_2_true : condition_2_false : condition_1_false```



## Session 3

Switch in debug mode 	-> Handled like ifs

Switch in release mode	-> Jump table (O(1))



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

Use switch for ```const``` or ```int``` values.

Use ```if```/```else``` for ranges.



## Session 4 - Iterations

```static``` classes cannot be instantiated -> so all methods must also be ```static``` (e.g. ```Math```).

R-click on unimplemented methods to generate them using "Quick Actions and Refactorings"



HWK: Create a method for each type of loop which returns the highest number in an *unordered* list.



```foreach``` only works for **read-only** purposes.



[nums[0]] if nums is an empty list

=> Lowest in each list

=> Refactor methods so far

=> Code kata

=> TFE (Test First Exercises)

=> Coding websites (Advent of Code)



