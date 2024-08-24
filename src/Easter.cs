using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples
{
    public class Easter
    {
        static void Main(string[] args)
        {
            int? year;
            int A, B, C, D, E, day;
            Console.Clear();
            Console.Write("Enter a year: ");
            year = Util.ReadLineAsInt();
            if (year != null)
            {
                A = year.Value % 19;
                B = year.Value % 4;
                C = year.Value % 7;
                D = (19 * A + 24) % 30;
                E = (2 * B + 4 * C + 6 * D + 5) % 7;
                day = 22 + D + E;
                string verb = null;
                if(year == DateTime.Now.Year)
                    verb = "is";
                else
                    verb = (year > DateTime.Now.Year ? "will be" : "was");
                Console.Write("The date of the Easter Sunday in {0} " + verb +" in ",year);
                if (day <= 31)
                    Console.Write("march {0}", day);
                else
                    Console.Write("april {0}", day - 31);
            }
            else
                Console.WriteLine("Year is null");
            Util.Pause();
        }
    }
}
