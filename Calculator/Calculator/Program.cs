
using System.Formats.Asn1;

internal class Program
{
    private static void Main(string[] args)
    {
        do {
            double num1 = 0;
            double num2 = 0;
            double result = 0;
            char option;

            Console.WriteLine("CALCULATOR");

            Console.Write("Enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter option: ");
            option = Convert.ToChar(Console.ReadLine());

            switch(option) {
            case '+': Console.WriteLine("Result: " + (num1 + num2));
                break;
            case '-': Console.WriteLine("Result: " + (num1 - num2));
                break;
            case '*': Console.WriteLine("Result: " + num1 * num2);
                break;
            case '/': Console.WriteLine("Result: " + num1 / num2);
                break;          
            }
            Console.WriteLine("Continue?");
            Console.WriteLine("yes - no");

        }while(Console.ReadLine() == "yes");   
    }
}