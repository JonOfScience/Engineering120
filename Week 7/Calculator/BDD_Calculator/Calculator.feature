Feature: Calculator

As a Spartan who is bad at maths,
I want a calculator that takes numbers,
So I can do maths on them

@HappyPath
Scenario: Addition
	Given I have a calculator
	And I enter 5 and 2 in the calculator
	When I press add
	Then the result should be 7

@HappyPath
Scenario: Subtract
    Given I have a calculator
    And I enter <x> and <y> in the calculator
    When I press Subtract
    Then the result should be <result>
Examples:
    | x    | y   | result |
    | 1    | 1   | 0      |
    | 150  | 100 | 50     |
    | 0    | 1   | -1     |
    | 1000 | 1   | 999    |

@HappyPath
Scenario: Multiply
    Given I have a calculator
    And I enter <x> and <y> in the calculator
    When I press multiply
    Then the result should be <result>

Examples: 
| x | y   |result  |
| 1 | 1   | 1      |
| 2 | 3   | 6      |
| 9 | 9   | 81     |
| 5 | -17 | -85    |

@SadPath
Scenario: Divide By Zero
    Given I have a calculator
    And I enter <x> and 0 in the calculator
    When I press divide
    Then a DivideByZero Exception should be thrown
    And the exception should have the message "Cannot Divide By Zero"
    Examples:
    | x | 
    | 1 | 
    | 6 |

@HappyPath
Scenario: SumOfNumbersDivisibleBy2
    Given I have a calculator
    And I enter the numbers below to a list
    | nums |
    | 1    |
    | 2    |
    | 3    |
    | 4    |
    | 5    |
    When I iterate through the list to add all the even numbers
    Then the result should be 6