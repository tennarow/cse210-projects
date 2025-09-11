public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "How did I see the hand of the Lord in my life today?",
        "What is the strongest emotion I felt today?",
        "If I could do one thing differently today, what would it be?",
        "What was the best part of your day?",
        "What was the most challenging part of your day?",
        "What is something new you learned today?",
        "Describe a moment that made you smile today.",
        "What are you grateful for today?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}