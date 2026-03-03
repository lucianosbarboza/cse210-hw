using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your grade percentage?: ");
        string gradePercentage = Console.ReadLine();
        string sign = "";
        int grade = int.Parse(gradePercentage);
        int lastDigit = grade % 10;
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        if (letter != "F")
        {
            if (lastDigit >= 7)
            {
                if (letter != "A")
                {
                    sign = "+";
                }
            }
            else if (lastDigit < 3)
                {
                    sign = "-";
                }
        }
        Console.WriteLine($"Your letter grade is {letter}{sign}.");
        if (grade >= 70)
            {
            Console.WriteLine("Congratulations! You passed the course!");
            }
        else
            {
            Console.WriteLine("You did not pass. Better luck next time!");
            }
    }      
}
