# Day 14 - 2022/07/14

[TOC]

## Stand-Up


- `abstract` classes can have `abstract` and concrete (normal) methods
- `abstract` classes cannot be instantiated from
- interfaces can only have abstract methods
- concrete (normal) classes can only have concrete (normal) methods
- `abstract` methods must be implemented by any class that inherits them


- classes can only inherit from one class, but can implement multiple interfaces
- By default `.ToString()` returns the `namespace` and `class` names
- Best Practce: When we call `.ToString()` we would expect to get information about the class, not anything else.


- a `sealed` method cannot be overridden in further derived classes
- only use `sealed` once you have overridden a method in a derived class.
- only use `virtual` in an implemented method that is *intended* to be overridden

- a `static` method belongs to the class and not to an object

- Object initializers set properties during object instantiation.

- When you show off work start with a demo

- Separation of Concerns

- Just because two things share an interface doesn't mean they are interchangeable, e.g. both fruit and porcupines are living things, but only one of them tastes good.

- Swap roles during pair programming (driver, navigator, etc.)

## SOLID Principles

- Single responsibility - A class should only have one reason to change (each class should solve only one problem)
- Open/Closed - Open for extension, closed for modification (extend a class's behaviour without modifying it)
- Liskov substitution - objects of a subclass should be able to substituted in place of objects of a superclass without breaking the application
- Interface segregation - many small interfaces are better than one big one. A client object can then select which to implement (composition over inheritance).
- Dependency inversion - Depend on abstractions, not on concretions

### Single Responsibility Principle (SRP) (High cohesion, Low coupling)
- have one responsibility / Purpose
- class members should be cohesive (related data, methods manipulate or return this data)
- should have only one reason to change

- e.g. we moved the functionality for camera out of Hunter into its own Camera class (decoupling)

### Open / Closed Principle (OCP)
- open for extension but closed for modification (of behaviour. Refactoring is ok)
- don't change existing classes (as they might be used and you don't know what you might be breaking)
- new functionality can be added by adding derived classes
- overriding methods in derived classes can add functionality

### Liskov Substitution Principle (LSP) (Polymorphism)
- Subtypes must be substitutable for their base types without breaking the application
- Must implement inherited methods in the expected ways (no surprised)
- POLA

### Interface Segregation Principle (ISP)
- Many small, specific interfaces are better than one large, general purpose one
- Interface in this context means the public methods and Properties of a code module (`abstract` or concrete C# `class`es or `interface`s)
- Use interface inheritance
```csharp
public interface IMoveable : ISingleMoveable, IMultiMoveable { }
public interface ISingleMoveable { string Move(); }
public interface IMultiMoveable {string Move(int times);}
```



### Dependency Inversion Principle (DIP)
- Depend on abstracts rather than concrete instances
- Both high and low level modules should depend on abstractions
- High-level - Business rules, processes, guts of the application
- Low-level - Plumbing code, particularly for IO

- Hunter -> IShootable relationship is an example of Dependency Injection
- At Runtime both Hunter and Camera know nothing about each other, they both just know about the interface IShootable

- GUI code behind classes is low-level

SOLID Relationships
- SRP and ISP encourage small cohesive types
- These can be extended using OSP
- ISP aids LSP and DIP
- DIP enables OSP (using Dependency Injection can extend functionality without breaking the application)

- GRASP principles
- Design Patterns
- DRY - Don't Repeat Yourself
- YAGNI - You Aren't Going To Need It
- KISS
-
- PDD - Pain-Driven Development
- Use simple techniques until they cause pain
- Then refactor when painful

Prioritising ISP and DSP supports the use of Compositional classes rather than Inheritance classes

Can add default implementation to interfaces as of C# 8

## Comparing Objects

*"Two objects are only equal if they have the same Hash Code" - Nish*

- Override default implementation of comparison methods (Quick Actions -> Generate Equals and GetHashCode)

- `obj as Thing` is the same as `(Thing)obj`

- GetHashCode then depends on the selected fields

- Two Equals - One to try and cast to the correct type, One to deal with an object of the correct type

### Sort (CompareTo)
< 0 Precedes the other in the sort order
= 0 Same position
0 > After the other in the sort order

IComparable is used when you want to implement a specific sort function on a list

*"IComprable will be used when sorting list of objects. Implements CompareTo method" - Nish*


## The `System.Collections.Generic` namespace

- Arrays are immutable and so are NOT a collection
- List, Dictionary, Queue (FIFO), Stack (LIFO), 

- Can add items to a list by using object initializers `{ }`
- Can add items using `.Add()` method
- Can add a list to another using `.AddRange()`

- Generic collections can only contain one type

- Linked List - No concept of an index (missing IList type)
- `.AddFirst` (add to the front)
- `.AddLast`
- `Find` or `FindLast` and so on.

- List when you need elements from the middle quick and adding at any position
- Linked list when you are only adding to the beginning and end
- Both are fine if you are traversing

( TOMORROW = Queues, Stacks, Hashsets & Dictionaries )
Enumerable

## The `System.Collections` namespace

- ArrayList - Older and deprecated - (DON'T USE FOR NEW CODE)
```csharp
ArrayList a1 = new ArrayList();
al.Add(1);
al.Add(kai);
al.Add("Hello");
```
Boxing and unboxing - each item is boxed into an `object` type, and then unboxed on read
