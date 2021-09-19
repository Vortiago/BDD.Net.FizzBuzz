Feature: The Console Application should output text based on the Fizz buzz rules when given a number as input.

Scenario: Numbers divisible by three should have fizz returned
 Given a <number> as input
 When that number is divisible by three
 Then the return <value> should be fizz

 Examples:
     | number | value |
     | 3  | fizz |
     | 6  | fizz |

