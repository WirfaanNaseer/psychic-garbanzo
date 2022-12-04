using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input a number > ");
        int number = Convert.ToInt32(Console.ReadLine());
        fizzbuzz(number);
    }
    private static void fizzbuzz(int number)
    {
        for (int i = 1; i < number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
} 