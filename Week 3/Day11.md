
# Day 11 - 11/07/2022

[TOC]

## Stand-Up

off-stack -> goes out of scope
off-heap -> by garbage collector

garbage collector
- Identifies dead objects
- Removes dead objects
- Compacts heap


C# as a language
- Statically Typed
- Type Safe
- Memory Safe

### Casting
**Implicit casting** - No loss of data
```csharp
int y;
double x = y;
```

**Explicity casting** - Forcing a cast
```csharp
(int)y = double x;
```

### Errors
**Compile Time**
- Syntax errors
- Logical errors

**Runtime**
- Runtime errors

Ternary operators
Exception hierarchy
Integer division
.Net 6 vs. .Net Framework

.NET Framework - Desktop applications for <u>windows</u>
->
.Net Core (from scratch) cross-platform
->
.Net 5 is the standard to unify the different branches under .Net Core


## OOP Videos

### Procedural Programming (Code in one place that operated on data stored somewhere else)

Issues
- Data separated from functions
- Lack of modularity
- High coupling
- Re-use difficult
- Not modelling the real world - The real world doesn't have data separated from behaviour


### OOP (Object Orientated Programming)

Advantages
- Combine data elements with operations on that data (data and functions are combined)
- Better modularity - everything is self contained
- Low coupling
- Re-use easier
- Closely models the real world

#### The 4 Pillars of OOP
- Abstraction
- Encapsualtion
- Inheritance
- Polymorphism

##### Abstraction

When we describe something in an abstract way (e.g. "I have a car") we have a shared understanding of what the elements are.

- Classes that represent real-world things

e.g. Bag 
Properties - Material, Colour, Size, Handles
Actions - Put things in or remove them

Class is the unit of abstraction
- An object is an instance of a class
- A class is a type of an object
- Has Data (Properties)
- Has Methods (Operations)
- Has Name

A class is comprised of:
- Private fields
- Public Properties
- Constructors
- Methods

To use a class
-> Create an instance (and provide the values for it)

###### Coding Example

Constructor method ->
```csharp
public NameOfClass ()
```

- specify variables after class signature but before any methods
- Add parameters to the constructor to allow passing in values to the class
- Define methods on the function

##### Encapsulation

Not how does it work, but how do I work it?

- Provide a simple consistent interface to use the object
- Hide data and implementation details inside
- Each class has a well-defined responsibility


- The data elements are hidden inside a class
- The method code is not visible
- Provide a simple, well-defined interface


- Hide internal variables
- Private variables with first _ and lower case letter


- Can create get and set methods.
- But can encapsulate as a property instead
- Properties have PascalCase

##### Inheritance

Hierarchies of relationships between objects
e.g. vehicle (Superclass) -> Car, Bus (Subclasses),  Car (Superclass)-> Luxury Car (Subclasses)
- Base class - Superclass
- Derived class - Subclasses

###### Coding Example

Inherit using - Subclass : Superclass

Use superclass methods (e.g.) in constructor -> Reference to the superclass constructor

```csharp
public Customer(string FName, string LName) base(FName, LName)
```

Power of subclasses is their ability to specialise
- Fields in subclasses can be assigned after reference to superclass for constructor
- Can call methods on base class in subclass methods

##### Polymorphism

Get a message, do something

i.e. "Start" method... couple apply to a Car, Plane, Washing Machine, Microwave, Job Application

Several kinds of objects that can deal with the same kind of message
