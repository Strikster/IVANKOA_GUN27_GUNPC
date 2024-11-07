using System;

class Program
{
    static void Main()
    {
      
        Console.WriteLine("Enter the first number:");
        if (!int.TryParse(Console.ReadLine(), out int firstNumber))
        {
            Console.WriteLine("Error! Invalid input. Please enter a valid integer.");
            return; 
        }

       
        Console.WriteLine("Enter the second number:");
        if (!int.TryParse(Console.ReadLine(), out int secondNumber))
        {
            Console.WriteLine("Error! Invalid input. Please enter a valid integer.");
            return; 
        }

       
        Console.WriteLine("Enter the operator (&, |, ^):");
        string operatorSymbol = Console.ReadLine();

        int result; 

       
        switch (operatorSymbol)
        {
            case "&":
                result = firstNumber & secondNumber;
                break;
            case "|":
                result = firstNumber | secondNumber;
                break;
            case "^":
                result = firstNumber ^ secondNumber;
                break;
            default:
                Console.WriteLine("Error! Invalid operator. Please enter one of the following: &, |, ^.");
                return; // Выход из программы
        }

        // Вывод результата в разных форматах
        Console.WriteLine($"Result (Decimal): {result}");
        Console.WriteLine($"Result (Binary): {Convert.ToString(result, 2)}");
        Console.WriteLine($"Result (Hexadecimal): {result:X}");
    }
}