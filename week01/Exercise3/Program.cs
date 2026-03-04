using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        Console.Write("What is your guess?: ");
        int guess = int.Parse(Console.ReadLine());
        

        while (guess != number)
    {
    if (guess < number)
    {
        Console.WriteLine("higher");
    }
    else
    {
        Console.WriteLine("lower");
    }

    Console.Write("What is your guess?: ");
    guess = int.Parse(Console.ReadLine()); // ← AQUI você muda o valor
    }
       Console.WriteLine("Congratulations! You guessed the magic number!");
    }
}