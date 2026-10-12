using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.IO;
class JournalEntry
{
    public List <Entry> _entry = new List<Entry>();

    public PromptGenerator PG = new PromptGenerator();

    
    public void display()
    {
        foreach(Entry entry in _entry) {
        entry.Display();
        }
    }

   public void ToFile(string write)
{
    using (StreamWriter outputFile = new StreamWriter(write))
    {
        foreach (Entry everyname in _entry)
        {
            outputFile.WriteLine(everyname.toFile());
        }
    }
}

    public void FromFile(string txt)
{
    string[] input = File.ReadAllLines(txt);

    _entry.Clear();

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] != "")
        {
            Entry newEntry = new Entry();
            newEntry.fromFile(input[i]);
            _entry.Add(newEntry);
        }
    }
}

    public void newEntry()
    {
        string prompt = PG.Prompt();
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        
        Entry newEntry = new Entry();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        newEntry.fromFile(dateText + "#" + prompt + "#" + response);
        _entry.Add(newEntry);
    }


}