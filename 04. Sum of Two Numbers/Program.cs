using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            bool hasToEnd = false;

            for (int i = number1; i <= number2; i++)
            {
                for (int j = number1; j <= number2; j++)
                {
                    counter++;

                    if (i + j == magicalNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicalNumber})");
                        hasToEnd = true;
                        break;
                    }
                }
                if (hasToEnd)
                {
                    break;
                }
            }

            if (hasToEnd == false)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicalNumber}");
            }
        }
    }
}