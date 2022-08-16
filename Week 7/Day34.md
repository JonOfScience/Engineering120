# Day 34 - 12/08/2022 - Behaviour Driven Development (BDD)

[TOC]

An agile development process

BDD - Development process that puts behaviour first
- Collaborative

Each feature is a user story
Each scenario is a test condition written in Gherkin


## Structure of a User Story (Feature)

Acceptance Criteria (presented as scenarios)
Scenario Steps - Given, When, Then


## BDD & Test Automation
- Gherkin scripts can be followed step by step by a manual tester
- Automation testers can turn these scripts into executable code

Imperative Style - More detail, understood by developers, maps to technical implementation
Declarative Style - Less detail, understood by wider stakeholders, only pertains to the information the business cares about

Imperative Style <--Continuum--> Declarative Style

- Good Gherkin Script - It's a continuum between Imperative and Declarative - enough detail to be understood by developers and testers but not too much (to confuse stakeholders)

## Happy, Sad and Alternative scenarios
- Think about trying to break the system
- Don't make tests to pass... make them to test the response of the system

SpecFlow is huge, we will cover only about 1/3 of what is in there in our training

If you are dealing with tables use helper methods

https://automationpanda.com/bdd/
https://cucumber.io/blog/bdd/example-mapping-introduction/
https://www.youtube.com/watch?v=BQI_f3SghT8

Homework and Tasks
==================
https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html
Include sharing step definition between files and Parallel execution
See notes and further reading for more information about specflow
