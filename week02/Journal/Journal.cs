using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

public class Journal
{
    List<string> _menu = new List<string>()
    {
        "Adding an entry","Displaying all the entries","Saving to a file","Loading from a file", "Quit"
    };

    PromptGenerator _entry = new PromptGenerator();
     Entry _journalEnrty = new Entry();
    int i;
    int j = 0;
    int z= 1;
    int _choice;
     string _takeEntry;

     string date = DateTime.Now.ToString("yyyy-MM-dd");


    public void DisplayMenu()
    {
        do
        {
            i=0;
        Console.WriteLine("Welcome to the journal program!");
        Console.WriteLine("Please select one of the following choices:");

        foreach(string menuItem in _menu)
        {
            i +=1;
            Console.WriteLine($"{i}.{menuItem}");
        }

        Console.WriteLine("What would you like to do? ");
        int.TryParse(Console.ReadLine(), out _choice);


        if(_choice == 1){

        Console.WriteLine(_entry._prompt[j]);
         _takeEntry = Console.ReadLine();
         _journalEnrty._entryList.Add($"{_entry._prompt[j]} {_takeEntry}: Date:{date}");
        j += 1;

        }

        // Entry _journalEnrty = new Entry();

         if(_choice == 2)
            {
                _journalEnrty.DisplayEntry(); 
                _choice = 5;
            }
            string filePath = "journal.txt";

            if(_choice == 3)
            {
                

                foreach(string file in _journalEnrty._entryList)
                {
                   File.AppendAllText(filePath, z+"."+ file + "\n");
                     z += 1;
                }
                Console.WriteLine("File saved!");
            }

            if(_choice == 4)
            {
                

                if (File.Exists(filePath)){
                    string[] lines = File.ReadAllLines(filePath);
                    foreach (string line in lines){
                        Console.WriteLine(line);
                        }
                    }
                else
                {
                    Console.WriteLine("File not found!");
                }
            }

        
        
        } while(_choice != 5);
    }

    // public Journal()
    // {
    //     AddEntry();
    // }

    // Entry _journalEnrty = new Entry();

    // public void AddEntry()
    // {
    //     _journalEnrty._entryList.Add(_takeEntry);
    // }

    
}