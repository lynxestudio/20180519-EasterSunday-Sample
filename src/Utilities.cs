using System;

namespace Samples{
    public static class Util
    {
        public static void Pause()
        {
            Console.WriteLine("{0}Press any key to continue...",Environment.NewLine);
            Console.ReadLine();
        }
        
        public static int? ReadLineAsInt()
        {
            var input = Console.ReadLine();
            if(string.IsNullOrEmpty(input) || input.Length == 0)
                return null;
            else
                return Convert.ToInt32(input);
        }
    }
}