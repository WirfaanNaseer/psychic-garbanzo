using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input a number > ");
        int number = Convert.ToInt32(Console.ReadLine());
        bool prime = isPrime(number);
        Console.WriteLine("Is a prime number: {0}", prime);
        for (int i = 1; i < 15; i++)
        {
            Console.WriteLine("Is {0} a prime number: {1}", i, isPrime(i));
        }
    }
    private static bool isPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }
        for (int i = 2; i <= number / 2; i++)
        {
            if(number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
} 