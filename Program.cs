using System.Diagnostics;

class Program
{

    public static void Main()
    {
        Console.WriteLine("Search Methods press any key to start.");
        Console.ReadKey();
        Console.Clear();
        ParameterInput();
    }

    // ParameterInput method setting Two VARIABLES ( sType = type of search, searchParameter = direct ; relative, combined together searchType )


    public static string ParameterInput()
    {
        Console.WriteLine("Enter Search type // -DRL DIRECT URL //  // -SCH SEARCH //");

        string? sType = Console.ReadLine();
        string? searchParameter;
        string? searchType = null;


        if (sType == "-DRL")
        {
            Console.Clear();
            Console.WriteLine("-DRL Selected Direct URL Search method");
            searchParameter = Console.ReadLine();
            searchType = searchParameter;
            SearchMethod(searchType);
        }
        else if (sType == "-SCH")
        {
            Console.Clear();
            Console.WriteLine("-SCH Selected Search method");
            searchParameter = Console.ReadLine();
            searchType = "https://www.google.co.uk/search?q=" + searchParameter;
            SearchMethod(searchType);
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Unknown Command/ Mistyped"); ParameterInput();
        }
        return searchType!;

    }

    // SearchMethod takes in searchType formatted Previously by ParameterInput Method, to execute search by process within parameter.

    public static void SearchMethod(string? searchType)
    {
        Console.WriteLine("Debug: from MethodOutputTest this should be the correct type and parameter. : " + searchType);
        string? pResult = searchType;
        string? taskSearch = pResult;

        Process.Start(new ProcessStartInfo
        {
            FileName = taskSearch,
            UseShellExecute = true
        });

        // Variable choiceDataPull logic to call to method of pulling relative data. via HTMLAGILITYPACK to be completed

        Console.WriteLine("would you like to pull relative data? y/n");
        string? choiceDataPull = Console.ReadLine();
        if (choiceDataPull == "y")
        {
            Console.Clear();
        }
        else if (choiceDataPull == "n")
        {
            Console.Clear();
            Console.Beep();
        }

    }
}
