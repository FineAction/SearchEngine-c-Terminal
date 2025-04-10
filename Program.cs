using System.Diagnostics;

class Program
{
    public static void Main()
    {
        Console.WriteLine("WELCOME please enter PARAMETER.\npress enter and start.");
        Console.ReadKey();
        Console.Clear();
        Parameter();
    }
    public static string Parameter()
    {
        string? parameterInput = Console.ReadLine();

        if (parameterInput == null)
        {
            Console.WriteLine("input is null returning to Main method.");
            Thread.Sleep(2000);
            Console.Clear();
            Main();
        }
        else
        {
            Console.WriteLine("Check 1.: Success! Parameter Built.");
            Search(parameterInput);
        }
        return parameterInput;
    }
    public static async Task Search(string parameterInput)
    {
        string pResult = parameterInput;
        string url = "https://www.google.com/search?q=" + pResult;

        Console.WriteLine(url);
        Process.Start(new ProcessStartInfo
        {
            FileName = url,
            UseShellExecute = true
        });
        Console.WriteLine("Browser opened Successfully.\nWould you like to search again? y/n");
        string? end = Console.ReadLine();
        if (end == "y")
        {
            Main();
        }
        else if (end == "n")  
        {
            Console.Clear();
            Console.Beep();
        }

    }

}