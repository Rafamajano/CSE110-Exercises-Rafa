using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
                break;

            numbers.Add(num);
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        double average = (numbers.Count > 0) ? (double)sum / numbers.Count : 0;
        int max = (numbers.Count > 0) ? numbers[0] : 0;
        foreach (int number in numbers)
        {
            if (number > max)
                max = number;
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}
