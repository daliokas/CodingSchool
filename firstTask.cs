using System;

namespace FirstTask
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Give me the word");
            var myString = Console.ReadLine();
            string firstChar = myString.Substring(0, 1);

            Console.WriteLine("Your new word:" +firstChar + myString + firstChar);
        }
    }
}