using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading.Tasks;

string value;
do
{
    int sol;
    Console.Write("Enter first number:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter second number:");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter symbol(/,+,-,*):");
    string symbol = Convert.ToString(Console.ReadLine());

    switch (symbol)
    {
        case "+":
            sol = num1 + num2;
            Console.WriteLine("Solution:" + sol);
            break;
        case "-":
            sol = num1 - num2;
            Console.WriteLine("Solution:" + sol);
            break;
        case "*":
            sol = num1 * num2;
            Console.WriteLine("Solution:" + sol);
            break;
        case "/":
            sol = num1 / num2;
            Console.WriteLine("Solution:" + sol);
            break;
        default:
            Console.WriteLine("Wrong input");
            break;
    }
    Console.Write("Do you want to continue(y/n):");
    value = Console.ReadLine();
}
while (value == "y" || value == "Y");
