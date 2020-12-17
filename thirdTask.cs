using System;

namespace thirdtask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your word");
            var input = Console.ReadLine();
            var charArray = input.ToCharArray();
            Array.Reverse(charArray);
            var reversed = new string(charArray);
            Console.WriteLine(reversed);
        }
    }
}