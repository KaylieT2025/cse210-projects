using System.Security.Cryptography.X509Certificates;
using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries avaiable.");
            return;
        }
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
        Console.WriteLine($"Total of entries: {_entries.Count}");
    }
    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }
    public void LoadFromFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File does not exist.");
            return;
        }
        string[] lines = File.ReadAllLines(fileName);
        foreach (string line in lines)
        {

            string[] parts = line.Split("|");

            if (parts.Length == 3)
            {
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._promptText = parts[1];
                entry._entryText = parts[2];
                _entries.Add(entry);
            }
        }
        
    }

}