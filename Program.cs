using Classes;

Calculator calculator = new Calculator();

float firstNumber;
float secondNumber;
string calculation;

Console.WriteLine("Enter your first number:");
firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your second number:");
secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your calculation method (+, -, *, /):");
calculation = Console.ReadLine();

float result = calculator.GetResults(firstNumber, secondNumber, calculation);

Console.WriteLine("Result: " + result);

Console.WriteLine();