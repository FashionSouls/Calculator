# Calculator
This is a basic console program that will do basic arithmetic.

## How should the program work?
- Prompt user for two numbers
  - *If input is not a number, prompt user to try again.* 
- Ask user what type of arithmetic operation they would like to do (addition, subtraction, division or multiplication)
  - *If input is not a valid operation, prompt user to try again.* 
- Output result

## How do you get user input?
The "Console.ReadLine()" function will return the user's input in the terminal.

*Example:*
```c#
Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your age is: " + age);
```
