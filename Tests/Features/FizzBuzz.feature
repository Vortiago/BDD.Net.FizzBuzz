Feature: The Console Application should output text based on the Fizz buzz rules when given a number as input.

Scenario: Numbers divisible by three should have fizz returned.
    Given a <number> as input
    When that number is divisible by three
    Then the return should be <value>

    Examples:
        | number | value |
        | 3  | fizz |
        | 6  | fizz |

Scenario: Numbers divisible by five should have buzz returned.
    Given a <number> as input
    When that number is divisible by five
    Then the return should be <value>

    Examples:
        | number | value | 
        | 5  | buzz  |
        | 10 | buzz |


Scenario: Numbers divisible by fifteen should have fizzbuzz returned.
    Given a <number> as input
    When that number is divisible by fifteen
    Then the return should be <value>

    Examples:
        | number | value | 
        | 15  | fizz buzz  |
        | 30  | fizz buzz  |

Scenario: Numbers not handled by other rules should be returned with same value.
    Given a <number> as input
    When that number is not part of the other rules
    Then the return should be <number>

    Examples:
        | number | 
        | 1  |
        | 2  |
        | 4  |