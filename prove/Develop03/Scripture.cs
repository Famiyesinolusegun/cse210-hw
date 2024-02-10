 
using System;
public class Scripture
{
    private Reference _reference;
    private string _scriptureText;
    private List<string> _hiddenWords;

    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        _scriptureText = scriptureText;
        _hiddenWords = new List<string>();
    }

    public string GetBook()
    {
        return _reference.GetBook();
    }

    public int GetChapter()
    {
        return _reference.GetChapter();
    }

    public int GetStartVerse()
    {
        return _reference.GetStartVerse();
    }

    public int GetEndVerse()
    {
        return _reference.GetEndVerse();
    }

    public string GetScriptureText()
    {
        return _scriptureText;
    }

    public string GetDisplayText()
    {
        string displayText = $"{_reference.GetDisplayText()}\n{_scriptureText}";

        if (_hiddenWords.Count > 0)
        {
            displayText += "\nHidden Words: ";

            foreach (string word in _hiddenWords)
            {
                displayText += word + " ";
            }
        }

        return displayText;
    }

    public void HideRandomWords(int count)
    {
        string[] words = _scriptureText.Split(' ');

        if (count > words.Length)
        {
            count = words.Length;
        }

        Random random = new Random();

        for (int i = 0; i < count; i++)
        {
            int randomIndex = random.Next(0, words.Length);

            if (!_hiddenWords.Contains(words[randomIndex]))
            {
                _hiddenWords.Add(words[randomIndex]);
                words[randomIndex] = "______";
            }
            else
            {
                i--;
            }
        }

        _scriptureText = string.Join(" ", words);
    }

    public bool IsCompletelyHidden()
    {
        string[] words = _scriptureText.Split(' ');

        foreach (string word in words)
        {
            if (word != "______")
            {
                return false;
            }
        }

        return true;
    }
}