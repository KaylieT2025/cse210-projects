using System;

public class MathAssignment: Assignment
{
    private string _textbookSection;
    private string _problem;

    public MathAssignment(string textbookSection, string problem, string studentName, string topic) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problem = problem;

    }
    public string GetHomeworkList()
    {
        return $"{_textbookSection} - {_problem}";
    }
}