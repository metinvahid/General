using System.Formats.Tar;
using System.Runtime.InteropServices;

namespace CharString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, World!";

            //for (int i = 0; i < text.Length; i++)
            //{
            //    // Console.WriteLine(text[i]);vergulnen
            //    if (text[i] == ',')
            //    {

            //        break;
            //    }
            //    Console.WriteLine(text[i]);
            //}

            Console.WriteLine("THE NEW");

            //for (int i = 0; i < 10; i++)
            //    {
            //    //Console.WriteLine(i);
            //    // Console.WriteLine(i);continuedirse ==5 yazsam 5 verir \\ returndirse break kimidir amma kod islemir sonra \\breakdirse evvelde 5 daxil sonradirsa yox
            //    if (i==5)
            //    {
            //        continue;

            //    }
            //    Console.WriteLine(i);
            //}

            //evvel
           text= text.Insert(0, "3");
            Console.WriteLine(text);
            //axir
            text += "X";
            Console.WriteLine(text);


            char[] symbols = text.ToCharArray();
            //Console.WriteLine(text[0]);
             Console.WriteLine(symbols);

            Array.Reverse(symbols);
            string reverseText = "";
               reverseText=string.Join(" ", symbols);
            Console.WriteLine(symbols);




            //string reversetext = "";
            //for (int i = text.Length-1; i>=0 ; i--) 
            //{
            //   reversetext = reversetext + text[i];
            //}


        }
    }
}
