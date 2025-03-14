using Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        float firstNumber = 0;
        float secondNumber = 0;
        string calculation = "";

        bool firstNumberCheck = false;
        while (!firstNumberCheck) {
            Console.WriteLine("Enter your first number:");
            string value = Console.ReadLine();

            firstNumberCheck = float.TryParse(value, out firstNumber);

            if (!firstNumberCheck) {
                Console.WriteLine("Not a valid number, please try again.\n");
            }
        }

        bool secondNumberCheck = false;
        while (!secondNumberCheck) {
            Console.WriteLine("Enter your second number:");
            string value = Console.ReadLine();

            secondNumberCheck = float.TryParse(value, out secondNumber);

            if (!secondNumberCheck) {
                Console.WriteLine("Not a valid number, please try again.\n");
            }
        }

        while (!calculator.CheckCalculationInput(calculation)) {
            
            Console.WriteLine("Enter your calculation method (+, -, *, /):");
            calculation = Console.ReadLine();
            
            if (!calculator.CheckCalculationInput(calculation)) {
                Console.WriteLine("Invalid calculation method, please try again.\n");
            }
        }

        float result = calculator.GetResults(firstNumber, secondNumber, calculation);

        Console.WriteLine("Result: " + result);
    }
}