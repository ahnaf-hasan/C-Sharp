using System;

class Program
{
    static void Main()
    {
        int rows;

        Console.Write("Enter the number of rows for the pyramid: ");
        rows = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= rows; i++)
        {
            
            for (int space = 1; space <= rows - i; space++)
            {
                Console.Write(" ");
            }

            // Print stars
            for (int star = 1; star <= (2 * i - 1); star++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
