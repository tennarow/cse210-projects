using System;
using System.Collections.Generic;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private static Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] wordArray = text.Split(' ');
        foreach (string wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
    }
    public void HideRandomWords(int count)
    {
        int hiddenCount = 0;
        List<int> availableIndexes = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                availableIndexes.Add(i);
            }
        }

        count = Math.Min(count, availableIndexes.Count);

        while (hiddenCount < count && availableIndexes.Count > 0)
        {
            int randomIndex = _random.Next(availableIndexes.Count);
            int wordIndex = availableIndexes[randomIndex];
            _words[wordIndex].Hide();
            availableIndexes.RemoveAt(randomIndex);
            hiddenCount++;
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}