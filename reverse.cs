using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a word to reverse: ");
        string input = Console.ReadLine();

        // Reverse the word
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);

        Console.WriteLine("Reversed word: " + reversed);
    }
}
