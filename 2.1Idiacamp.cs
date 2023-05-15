using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the maximum capacity of the water tank: ");
        double Vmax = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the average volume of water consumed during breaks: ");
        double Vdrink = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the volume of water refilled during each refill: ");
        double Vfill = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the time interval between breaks: ");
        int Tday = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the time interval between refills: ");
        int Tfill = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the total duration of the activity in hours: ");
        int Ttotal = Convert.ToInt32(Console.ReadLine());

        double Vremaining = Vmax;
        bool enoughWater = true;
        bool overflowWater = false;

        for (int t = 0; t < Ttotal; t++)
        {
            if (t % Tday == 0)
            {
                Vremaining -= Vdrink;
                if (Vremaining < 0)
                {
                    enoughWater = false;
                    break;
                }
            }

            if (t % Tfill == 0)
            {
                Vremaining += Vfill;
                if (Vremaining > Vmax)
                {
                    overflowWater = true;
                    break;
                }
            }
        }

        if (enoughWater)
        {
            Console.WriteLine("Enough Water, {0} left", Vremaining);
            if (overflowWater)
            {
                Console.WriteLine("Overflow Water");
            }
        }
        else
        {
            Console.WriteLine("Not Enough Water");
        }
    }
}