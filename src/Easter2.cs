using System;

    public class Easter
    {
        static void Main(string[] args)
        {
            int? year;
            int A, B, C, D, E, day;
            Console.Write("Enter a year> ");
            year = Int32.Parse(Console.ReadLine());
            if (year != null)
            {
                A = year.Value % 19;
                B = year.Value % 4;
                C = year.Value % 7;
                D = (19 * A + 24) % 30;
                E = (2 * B + 4 * C + 6 * D + 5) % 7;
                day = 22 + D + E;
                string verb = "is";
                if(year != DateTime.Now.Year)
                    verb = (year > DateTime.Now.Year ? "will be" : "was");
                if (day <= 31)
                    Console.Write("Easter Sunday {0}, {1} on March {2}{3}", year, verb, day,Environment.NewLine);
                else
                    Console.Write("Easter Sunday {0}, {1} on April {2}{3}", year, verb, day - 31,Environment.NewLine);
            }
            else
                Console.WriteLine("Year can not be null");
        }
    }
