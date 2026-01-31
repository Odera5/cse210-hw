public class Entry
{
    public List<string> _entryList = new List<string>();
    int i = 1;
    public void DisplayEntry()
    {
        foreach (string entList in _entryList)
        { 
            Console.WriteLine($"{i}.{entList}");
            i +=1;
        }
    }
}