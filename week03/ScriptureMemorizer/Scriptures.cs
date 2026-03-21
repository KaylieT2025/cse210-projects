using System;
using System.Collections.Generic;

public class Scripture
{
    private Refrence _refrence;
    private List<Word> _words;
    public Scripture(Refrence refrence, string text)
    {
        _refrence = refrence;
        _words = new List<Word>();
        string[] parts = text.Split(' ');

        foreach(string word in parts)
        {
            _words.Add(new Word(word));
        }

    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;
        while (hiddenCount < numberToHide)
        {
            int index = random.Next(_words.Count);

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        
        }    

    }
    public string GetDisplayText()
    {
        string result = _refrence.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }
        return result;
    }
    public bool IsCompletlyHidden()
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