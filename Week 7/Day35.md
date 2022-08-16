# Day 35 - 12/08/2022

[TOC]

## Living Docs
in the project build folder

.\Calculator\BDD_Calculator\bin\Debug\net6.0

livingdoc test-assembly BDD_Calculator.dll --test-execution-json TestExecution.json

## Continuous Integration / Continuous Delivery

*"I'm not great developer, I am a good developer with great practices"* - "XP Explained" by Kent Book

"If integration testing is good then we will integrate and test several times a day."

Every single time I make a commit or I push to my branch then I will automatically build the project and run the tests.

CI builds give information - When last good build, when tests start to fail, what changes were made at the time.

Discipline
- Build and Test in under 15 minutes - I don't want to wait to find out that I have broken something.
- Don't Push and log off - Stay to see if it breaks anything.

## GitHub Actions

Actions

-> Link to redo

-> Auto-generates YAML file
--> Build when a push to the main branch or pull request against the main branch

Once it has been created, it should build

Locations with spaces in the name should be enclosed in quotes (e.g. "Week 4/SafariParkCodeSmells_Starter/SafariPark.sln")

If they have DBs - Use in-memory solution for database (see Test Mode for "#" comments like #endregion, #debug?)

### Static Analysis Tools on GitHub Actions
Sonar-Cube
Sonar-Cloud


### Reasons for automating the tests using GitHub Actions

Don't have to run the tests yourself - know *their* tests pass without having to run the whole suite.

Remove the mundane and the boring

**Run Locally - Make sure it all passes - THEN push**
