public class Entry
{
    public string _prompts;
    public string _response;
    public string _date;

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompts}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine();
    }
}   