using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry e)
    {
        _entries.Add(e);
    }

    public void Display()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }

    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}|{e._prompt}|{e._response}");
            }
        }
    }

    public void Load(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            Entry e = new Entry();
            e._date = parts[0];
            e._prompt = parts[1];
            e._response = parts[2];
            _entries.Add(e);
        }
    }
}
