// Exceeding requirements:
// The program only hides words that are not already hidden,
//   ensuring that new words are hidden on each iteration.
// This provides a smoother and more effective memorization experience.



using System;

class Program
{
    static void Main(string[] args)
    {
        string value = "";

        do{
       // Reference reference = new Reference();
          Reference reference1 = new Reference("John",3,16);
        //Reference reference2 = new Reference("Mathew",16,5,6);
        Scripture scripture = new Scripture();
        string script = scripture.DisplayScripture();


       //Console.WriteLine( reference.readReference());
       Console.WriteLine( $"{reference1.readReference()} {script}");
      // Console.WriteLine( reference2.readReference());

       Console.WriteLine("Press enter to continue or type 'quite' to finish:");
       value = Console.ReadLine();
        } while(value != "quite");
        
       
    }
}
