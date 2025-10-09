using System;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people you appreciate?",
        "What are personal strengths of yours?",
        "Who are people you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private Random _rand = new Random();
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    { }

    private string GetRandomPrompt() => _prompts[_rand.Next(_prompts.Count)];
    private List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();

        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("You will have a few seconds to think about your responses.");
        ShowCountDown(3);

        Console.WriteLine("Start listing! (press Enter after each item — type 'done' to stop early)");
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (response?.Trim().ToLower() == "done")
                break;

            if (!string.IsNullOrWhiteSpace(response))
            {
                responses.Add(response);
            }
        }

        return responses;
    }

    public void Run()
    {
        DisplayStartingMessage();
        List<string> responses = GetListFromUser();
        Console.WriteLine($"You listed {responses.Count} items!");
        DisplayEndingMessage();
    }
}