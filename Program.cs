using System;

class Project
{
    public static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine($"I love writing simple code, but this must be a little bit more fun huh?\nHow could I possibly just leave it at writing only one simple phrase that is reused and reused over\nand over by millions of programmers. I decided to shake things up and be a little original.\nHence, the color change.");

        string[] spinner = { "|", "/", "-", "\\" };
        int counter = 0;

        DateTime endTime = DateTime.Now.AddSeconds(15);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Loading ");

        while (DateTime.Now < endTime)
        {
            Console.CursorVisible = false; // This hides the white box outline for the cursor :D
            Console.Write(spinner[counter % 4]);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);

            counter++;
            Thread.Sleep(100);
        }
        Console.CursorVisible = true; // Bring it back so that you can actually type and see it properly :)
        Console.WriteLine();
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Hello");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("     Universe!");
        Console.ResetColor();

        Console.WriteLine();
    }
}