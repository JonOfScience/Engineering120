# Day 13 - 13/07/2022

[TOC]

## Base Object Class

`virtual` keyword - Method can be overridden in derived classes

override method from base class - use override in method signature

```csharp
public override string ToString()
```

When dealing with derived concrete classes we mark methods/properties to be overridden with the virtual keyword

## Sealed Keyword

If `virtual` or `override` in the signature then derived classes can override the method.

`public override string ToString()`{:.csharp}

Use `sealed` to prevent subclassing if used in the class signature
Use `sealed` to prevent overriding of methods in derived classes

```csharp
public override sealed string ToString()
```

## Abstract Classes

When you want something to have certain features but only really exists to be derived from.

Abstract classes can have concrete and abstract methods in them
Concrete classes can only have concrete methods

An abstract method has no implemention, no method body

C# doesn't support multiple inheritance

Inheriting from an `abstract` class requires you to implement all `abstract` methods.

Interfaces are purely abstract, abstract classes can implement some methods

## Polymorphism (@1425)

- Passing objects as Object in function call allows access to Object base class methods (not the other methods on the object)
- But overridden methods from the Object base class will be called from the passed object (runtime polymorphism)
- Can cast to classes higher up the hierarchy (e.g. from `Hunter` to `Person` but not the other way around)

- Casting - Object is still the same object, but "treat" like the casted object.
- `(Person)aHunterInstance` means `aHunterInstance` is still a `Hunter` but gets treated like a `Person` in this case. 

## Interface

*A contract: If you implement my interface then you must implement my methods - Nish*

 - C# will only allow you to *inherit* from one `class`
 - C# will allow you to *implement* multiple `interfaces`

 e.g. Define `IMoveable` interface for anything moveable

 - All methods declared in an interface are abstract
 - An interface's properties and methods are public
 - Add an implemented `interface` to the `class` signature using the same syntax as inheritance

 - Can classify types by interfaces implemented e.g. anything that implements the `IMovable` interface is considered an `IMovable` type.

- You don't instantiate `abstract` classes
- you don't instantiate an `interface`

## Pair programming

- Driver - Writes the code
- Navigator - What to do

1. Driver shares their screen
2. Or on Git
3. Paid on GitHub live coding tool
4. Not great (liveShare)
