using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by guiding you through deep breathing. Clear your mind and focus on your breath.")
    { }
    public void Run()
    {
        DisplayStartingMessage();

    DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now<endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
    Console.WriteLine("Breathe out...");
            ShowCountDown(4);
}
        DisplayEndingMessage();
    }
}
