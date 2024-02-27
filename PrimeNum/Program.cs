using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        long n;
        Console.Write("Enter a positive integer greater than 1: ");
        if (!long.TryParse(Console.ReadLine(), out n) || n <= 1)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer greater than 1.");
            return;
        }

        // Start the timer
        Stopwatch timer = Stopwatch.StartNew();

        long primeCount = 0;

        // Runs a for loop to get all numbers and checks through the IsPrime func if they're prime
        Console.Clear();
        for (int i = 2; i <= n; i++)
        {
            Console.Write($"\rCurrently Checking {i}");
            if (IsPrime(i))
            {
                primeCount++;
            }
        }

        // Stop the timer
        timer.Stop();

        // Display total prime numbers and elapsed time
        Console.Clear();
        Console.WriteLine($"Total prime numbers up to {n}: {primeCount}");
        Console.WriteLine($"Elapsed time: {timer.Elapsed.TotalSeconds} seconds");
    }

    public static bool IsPrime(long num)
    {
        if (num <= 1)
        {
            return false;
        }

        if (num == 2)
        {
            return true;
        }

        if (num % 2 == 0)
        {
            return false;
        }

        for (long i = 3; i <= Math.Sqrt(num); i += 2)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
