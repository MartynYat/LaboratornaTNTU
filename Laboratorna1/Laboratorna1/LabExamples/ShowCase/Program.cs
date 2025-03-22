using UtilityLibraries;

class Program
{
    static void Main(string[] args)
    {
        int row = 0;

        do
        {
            if (row == 0 || row >= 25)
                ResetConsole();

            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;

            Console.WriteLine($"Input: {input}");
            Console.WriteLine("Begins with uppercase? " +
                 $"{(input.StartsWithUpper() ? "Yes" : "No")}");

            Console.WriteLine();
            row += 4;
        } while (true);

        return;
    }

    static void ResetConsole()
    {
        Console.Clear();
        Console.WriteLine("Press <Enter> only to exit; otherwise, enter a string and press <Enter>:\n");
    }
}
