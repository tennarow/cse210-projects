public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    private PromptGenerator _promptGenerator = new PromptGenerator();

    public void AddEntry()
    {
        string prompt = _promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        Entry entry = new Entry
        {
            _prompts = prompt,
            _response = response,
            _date = DateTime.Now.ToString("MM/dd/yyyy")
        };

        _entries.Add(entry);
        Console.WriteLine("Entry added.");
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public string SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._prompts}|{entry._response}");
            }
        }
        return $"Journal saved to {filename}";
    }

    public string LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        _entries.Clear();
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry = new Entry { _date = parts[0], _prompts = parts[1], _response = parts[2] };
                _entries.Add(entry);
            }
        }
        return $"Journal loaded from {filename}";
    }
}