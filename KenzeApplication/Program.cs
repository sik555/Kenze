using KenzeApplication.Services;
using System;

namespace KenzeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentReader documentReader = new DocumentReader();            
            string[] file = documentReader.ReadDocument("input.txt");

            StringCombiner stringCombiner = new StringCombiner(file);
            stringCombiner.PrintCombinations();

            Console.WriteLine("Press a button to close");
            Console.ReadLine();
        }
    }
}
