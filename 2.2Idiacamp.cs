using System;

class Program
{
    static void Main(string[] args)
    {
        double B1, B2, B3, payment;
        
        Console.Write("Enter balance 1: ");
        B1 = double.Parse(Console.ReadLine());

        Console.Write("Enter balance 2: ");
        B2 = double.Parse(Console.ReadLine());

        Console.Write("Enter balance 3: ");
        B3 = double.Parse(Console.ReadLine());

        while (true)
        {
            Console.Write("Enter payment amount (0 or negative number to stop): ");
            payment = double.Parse(Console.ReadLine());

            if (payment <= 0)
                break;

            if (B1 >= payment)
                B1 -= payment;
            else if (B2 >= payment)
                B2 -= payment;
            else if (B3 >= payment)
                B3 -= payment;
        }

        Console.WriteLine($"Balance 1: {B1}, Balance 2: {B2}, Balance 3: {B3}");

        if (B1 + B2 + B3 > 0)
            Console.WriteLine("Left: " + (B1 + B2 + B3));
    }
}