using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    protected int Duration => _duration;
    protected string Name => _name;
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity! This is designed to help you relax and focus.");
        Console.WriteLine(_description);
        Console.WriteLine("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine() ?? "30");

        Console.WriteLine("Prepare to begin... ");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Great job! You've completed the Mindfulness Activity. Take this calmness with you throughout your day.");
        ShowSpinner(2);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int duration)
    {
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        string[] spinnerChars = { "|", "/", "-", "\\" };
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinnerChars[i % spinnerChars.Length]);
            System.Threading.Thread.Sleep(250);
            Console.Write("\b");
            i++;
        }
    }
    
    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}