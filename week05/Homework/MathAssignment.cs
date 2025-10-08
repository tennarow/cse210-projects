using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public string GetTextbookSection()
    {
        return _textbookSection;
    }

    public void SetTextbookSection(string section)
    {
        _textbookSection = section;
    }

    public string GetProblems()
    {
        return _problems;
    }

    public void SetProblems(string problems)
    {
        _problems = problems;
    }

    public string GetHomeworkDetails()
    {
        return $"{GetAssignmentDetails()} - Section: {_textbookSection}, Problems: {_problems}";
    }
}