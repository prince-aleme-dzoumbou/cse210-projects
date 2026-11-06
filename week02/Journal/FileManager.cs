
public class FileManager
{
    public void Save(string filename, Journal journal)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in journal.GetEntries())
            {
                writer.WriteLine(entry.ToFileString());
            }
        }

        Console.WriteLine("Journal saved successfully!");
    }

    public void Load(string filename, Journal journal)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        List<Entry> entries = new List<Entry>();

        foreach (string line in File.ReadAllLines(filename))
        {
            if (!string.IsNullOrWhiteSpace(line))
            {
                entries.Add(Entry.FromFileString(line));
            }
        }

        journal.ReplaceEntries(entries);

        Console.WriteLine("Journal loaded successfully!");
    }
}