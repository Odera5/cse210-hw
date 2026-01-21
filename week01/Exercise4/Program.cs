using System;

using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {

           List<int> numbers = new List<int>();
           int input;
            int sum = 0;
            float average;
            int maxNum = 0;

        do
        {
            Console.Write("Input a number. Enter 0 when finished. ");
           input = int.Parse(Console.ReadLine());
           if(input != 0)
            {
                numbers.Add(input);
            }
           
        } while(input != 0);
        foreach(int num in numbers)
         {
             sum +=num;
             }

             maxNum = numbers[0];
             for(int i =0; i<numbers.Count; i++)
        {
            
            if (numbers[i] > maxNum)
            {
                maxNum =numbers[i];
            }
        }
        Console.WriteLine(sum);
        average = (float)sum/numbers.Count;
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Largest Number: {maxNum}");
        }
    }

