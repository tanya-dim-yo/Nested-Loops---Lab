﻿using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string destination = Console.ReadLine();

                if (destination == "End")
                {
                    break;
                }

                double requiredBudget = double.Parse(Console.ReadLine());
                double savings = 0.0;

                while (savings < requiredBudget)
                {
                    double sum = double.Parse(Console.ReadLine());
                    savings += sum;
                }

                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}