# Day 20 - 22/07/2022 - JSON and XML

[TOC]

*"Both are human readable, and machine readable"* - Peter

XML - eXtensible Markup Language
JSON - JavaScript Object Notation

- Human readable
- Easily Parsed
- Hierarchical

- Use is the same but there are many differences between the formats

## XML - eXtensible Markup Language

- Extensible - can add or remove data
- Markup - provides definition to text and symbols
- Language - present information based upon certain rules

- Has been around for 30+ years

- Configuration
- Root Node
- sub-nodes (with open and closing tags)

- Tags are not predefined
- Tags can contain other tags
- Tags contain content
- The author defines the content

### XML Rules
- Must have a root node
- May include a prolog (can include encoding)
- Must have a closing tag
- XML tags are case sensitive
- Comments are enclosed as follows `<!- Comment example -->`

### XML Elements
Can include
 - Test
 - Attributes
 - More attributes
 - Be empty 
Should Be
- Descriptive
- Short

### XML Attributes
`<academy title="Sparta Global Academy">`

- XML can have attributes
- Must always 'single' or "double" quotes
- No set rules for Attribues

SEE EXAMPLE

### XML Declaration

`<?xml version="1.0" encoding="UTF-8" standalone="no" ?>`

SEE DESCRIPTION TEXT

## JSON - JavaScript Object Notation

- Lightweight
- Easily Parsed
- Language Independent
- Human Readable

- Data is declared as an object that has name/value pairs
- JSON is more focussed on content, XML on formatting
- XML is also a markup format, JSON is data only

- JSON objects are made up of on or more Key-Value pairs between two curly braces

```json
{
    "name": "Nish Mandal",
    "isStudent": false,
    "address":
    {
        "number": 1,
        "street": "a street",
        "town": "a town"
    }
    "classes": ["Eng118", "Eng120"]
}
```

- Allowed data types: string, number, boolean, null, object, array
- Note - There is no comma after in the last item in each object

### JSON Arrays
- zero indexed
- use square brackets
```json
{
    "emplopyees": ["Nish", "Lee", "Cathy"]        
}
```

JSON is unlike XML because

- Doesn't use tags
- Less verbose
- Quicker ot Read and WRite
- can use arrays
- less difficult to parse
- is parsed into a ready-to-use JavaScript Object
- poor extensibility
- supported by most backend technologies

## File Operations

`using System.IO`

Synchronous - Run processes consecutively
Asynchronous - Run multiple processes concurrently

FROM CODE

Log at Event Viewer for Windows Logging

- Debug class to log messages during debugging to help find defects. Debug doesn't run in release mode
- Trace class runs on a separate thread and runs in release mode

## Logging

## Encoding (and Decoding)

- Translating from human readable to machine readable (encoding)
- Translating from machine readable to human readable (decoding)

(Powershell: `Format-Hex` outputs hex representation of specified file)

ASCII Table
All numbers 0-127 = represent characters
ASCII character encoding can be done in 7-Bits
BYTE (UTF-8)
2 BYTES (UTF-16)


## Streaming

- Stream is an abstract class
- lots of derived classes (e.g. filestream, )
- Uses the decorator design pattern

- System.IO provides types for customizing reading and writing
- StreamReader
- StreamWriter
- TextReader/Writer
- StringReader/Writer

("Using" to define a scope within which a resource can be used)

- Useful with massive datafiles that you can't load into memory

- Endpoint for the stream writer is the path and filename of the output

- Anything we put into a `using` statement must implement the IDisposable interface
- IDisposable has only one method  `dispose` just releases the resource therefore closing the file/stream... etc.

### Buffering Streams (Decorator Pattern use)

- Used for better performance




(LOOK AT ENTITY RELATIONSHIP DIAGRAM)
