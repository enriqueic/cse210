//Enrique Ibarra for BYU-PW
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your fist name?: ");
        string firstName = Console.ReadLine();
        Console.Write("What is your fist name?: ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
    }
}