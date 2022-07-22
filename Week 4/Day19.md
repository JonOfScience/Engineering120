# Day 19 - 21/07/2022 - Code Smells and Refactoring

[TOC]

## Refactoring

- DEFINITION

### Why?
- Improve your design
- Design of the program will decay
- As people modify, the code loses its structure
- It becomes harder to see the design by reading the code

### Before refactoring

1. Cover your code with tests
2. Pass all tests
3. Commit your code
4. Now you can confidently change your code knowing you can go back to a previous version

NEVER "It was working, but now it is not"

### Refactoring and testing

1. Refactoring is easy if you code is well covered by unit tests
2. you know your code works
3. make a small modification to code
4. you may need to modify tests so they pass again

### When to refactor

- Merciless refactoring
- Rule of 3 (Don Roberts)
- "The first time you do somewthing, you just do it
- The second time you do something, you wince at the duplication, but your do the duplicate thing anyway
- The third time you do something similar... refactor

Specifically:
- When it is hard to read
- When duplication exists
- before adding functionalioty
- When adding new behaviour is not possible without making major changes to the existing code
- On code reviews
- When your code smells!

### When NOT to refactor

- Close to a deadline (unfinished refactoring can be catastrophic)
- Need a complete rewrite (should work mostly before refactoring, sometimes it is better to throw out existing code out and start again)

### Refactoring support in visual studio
- MS has documentation
- Don't havew to us VS support but it helps

## Code smells

- recognisable bad code traits
- 

- Any method name should be meaningful (DAMP) (R-Click "Rename")
- Dead code (codde can't be reached, commented out code, unused methods, unused variables/properties/fields)
- Long methods (nice and short and descriptive)
-

- If you break a test, maybe there is a reason for it being that way in the first way. Go back to the client to check requirements.

- Data clump - Same members keep appearing together
- Feature envy - A class accessing another classes members a lot.
- Long parameter list -> object (class/struct)

## Design Patterns

- patterns in software design to solve common problems

- Creational (Singleton) - When things are being creatred
- Behavioural (Strategy) - Defines behaviour
- Structural (Decorator) - Defines the structure of a group of objects

"Design Patterns: Elements of Reusable Object-Oriented Software"
- Gang of Four

Name
Intent
Description of the Problem
...
..
.


Singleton - Single instance of an object that is globally available - e.g. Entity Framework, Logger
- Accessible through `static` `_instance` property of the class
- Make the constructor `private`

Strategy - Algorithm varies independent from the client that uses it
(e.g. Polymorphic Shootout)

Decorator - e.g. C# Base Class `Stream`
- (Wrapper Class implementing an interface that is inherited by a subclass )

When the client calls a Stream method such as Open, Close, Read, Write or Flush on the BufferedStream object it is holding:

 - the buffered stream object calls the same method on the GzipStream object it holding which unzips it

 - which calls the same method on its FileStream object

Refactoring Guru