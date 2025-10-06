using System;

class Program
{
    static void Main()
    {
        int mark = 1;

        do
        {
            Console.WriteLine("Mark: " + mark);
            mark++;
        }
        while (mark <= 9);

        Console.WriteLine("Stop!");
    }
}