//Enrique Ibarra for BYU-PW
using System;
using System.Data.SqlTypes;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        string answer = Console.ReadLine();
        int answerint = int.Parse(answer);
        int percentage = int.Parse(answer.Substring(1, 1));
        string letter = "";

        if (answerint >= 90)
        {
            letter = "A";
        }

        else if (answerint >= 80)
        {
            letter = "B";
        }

        else if (answerint >= 70)
        {
            letter = "C";
        }

        else if (answerint >= 60)
        {
            letter = "D";
        }

        else if (answerint < 60 && answerint > 0)
        {
            letter = "F";
        }

        // stretch challenge
        if (letter != "F" && letter != "")
        {
            if (percentage <= 3)
            {
                letter = letter + "-";
            }

            else if (percentage >= 7)
            {
                letter = letter + "+";
            }
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (answerint >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }

    }
}