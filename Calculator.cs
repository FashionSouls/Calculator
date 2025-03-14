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
    }
}