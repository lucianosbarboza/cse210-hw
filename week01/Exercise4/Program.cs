using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished: ");   

        Console.Write("Enter a number: ");
        int Number = int.Parse(Console.ReadLine());
        
        while (Number != 0)
        {
            numbers.Add(Number);
            Console.Write("Enter a number: ");
            Number = int.Parse(Console.ReadLine());
        }
        
        int total = 0;
       
        foreach (int num in numbers)
        {
            total += num;
        }
        
        Console.WriteLine("The sum is: " + total);
        
        double average = (double)total / numbers.Count;
        
        Console.WriteLine("The average is: " + average);

        int max = numbers.Max();
        Console.WriteLine("The largest number is: " + max);
    }
}