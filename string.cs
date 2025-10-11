using System;

class Program
{
    static void Main()
    {
        // Original string

        string originalString = "Cyber Security!";
        Console.WriteLine("Original String: " + originalString);

        // Reverse the string

        string reversedString = ReverseString(originalString);
        Console.WriteLine("Reversed String: " + reversedString);

        // Count letters (ignores spaces, punctuation, etc.)

        int letterCount = CountLetters(originalString);
        Console.WriteLine("Number of Letters: " + letterCount);
    }

  
    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }


    static int CountLetters(string str)
    {
        int count = 0;
        foreach (char c in str)
        {
            if (Char.IsLetter(c)) // Check 
            {
                count++;
            }
        }
        return count;
    }
}
