# Day 10 - 08/07/2022

[TOC]

## Session 1 - Enums

[Look into: Executing in interactive mode]



Enums - Enumerated constants

can override default values (otherwise 0, 1, 2...)

Can cast to `(int)` to get the value.

People generally use CAPITALS to name enums.



## Session 2 - @1200 - Methods 

### Method signature

![C# | Methods - Tutorialspoint.dev](https://tutorialspoint.dev/image/methods-in-java.png)

### Access modifier - visibility

- `public` - anything in the <u>namespace</u>
- `private` - access it within that <u>class</u>
- `protected` - available to <u>sub-classes</u>
- `internal` - available in the same project (<u>assembly</u>)



Method names should be verbs

Scope is defined by `{ }`

`new` method calls the constructor of a class


### Class Modifiers in C#
`static`
`abstract` - abstract methods can only exist in an abstract class
`sealed` - can't be overriden in derived classes **AND** can't be subclassed
`async` - Asynchronous methods

Don't often use tuples to return more than one thing.


### Memory Model

The Stack - Fast access memory

`int` - primitive type - `ByVal` (on the Stack)
`string` - object - `ByRef` (on the Heap)

Objects go to the Heap
Primitives go to the Stack

### Optional Parameters

```csharp 
    public static int DoThis(int x, string y = "Sad")
```

Where `string y = "Sad"` is an optional parameter (with default).
- Optional parameters are at the *end* of the paramerer list


## Session 3  @ 1330

-> Naming Style => Editable Options (<span style="color:red">in the Visual Studio IDE?</span>)

arguments can be non-positional: `y:"Happy", x:10`

Use descriptive parameter names.

Polymorphism -> (overloaded methods are Compile Time polymorphism)

Be wary if optional parameters could lead to another method being used.


Tuples are a composite data type
- Generally it is better to encapsulate multiple returns into a class rather than use tuples

Can access through `myTuple.Item1 ...`

Can define:
```csharp
(string fName, string lName, int age) myTuple = ("Kai", "Chan", 60)
```
- So can access age by `myTuple.age`

or 

```csharp
var myTuple3 = (title: "Lord of the Rings", copies: 3)
```

**ENSURE WE UNDERSTAND: The difference between "Pass by ref" vs. "Pass by value"**

Pass copies of the primitive to the parameter unless `out` keyword is used.
- if `out` is used then passes the ref and it *can* be changed.

`out` => Sends ref not copy
- Usually used for passing multiple things.



$\approx 5$ (`Is.InRange`)
$\approx 2.5$ (`AtLeast`, `AtMost`)
$\approx 1.8$ (`Is.All.InRange`)

**LOOK INTO THESE**
