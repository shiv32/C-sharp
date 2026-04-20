//Safer version (recommended)
//Avoid crash if user types wrong input
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int.TryParse(Console.ReadLine(), out int a);

        Console.Write("Enter second number: ");
        int.TryParse(Console.ReadLine(), out int b);

        Console.WriteLine("Sum = " + (a + b));
    }
}

//----------------------------------------------------
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter first number: ");
//         int a = int.Parse(Console.ReadLine());

//         Console.Write("Enter second number: ");
//         int b = int.Parse(Console.ReadLine());

//         int sum = a + b;

//         Console.WriteLine("Sum = " + sum);
//     }
// }

