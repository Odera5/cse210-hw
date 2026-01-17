using System;

public class Entry
{
    private string _date;
    private string _prompt;
    private string _response;
    private int _mood;

    public Entry(string date, string prompt, string response, int mood)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
        _mood = mood;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine($"Mood: {_mood}/10");
    }

    public string ToFileString()
    {
        return $"{_date}|{_prompt}|{_response}|{_mood}";
    }
}
