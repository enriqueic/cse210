// Enrique Ibarra for BYU-PW
//
// Exceeding requirements: Makes sure prompts and questions are not repeated in the same session; 
// Breathing activity handles non-multiples of 10 seconds
using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();

        int userOption = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            userOption = int.Parse(Console.ReadLine()); 
            Console.Clear();

            switch (userOption)
            {
                case 1:
                    breathingActivity.Run();
                    break;
                case 2:
                    reflectingActivity.Run();
                    break;
                case 3:
                    listingActivity.Run();
                    break;
                case 4:
                    break;
                default:
                    Console.Write("Invalid option. Please try again.");
                    Console.ReadLine();
                    break;
            }
        } while (userOption != 4);
    }
}