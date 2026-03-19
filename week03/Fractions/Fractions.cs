using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

public class Fractions
{
    private int _top;
    private int _bottom;

    public Fractions()
    {
        _top = 1;
        _bottom = 1;
        Console.WriteLine($"{_top}/{_bottom}");
    }

    public Fractions(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
        Console.WriteLine($"{_top}/{_bottom}");
    }

    public Fractions(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
        Console.WriteLine($"{_top}/{_bottom}");
    }

    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionsString()
    {
        return _top + "/" + _bottom;
    }

    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}