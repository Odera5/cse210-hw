using System;

class Program
{
    

    static void Main(string[] arg)
    {
        PromptGenerator ShowPrompt = new PromptGenerator();
        Journal journal = new Journal();
        // Entry _journalEnrty = new Entry();
        journal.DisplayMenu();
        // journal.AddEntry();
        // _journalEnrty.DisplayEntry();
        // ShowPrompt.Prompt();

    }

   
}
