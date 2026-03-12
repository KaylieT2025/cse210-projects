using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry> _entries;
    public void AddEntry(Entry newEntry)
    {

    }
    public void DisplayAll()
    {

    }
    public void SaveToFile(string fileName)
    {

    }
    /*SaveToFile (Journal)
    public static void SaveToFile(List<Entry> Journal)
    {
        Console.WriteLine("SAVING FILE...");

        string fileName = "fileWithAName.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry _entries in Journal)
            {
                outputFile.WriteLine(_entries._entryText);
            }
        }
    }*/


    public void LoadFromFile(string fileName)
    {

    }

}