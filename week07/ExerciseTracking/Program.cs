using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        SwimmingActivity swimming = new SwimmingActivity("05 Aug 2025", 90, 25);
        RunningActivity running = new RunningActivity("03 Nov 2024", 30, 4.8);
        CyclingActivity cycling = new CyclingActivity("10 Aug 2025", 90, 5);
        activities.Add(swimming);
        activities.Add(running);
        activities.Add(cycling);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}