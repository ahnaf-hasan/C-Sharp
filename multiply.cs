using System;

class Program
{
    // Function to multiply two numbers
    static int MultiplyNumbers(int a, int b)
    {
        return a * b;
    }

  
    static void Main()
    {
        int result = MultiplyNumbers(5, 5);
        Console.WriteLine("The product is: " + result);
    }
}
