using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input a byte sequence > ");
        string byteSeq = Console.ReadLine();
        bool parity = OddParity(byteSeq);
        Console.WriteLine("Odd Parity (correct): {0}", parity);
    }
    private static bool OddParity(string sequence)
    {
        int ones = 0;
        for (int i = 0; i< sequence.Length; i++) 
        {
            if (sequence.Substring(i, 1) == "1")
            {
                ones++;
            }
            else if(sequence.Substring(i, 1) != "0")
            {
                Console.WriteLine("Warning: nonbinary character in string detected. Returning false");
                return false;
            }
        }
        if (ones % 2 == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}