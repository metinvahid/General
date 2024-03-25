using System;

namespace ReadInt
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int j = ReadInt("a: ","a eded deyil");
            int r = ReadInt("b: ","b eded deyil");
            int k = j + r;
            Print($"cavab:{k}");

        }

        static void Print(string messages)
        {
            var backupColor = Console.ForegroundColor;
            var backgroundupColor = Console.BackgroundColor;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.White;

            Console.Write(messages);

            Console.ForegroundColor = backupColor;
            Console.BackgroundColor = backgroundupColor;
        }
        static int ReadInt(string caption, string errorMessages)
        {
            var backupColor = Console.ForegroundColor;
           
        l1:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(caption);
            Console.ForegroundColor = backupColor;
            string Astr = Console.ReadLine();
            bool state = int.TryParse(Astr, out int j);
            if (!state)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(errorMessages);
                Console.ForegroundColor = backupColor;
                goto l1;
            }
            return j;
        }
    }
}
