namespace Classes
{
    public class Calculator {
        public float GetResults(float firstNumber, float secondNumber, string calculation) {
            switch (calculation)
            {
                case "+":
                    return firstNumber + secondNumber;
                case "-":
                    return firstNumber - secondNumber;
                case "*":
                    return firstNumber * secondNumber;
                case "/":
                    return firstNumber / secondNumber;
                default:
                    return 0;
            }
        }

        public bool CheckCalculationInput(string value) {
            if (value .Equals("+") || value .Equals("-") || value .Equals("*") || value .Equals("/")) {
                return true;
            } else {
                return false;
            }
        }
    }
}