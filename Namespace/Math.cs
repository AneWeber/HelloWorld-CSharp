namespace HelloWorld;
class Math
{
    public void DoMath()
    {
        Console.WriteLine("What is your first number?");
        string firstNumberInput = Console.ReadLine();
        Console.WriteLine("What is your second number?");
        string secondNumberInput = Console.ReadLine();

        if (float.TryParse(firstNumberInput, out float firstNumber) && float.TryParse(secondNumberInput, out float secondNumber))
        {
            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {firstNumber + secondNumber}");
            Console.WriteLine($"The difference of {firstNumber} and {secondNumber} is {firstNumber - secondNumber}");
            Console.WriteLine($"The product of {firstNumber} and {secondNumber} is {firstNumber * secondNumber}");
            if (secondNumber == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            else
            {
                Console.WriteLine($"The division of {firstNumber} by {secondNumber} is {firstNumber / secondNumber}");
            }
            Console.WriteLine($"The average of {firstNumber} and {secondNumber} is {(firstNumber + secondNumber) / 2 }");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid numbers.");
            //verify on input or make a loop to ask again
            DoMath(); // Recursive call to ask for input again
        }

    }

}
