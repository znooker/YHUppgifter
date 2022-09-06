using System.Data;
using System.Diagnostics;
using System.Globalization;

internal class Program
{
    static int[] numbers = { 1, 101, 1001 };
    static DateTime today = DateTime.Now;

    private static void Main(string[] args)
    {
        PrintName("Andreas");

        Console.WriteLine("\nHårdkodat");
        Print101();

        Console.WriteLine("\nString loop");
        Run101stringLoop(6);
        Console.WriteLine();

        Console.WriteLine("\nInt loop");
        Run101intLoop(6);
        Console.WriteLine();

        Console.WriteLine("\nKör igenom numbers int array");
        LoopNumbersArray();
        Console.WriteLine("\n");

        PrintCurrentDateAndTime();
        Console.WriteLine("\n");

        SquareIntNumber(12345);
        Console.WriteLine("\n");

        RunFirst10InSequence(10);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Ålder om 10år");

        AgeInTenYears();

        //DateTime date1 = DateTime.Now;
        //DateTime date2 = DateTime.UtcNow;
        //DateTime date3 = DateTime.Today;

        //Console.WriteLine(date1);
        //Console.WriteLine(date2);
        //Console.WriteLine(date3);

        //Copy från MSDOCs Write sida.
        //Console.WriteLine("Standard Numeric Format Specifiers");
        //Console.WriteLine(
        //    "(C) Currency: . . . . . . . . {0:C}\n" +
        //    "(D) Decimal:. . . . . . . . . {0:D}\n" +
        //    "(E) Scientific: . . . . . . . {1:E}\n" +
        //    "(F) Fixed point:. . . . . . . {1:F}\n" +
        //    "(G) General:. . . . . . . . . {0:G}\n" +
        //    "    (default):. . . . . . . . {0} (default = 'G')\n" +
        //    "(N) Number: . . . . . . . . . {0:N}\n" +
        //    "(P) Percent:. . . . . . . . . {1:P}\n" +
        //    "(R) Round-trip: . . . . . . . {1:R}\n" +
        //    "(X) Hexadecimal:. . . . . . . {0:X}\n",
        //    -123, -123.35);

        //Console.WriteLine();
        //Console.WriteLine();
        //Console.WriteLine();

        //// Format the current date in various ways.
        //Console.WriteLine("Standard DateTime Format Specifiers");
        //Console.WriteLine(
        //    "(d) Short date: . . . . . . . {0:d}\n" +
        //    "(D) Long date:. . . . . . . . {0:D}\n" +
        //    "(t) Short time: . . . . . . . {0:t}\n" +
        //    "(T) Long time:. . . . . . . . {0:T}\n" +
        //    "(f) Full date/short time: . . {0:f}\n" +
        //    "(F) Full date/long time:. . . {0:F}\n" +
        //    "(g) General date/short time:. {0:g}\n" +
        //    "(G) General date/long time: . {0:G}\n" +
        //    "    (default):. . . . . . . . {0} (default = 'G')\n" +
        //    "(M) Month:. . . . . . . . . . {0:M}\n" +
        //    "(R) RFC1123:. . . . . . . . . {0:R}\n" +
        //    "(s) Sortable: . . . . . . . . {0:s}\n" +
        //    "(u) Universal sortable: . . . {0:u} (invariant)\n" +
        //    "(U) Universal full date/time: {0:U}\n" +
        //    "(Y) Year: . . . . . . . . . . {0:Y}\n",
        //    today);

    }

    static void PrintName(string firstName)
    {
        Console.WriteLine($"Hej jag heter: {firstName}");
    }

    static void Print101()
    {
        int a = 1;
        int b = 101;
        int c = 1001;

        Console.WriteLine($"{a},{b},{c}");
    }

    static void Run101stringLoop(int n)
    {
        string printNum = "1";
        Console.Write($"{printNum}, ");

        for (int i = 2; i < n; i++)
        {
            printNum = printNum + "0";
            Console.Write($"{printNum}1, ");
        }
        Console.Write($"{printNum}01");
    }

    static void Run101intLoop(int n)
    {
        int printNum = 1;
        Console.Write($"{printNum}, ");

        for (int i = 3; i < n; i++)
        {
            if(printNum == 1)
            {
                printNum = printNum * 100;
                Console.Write($"{printNum + 1}, ");
            }
                
            printNum = printNum * 10;
            Console.Write($"{printNum + 1}, ");
        }
        Console.Write($"{(printNum*10) + 1}");
    }

    static void LoopNumbersArray()
    {
        foreach (int number in numbers)
        {
            Console.Write($"{number}, ");
        }
    }

    static void PrintCurrentDateAndTime()
    {
        Console.Write($"Dagens datum är: {today:d} och kl är {today:t}");
    }

    static void SquareIntNumber(int input)
    {
        Console.Write(Math.Pow(input, 2));
    }

    //2, 4, 6, 8 ,10
    //-3,-,5-,-7-,-9

   static void RunFirst10InSequence(int n)
    {
        n+=2;
        for (int i = 2; i < n; i++)
        {
            if (i%2 == 0)
            {
                Console.Write($"{i}, ");
            }
            else
            {
                Console.Write($"{-(i)}, ");
            }
        }
    }


    static void AgeInTenYears()
    {
        DateTime birthday = GetUsersBirthDay();

        Console.WriteLine($"You are {today.Year-birthday.Year} years old");
        birthday = birthday.AddYears(-10);
        Console.WriteLine($"In 10 years time you will be {today.Year-birthday.Year}!");
         
    }
    
    static DateTime Birthday(int year, int month, int day)
    {
        DateTime birthday = new DateTime(year, month, day);

        return birthday;
    }

    static DateTime GetUsersBirthDay()
    {
        int year = 0;

        do
        {
            Console.Write("Year of birth, 4 digits: ");
            year = GetValidInt();
            if (year.ToString().Length != 4)
            {
                Console.Write("Please enter year of birth with 4 digits:");
                year = GetValidInt();
            }
        } while (year.ToString().Length != 4);

        Console.Write("\nMonth of birth:");
        int month = GetValidInt();
        Console.Write("\nDay of birth:");
        int day = GetValidInt();
        DateTime birthday = Birthday(year, month, day);

        return birthday;
    }
    static int GetValidInt()
    {
        bool isValidInt = false;
        int output = 0;
        do
        {
            string input = Console.ReadLine();
            isValidInt = int.TryParse(input, out output);

        } while (isValidInt == false);
        

        return output;
    }
        

  
    

}