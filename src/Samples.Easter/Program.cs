using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.Easter
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, day;
            int? year = null;
            string syear = null;
            Utilities.ShowMenu("Date of the Easter Sunday");
            do
            {
                 syear = Utilities.Scanf("Enter a year");
                if (syear != null)
                {
                    year = Int32.Parse(syear);
                    a = year.Value % 19;
                    b = year.Value % 4;
                    c = year.Value % 7;
                    d = (19 * a + 24) % 30;
                    e = (2 * b + 4 * c + 6 * d + 5) % 7;
                    day = 22 + d + e;
                    string verb = "is";
                    string msg = null;
                    if (year != DateTime.Now.Year)
                        verb = (year > DateTime.Now.Year ? "will be" : "was");
                    if (day <= 31)
                        msg = String.Format("Easter Sunday {0}, {1} on March {2}{3}", year, verb, day, Environment.NewLine);
                    else
                        msg = String.Format("Easter Sunday {0}, {1} on April {2}{3}", year, verb, day - 31, Environment.NewLine);
                    Utilities.PrintMessage(msg);
                }
                else
                    Utilities.PrintMessage("Year can not be null");

            } while (syear != null);
            Utilities.Pause();

        }
    }
}
