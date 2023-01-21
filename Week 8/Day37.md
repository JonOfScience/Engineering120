# Day 37 - 16/08/2022

## Exploratory Testing

*"Exploratory testing is an approach to software testing that is concisely described as simultaneous learning, test design, test execution, and test result interpretation."* - Cem Kaner    

- Emphasis on adaptability and learning - it is not *ad-hoc* testing
- Uses and captures information which guides us and can help us find patterns and subtle cues
- Designed and executed simultaneously with little documentation

### Exploring vs Wandering

### Essential elements
- Purpose - Why are we doing what we are doing?
- Designing - What test techniques are we going to be doing?
- Executing - As soon as we come up with an idea, we write it down
- Learning - What subtle cues are we picking up?
- Streeting - Where should we go next?
- Timeboxing - Just limit yourself (to an hour, two hours, three hours)

#### Mobile App
- Refresh
- Portrait vs Landscape
- Multi-finger support
- Swiping to left & right
- Try out all the icons

Scenarios:
- Tap and hold on an item - what happens?
- The picture disappears - then what?
- Does that happen to another item? - then what?
... each small tests informs the next one ...

#### Where do we Begin?
- Break down the application based on its high-level application based on my knowledge
- Then break down the system into its smaller functions
- Will have a list of areas to explore
- Focus on the high-risk areas based on experience

Talk to your stakeholders
e.g. performance implications? legacy data?

- Break down the application
- Talk to stakeholders
- Stakeholder questions and comments
- The source code (look for TODOs)
- Developer comments
- Your own findings and knwoledge about the system
- Existing defects and defect reports
- Particular areas where defects are clustered

#### Heuristics
- "mental shortcuts" that can allow us to quickly solve problems
- Checklists put together by experienced testers is a form of heuristics
- 3 well known heuristics used by testers
    - (Input Fields) Goldilocks by Elizabeth Henrickson - "Too big, Too small, Just right"
    - (Regression testing) RCRCRC by Karen N Johnson - "Recent, Core, Risky, Configuration, Repaired & Chronic"
        - Recent - Recent additions
        - Core - Smoke testing - are core features still working?
        - Risk - Some areas pose more risk to customers
        - Configuration - OS?
        - Repaired - recently repaired
        - Chronic - Breaks often
    -   FEW HICCUPS by James Bach & Michael Bolton - "Familiar, Explainability, World, History, Image..."
        - Familiar - Consistent with patterns of familiar problems
        - Explainability - Do we understand it, can you explain it?
        - World - Consistent with what we kow about the world?
        - History - Consistent with older versions?
        - Image - Consistent with brand and reputation?
        - Compararble Products - Consistent with comparable products
        - Claims - Consistent with the way people are talking about it?
        - User Expectations - ?
        - Product - ?
        - S? - 

#### Heuristics Review Strategy?

#### Awareness / Observations

- Be alert to subtle cues (the non-obvious, the moonwalking bear)
- Try unusual things 
- Use monitoring software to look for the unusual
    - High CPU/Memory usage
    - Unusual network traffic
    - Strange HTTP requests/responses
    - Strange filesystem read/writes
- Look at Console & Server Logs [Event Viewer - Windows logs]

#### Test Charters
- How we document our exploration

- Created during the Test Design phase
- Just what you've been asked to explore
- Just documents what you've been looking at
- Includes target area, the resources/techniques/tools we'll use
- The information we're looking for


## Performance Testing (very important in web-app development)
"Testing to determine the performance efficiency of a component or system" - ISTQB Glossary

Performance - (Perceived) Page speed
- User frustration
    - User bounce chances increase massively with time to load

Factors that affect web performance
- Hardware
- Databases
- Location of Servers
- Connection
- Page Weight
- (Number of) HTTP Requests - Every embedded CSS or JS requires another request
- Caching (Temporary storage of page elements on local HD)

Pros and Cons to all possible solutions
- Can put all of the information in the HTML
- Can put all CSS into one file, Can put all JS into one file

Page Weight (by proportionate volume)
- Videos
- Images
- Javascript

Reduce page weight
- Only include what's necessary
- Don't serve large images
- Compress images
- GZip assets
- Minify code

Minification
- No comments, whitespace, non-required semi-colons
- C-Sharp/Java/HTML minifiers

GZip
- Can test for GZipping - Additional delays

Web Performance Tools
- pagespeed.web.dev (Google's tool)
    - Impacts on SEO ranking factor on Google (Google Web Vitals)
- Pingdom
- Web inspector - Google Lighthouse (in Chrome)
Performance Insights

## Load and Stress Testing

Performance Testing (is a kind of non-functional testing)
- **Load Testing**
- Volume Testing - Does the system break when handling large volumes of data
- **Stress Testing** - When under stress, in how many ways can the system break?
- Reliability (& Recovery) Testing
    - Check that software can perform failure-free operation for a specified time in an environment.
    - Can a browser rebuild all previously open tabs after a force close/crash
- Spike Testing
- Soak Testing (AKA Endurance Testing)


Performance testing
- Performance testing is usually automated
- jMeter?

Software KPIs
Expected normal load
Expected peak load
A tool to run the tests

Gatling - Performance testing (DevOps people regularly use)

- Get KPIs
- What should I test base on the KPIs?
- e.g. Minimum Acceptable Load = Spike +10%

Focus for Revision (32 questions)
- 4 questions HTML, CSS - Basic (syntax to include a style sheet, correct way to make everything tag in red)
- White black grey hacking
- Test automation pyramid
- Why are automated GUI fragile
- What is (device) fragmentation
- Where should we focus our scnearios when we are writing automated tests
- Element selecting in selenium
- Xpath
- BDD syntax (GWT) (several questions)
- What causes SpecFlow tests to fail
- Iterating through SpecFlow table rows
- Exploratory testing
- What does CI stand for?
- Different types of performance testing

First thing tomorrow morning at 0930 - to get it out of the way
- Project for the rest of the day
