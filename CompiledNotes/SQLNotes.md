# Teachable Course - SQL Fundamentals

##  Course introduction

SQL - Structured Query Language
Language to communicate with databases

##  Databases
(Data warehouse or Data lake)
### Flat-File
- Plain text format
- A single table
- Limited number of records related to a single topic (e.g. Spreadsheet, CSV)


### Relational (SQL) Databases
- Contain tables that are related to each other in some way.

- Relational Database Managerment Systems (RDBMS)
    - Take instructions in SQL and interpret them
    - Different RDBMS have slight differences in syntax
    - Many - Some popular ones are: 
        - MySQL (popular, open-source)
        - Oracle (proprietary - banking sector)
        - PostgreSQL (open-source, web applications - reliable)
        - SQLite (open-source, light, bundling database with application)
        - Microsoft SQL Server - Tools are (SQL Server Management Studio, Azure Data Studio)

- Recognises relationships between stored items
- Many relational databases use SQL
- Primary Feature: All the Tables should be connected in some 

- What are the real-world relationships between the data? Consider this when designing a database

- Linked fields in different tables through keys

#### Primary Key (e.g. ISBN for books)
- Identifies each record in the Table
- Must be unique
- Cannot be empty
- Cannot be changeable
- Can be a single column (simple)
- Can be multiple columns (composite) (e.g. Order Number & Line Number in an order )
- One Primary Key per table
- Most RDBMS can be set to produce an Autoincrement ID

#### Foreign Keys
- Reference Primary Keys of other Tables
- A table can have any number of Foreign Keys
- Values do not have to be unique
- Add ID column in one table that reflects Primary Key in another table
- The RDBMS will prevent any changes that violate the relationship constraints

- Repeating the same information in the same database is known as data redundancy - It makes it MUCH harder to update.

### Non-Relational (NoSQL [Not only SQL]) Databases
- Incredibly valuable in cases where the data don't fit into the rigid structure that comes with table oriented relational database.

## Data Modelling

- Data models detail *how* elements relate to one another
- Three levels

Conceptual (Least Granular Model)
: Broad level business understanding of the data structure
: Comprises - Entity Names, Entity Relationships

Logical (Next level)
: Defines the structure of data elements and the relationships between them independent of the RDBMS
: Comprises - Entity Names, Entity Relationships, Attributes, Primary Keys (PK), Foreign Keys (FK)

Physical
: Specific implementation of the data model dependent on the RDBMS being used
: Comprises - Primary Keys (PK), Foreign Keys (FK), Table Names, Column Names, Column Data Types

Entity
: Anything in the world that we store data on.
: Store data on different entities in different tables (e.g. Books, Authors, Publishers)

### Types of Relationdship

One-to-one
: Each record only has one relationship to one other record and vice-versa

One-to-Many
: One record can have multiple relationships with records in another Table
: Allows frequently used information to be saved only once in a Table and referenced many times in all other Tables

Many-to-Many
: Many records in one Table can be related to many records in another Table
: To describe this relationship a Mapping, Link, or Junction Table is required - Sometimes named after the relationship they capture.


## ERD
- A way to visualise the structure of databases



## Normalisation
- Making databases more efficient

## Database Setup - Visual Studio (Windows)

## Database Setup - SQL Fiddle (Mac / Linux)

## Database Creation

## Data Types

## Inserting Data

## Constraints

## Primary Keys

## Foreign Keys

## Updating Tables
