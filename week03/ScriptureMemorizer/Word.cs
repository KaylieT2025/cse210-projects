using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {

    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string clean = _text.Replace(",", "").Replace(".", "").Replace(";", "");
            return new string('_',clean.Length);
        }
        else
        {
            return _text;
        }
    }
}