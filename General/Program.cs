using System.Runtime.InteropServices;
using System.Text;

namespace General
{
    internal class Program
    {
        static void Main(string[] args)
        {

        //Console.WriteLine($"Salam daxil olanlar ");

        //foreach (var element in args ) 
        //{
        //    Console.WriteLine( element );

        //}

        //Console.WriteLine($"Salam {args[0]} {args[1]}");
        


          





            Console.OutputEncoding = Encoding.Unicode;
            string[] students = {
                "Metin",
                "Vahid",
                "Yaqub",
                "Ehmed",
                "Anar"
                   
            };

            Random r = new Random();
            int index ;
            int[] used = new int[0];

            do
            {
                if (used.Length == students.Length)
                {
                    var copyOfDefault = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Yeniden");
                    Console.ForegroundColor= copyOfDefault;
                    Array.Resize(ref used, 0);
                }
                l4:
                index = r.Next(0, students.Length);
                if (Array.IndexOf(used, index) != -1)
                {
                    goto l4;
                }
                int currentIndex = used.Length;

                Array.Resize(ref used, currentIndex+1);
                used[currentIndex] = index;
                Console.WriteLine(students[index]);
            } while (Console.ReadKey().Key == ConsoleKey.Enter);

            Console.WriteLine("The End");


           
        }

    }
}
