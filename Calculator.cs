internal class Calculator
{
    public Calculator()
    {

    }

    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Divide(int a, int b)
    {
        return a / b;
    }

    public int Modulo(int a, int b)
    {
        return a % b;
    }

    private static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        int num1;

        while (true)
        {
            Console.WriteLine("Input your first number");
            if (int.TryParse(Console.ReadLine(), out num1))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }

        int num2;

        while (true)
        {
            Console.WriteLine("Input your second number");
            if (int.TryParse(Console.ReadLine(), out num2))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again");
            }
        }

        while (true)
        {
            Console.WriteLine("What would you like to do with the numbers? Add, Subtract, Multiply, Divide, or Modulo?");
            string response = Console.ReadLine().ToLower();

            try
            {
                HandleMathsOperation(calc, num1, num2, response);
                break; // break out of the loop if operation is successful.
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid operation. Please try again.");
            }
        }
    }

    private static void HandleMathsOperation(Calculator calc, int num1, int num2, string response)
    {
        while (true)
        {
            switch (response)
            {
                case "add":
                    Console.WriteLine(calc.Add(num1, num2));
                    return;
                case "subtract":
                    Console.WriteLine(calc.Subtract(num1, num2));
                    return;
                case "multiply":
                    Console.WriteLine(calc.Multiply(num1, num2));
                    return;
                case "divide":
                    Console.WriteLine(calc.Divide(num1, num2));
                    return;
                case "modulo":
                    Console.WriteLine(calc.Modulo(num1, num2));
                    return;
                default:
                    Console.WriteLine("Invalid operation. Please try again. What would you like to do with the numbers? Add, Subtract, Multiply, Divide, or Modulo?");
                    response = Console.ReadLine().ToLower(); // Ask the user for input again
                    break; // Break out of the switch statement and continue the loop
            }
        }

    }
}