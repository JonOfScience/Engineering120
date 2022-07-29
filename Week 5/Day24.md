# Day 24 -  28/07/2022 - ISTQB Day 3

## Chapter 4 - Testing Techniques

### Equivalence Partitioning & Boundary Value Analysis (Black Box Analysis)

*"Most errors occur at the boundaries, that is why we test those edge cases"* - Nish

#### Equivalence Partitioning (Equivalance Classes)
- Con't test every possible input
- Split inputs into range (Goldilocks - Too Cold, Just Right, Too Hot)
- *For full class coverage, must have at least one value in **each** range*
- Select tests from within (e.g. the middle) of each class

#### Boundary Value Analysis (BVA)
- Select values near the boundaries of classes
- Always test 1 below, and 1 above the valid for each class

### Use Case Testing

- Made by BAs
- Derive Test Cases from each of the Use Cases
- One Use Case can have many Test Cases derived from it

- Use case describes a thing that the user wants other system to do
- Interactions between "Actors" and the system.


Verb-Noun pairs, e.g. "Assign resources", "Provide Invoice Data"


#### Use Cases
| Poorly Written | Better Written |
|-|-|
| Too long | Concise |
| Too much user interface detail | Little interface detail |


Derive test steps for test cases

#### Cons of Use Cases
- We asking users how they would want to use the system (this may not be correct)

#### Success Factors
- Size of the Team (right people are involved)
- Know when to stop
- Reviewing use cases

### Experience Based Techniques

#### Error Guessing
: Tester uses their experience to guess the problematic areas of the application.

#### Fault Attack
: Focussed attack on a known problem in the system (e.g. SQL injection)

#### Exploratory Testing
*"Exploratory testing is what makes testing 'cool'"* - Nish

- Not Ad Hoc, it is focussed on a particular area

- Experience based
- Test Design and Test Execution are done simultaneously

Advantages
- It doesn't require much preparation
- Testers report a large proportion of bugs via this method (not limited by the Pesticide Paradox)

Disadvantages
- No review of test planning, and experienced user of the system may not be an experienced tester
- Testers have to remember the exact steps they took to create a defect - otherwise reproduction may be difficult

Test Charters are a bit like an Explorers Journal

NOTES
- Uses and captures information which guides us and can help us find patterns and subtle cues

- 
#### Checklist Based Testing

- An experienced tester making a check list of defects based on their testing

- Checklists can support both functional and non-functional tests
- Coverage is defined by completion of the checklist

### White-Box Testing (Structure-Based, Glass-Box)

- Testing Control Flows
- Usually done at unit but applies to all levels

#### Statement Coverage
- b) percentage of statements...
- Q21 - b - 

- Each node in the control flow
- So 2 test cases are needed for coverage of an IF/ELSE statement (One for the positive IF statement, and another for the negative ELSE statement)
- Simple LOOP -> 1 test case
- CASES - 1 for each case, 1 for default

- All statements must be executed as part of the tests

- Take the highest value - don't add them on, just take the highest of the sequential operations

#### Decision Coverage
- Each branch in the control flow

- Independent IF/ELSE statements would need two test cases (POS & POS, NEG & NED)

- 100% decision coverage means 100% statement coverage

#### Code and Pseudocode
- Quickly translated statements

#### Path Coverage
- Test flow through all paths

Decisions about number of test cases

### How do you choose a test technique

- Dependent on test organisation
- Dependent on test object

- If there is full statement coverage, but still a defect, then there wasn't full decision coverage

## Chapter 5 - Test Management

### Organisation

#### Roles
In a project there are many roles:
- Project Managers
- QA Managers
- Developers
- Business and Domain Experts (Subject Matter Experts (SME), business analyst)
- Infrastructure Personnel (database designers)
- IT Operations (Help desk, merge functionality, etc.)

##### Test Manager (or Test Lead)
- Project Manager
- Development Manager
- QA Manager
- Manager of Test Group

- Report to higher-ups
- "Not necessarily the doing. They don't need to know all the techniques, just manage them."

##### Tester
- Developers
- Business Analysts
- Users
- SMEs
- Specialists

- Review and contribute to the test plans
- Review requirements
- Create Test Specification and Test Cases based on the techniques given in the Test Plan
- Prepare Test Data
- Execute test procedures, log, evaluate results, and document any deviation
- Use test administration, management, and monitoring tools
- Automate Tests (possibly supported by a developer or automation expert)
- Review tests developed by others

##### Independence

- The further you are away from the development of a product you are, the less bias you have when testing it (and the more defects you are likely to find)

There are several levels of independence within an organisation

*Possible Bias: You place more value in something you created.*

###### Independent Testers
Benefits - More objective, no blind spots, can verify assumptions (don't make assumptions)
Drawbacks - Isolated, Easily blamed (, lack of developer responsibility)

#### Test Planning, Test monitoring & estimation

- Test Planning is probably most important step in testing project

Milestones in plan as well to track progress

- Test plan is a live document
- Entry and Exit criteria
    - What you need to start
    - What you need to be done (DoD)

##### Estimation Techniques (Q)

Metric Based
- Data from previous or similar projects. Fairly accurate when comparing similar sized projects
Expert Based (e.g. Wideband Delphi)
- Based on experience. Could be from: Developers, Analysts, SMEs, Test Consultants, etc. 

#### Test Progress, Monitoring and Control

If the plan deviates from what we expect
- Take Actions: 

Can decide this:
- Metrics: How many test cases run in a certain amount of time
    - Work Product: Summary Reports

##### Common Metrics
- Percentage of work done
- Number of test cases executed
- Defect totals and details
- Subjective confidence of release
- Milestones achieved
- Test coverage

##### Test Coverage - Example 

"Metrics should be gathered during and at the end of a test level"

##### Test Control
- Guiding and taking actions that provide the best possible outcome for the project

- Re-prioritise tests, change test schedule, review product risks, adjust the scope (e.g. test 60% not 80%)

##### Test Reporting
- Just read this part in the book in Chapter 5

### Test Execution
- Run regression tests after making a change
- Run regression tests are run last

### Test strategy & Test approaches
- e.g. white-box, black-box

#### Test strategy 
- Preventative (i.e. initiated as early as possible - **prevent** errors being baked into the final project)
- Reactive ()

#### Test Approaches (Q)
Different strategies may be combined if required, but it is dependent on the context
- **Analytical** - **Risk** based testing
- **Model based** - based on **Use Case** or **Business Process map**
- **Methodical** - **Checklist**-based testing
- **Process** compliant - **Regulation** and **governance**
- **Reactive** - **Exploratory testing** (heuristics, error guessing)
- **Directed** - Getting an **SME**
- **Regression Averse** - **Avoid** going back to a **previous version** (focus on **Regression** testing)

### Entry & Exit Criteria

Entry Criteria (Definition of Ready)
: Definition of Ready
: What do we do before we start the next project?
: Determines when a test activity can start
: Defines preconditions for starting the testing activity

Exit Criteria (Definition of Done)

### Configuration Management
*""Advanced planning of configuration management is extremely important""* - Nish

- **Version Control EVERYTHING** and make sure everyone is on the same version of everything.
- Everything within the test project is working on the same version (working together)

- Repetative finding of the same defect because new versions aren't pushed live.

#### Bad configuration management
- Multiple people working on the same thing at the same time with no knowledge of each other.
- Maintenance difficulty due to incorrect documents (e.g. Test Plan)
- Faults that were fixed reappear
- Can't rollback to a previous version

#### Good configuration amanagement allows identification and reproduction of...

### Risk
*"The likelihood of something bad happening"* - Nish

#### ISTQB Definitions
Risk
: "A factor that could result in future negative consequences."
: Cost and Likelihood, or Impact and Probability

Risk Analysis
: 
: Risks and risk estimations change over time and are revisited as the project progresses

*"We need to test the things that probably won't break but would be very bad if they did"*

Product Risk (Quality Risks)
- Related to what is being produced (e.g. user encountering an error)
- Failures, Harm,.. etc.

Project Risk
- Related to the way the work is being carried out (e.g. sickness, damaged computers)
- Third party failure, contractual issues, etc...

#### Avoid Risk
- Brainstorming
- Make sure everyone is doing their job right
- Make sure the Test Basis is complete
- Workshops or Interviews ...

Quantify Risk
- Likelihood vs. Impact Risk Matrix
- Likelihood (% chance) * Impact (£ cost)
- e.g. 20% likelihood of £100,000 gives Risk as £20,000

Risk-Based testing
"Risk-based testing is an Analytical testing approach according to the ISTQB"
- Focus testing on riskiest areas
- Remove as much uncertainty as possible

### Defect Management

Defect
- Caused by Human error
- The actual and expected results differ

When you find a defect, you manage it
- Find as much information as possible so the developer can try to recreate it
    - Where I found it
    - When I found it
    - Test environment
    - Version of the software I was using
    - What I expected
    - What I got
- It has to be traceable back to the requirements

Defect Lifecycle
- Open and assign to developer
- Closed - Fixed - Then retest
- Closed - Developer cannot recreate

Defect Report

**Defect reports are a Tester's bread and butter**

Question: Who is most likely to use tool X?

Fill out table in Homework and Tasks

## Chapter 6 - Tool Support for Testing

"What is a test tool and what is the purpose of tooling?"
e.g. Test explorer, coverlet (coverage), JIRA (reporting & monitoring)

### Risk & Benefit of test tools

#### Benefits

- Improve efficiency (makes things easier - purpose of a tool)
- Automate activities that require lots of manual resources (regression)
- Automate activities that cannot be completed manually (performance)

#### Risks

### Effective Use of Tools

Select tools by:
- Pilot test of tool in my organisation
- Maturity of staff
- Tech support
- *Existing* process improvements
- Vendor evaluation
- Procs and cons of licensing
- Cost benefit analysis

#### Pilot Projects - Proof of Concept
- Will it make our processes better

#### Factords for *good* tool support
- Gather metrics
- Roll out incrementally
- Make sure everyone is well trained
- Monitor the benefits
