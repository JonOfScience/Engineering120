# Introduction to C# in Visual Studio

Viewing compiled code go to `Debug>>net6.0`

A **solution** is an umbrella that holds all of our projects. It has no other function.

- `.sln` file just includes information on projects and settings
- `.csproj` contains settings for the project

**Compilation Process**
- CIL
- CLR
- Just-in-time compiler

`bin`
- Executable
- `.pdb` debug information


`obj`
- Piles of other files

in .NET 6.0 and in C# 10 only includes body text (not namespace or Main class)

`static` - Belongs to the class not instances of the class

`void` - doesn't return

File scoped namespaces e.g.
OLD
```csharp
namespace ThisNameSpace 
{
}
```

NEW
```csharp
namespace ThisNameSpace;
```

Everything within that file is automatically within that namespace.

```csharp
global using System.Collections.Generic
```

## C# Case Conventions
- camelCaseLikeThis - used for variable names
- _underscoreFirst - for private fields
- PascalCaseLike - used for class and method names
- kebab-case-like-this - for html
- snake_case_is_often_used_with_sql

## Autos and Locals

## Debugger - Breakpoints, Step-In, Step-Over

## Naming styles

## Various assemblies on compile
- Executable - Runs on its own
- DLL - Cannot run on its own

Build > Clean Solution
 -> Removes `bin` and `obj` files

 ### Call the executable from the command line (PS)

 - `dotnet new console`
 - `dotnet test`

 ## GitHub in VisualStudio
