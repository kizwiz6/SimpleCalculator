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
        Console.WriteLine("Input your first number");

        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Input your second number");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("What would you like to do with the numbers? Add, Subtract, Multiply, Divide, or Modulo?");
        string response = Console.ReadLine().ToLower();

        HandleMathsOperation(calc, num1, num2, response);
    }

    private static void HandleMathsOperation(Calculator calc, int num1, int num2, string response)
    {
        switch (response)
        {
            case "add":
                Console.WriteLine(calc.Add(num1, num2));
                break;
            case "subtract":
                Console.WriteLine(calc.Subtract(num1, num2));
                break;
            case "multiply":
                Console.WriteLine(calc.Multiply(num1, num2));
                break;
            case "divide":
                Console.WriteLine(calc.Divide(num1, num2));
                break;
            case "modulo":
                Console.WriteLine(calc.Modulo(num1, num2));
                break;
            default:
                Console.WriteLine("wtf");
                break;
        }
    }
}