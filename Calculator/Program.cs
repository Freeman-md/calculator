using Calculator;

internal class Program
{
    private static void Main(string[] args)
    {
        string selectedInput;

        do
        {
            DisplayMenu();

            selectedInput = Console.ReadLine();

            if (selectedInput == "5")
            {
                break;
            }

            double firstNumber = GetNumber("Enter first number: ");
            double secondNumber = GetNumber("Enter first number: ");

            double result = selectedInput switch
            {
                "1" => ArithmeticOperations.Add(firstNumber, secondNumber),
                "2" => ArithmeticOperations.Subtract(firstNumber, secondNumber),
                "3" => ArithmeticOperations.Multiply(firstNumber, secondNumber),
                "4" => ArithmeticOperations.Divide(firstNumber, secondNumber),
                _ => 0,
            };

            Console.WriteLine($"Result: {result}\n");


        } while (selectedInput != "5");

        Console.WriteLine("Thanks for using my simple calculator.");
    }

    static void DisplayMenu()
    {
        Console.WriteLine("What would you like to do today?");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Exit application");

        Console.Write("Please enter a number [1 - 5]: ");
    }

    static double GetNumber(string prompt)
    {
        Console.Write(prompt);
        return double.Parse(Console.ReadLine());
    }
}