using System.Globalization;
using System.Text;

namespace ToUpper_ToLower_CultureInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            var ci = new CultureInfo("az");

            string text = " instagram Əmək və əhalinin sosial müdafiə nazirliyi";

            //text = text.Replace("i","y");
            text = text.Replace("ə","i",StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine(text);

            int index = text.IndexOf("sosial");
            Console.WriteLine(index);

            char[] searchedsym = new[] { 'a', 'b', 'c' };
            string text3 = "demotcs abc";
            Console.WriteLine(text.IndexOfAny(searchedsym));
            




        }

        void ToUpperToLower()
        {
            Console.OutputEncoding = Encoding.Unicode;
            var ci = new CultureInfo("az");
            // Thread.CurrentThread.CurrentCulture = ci;
            string text = " instagram Əmək və əhalinin sosial müdafiə nazirliyi";
            text = text.ToUpper(ci);
            Console.WriteLine(text);

            text = text.ToLower(ci);
            Console.WriteLine(text);

            text = ci.TextInfo.ToTitleCase(text);
            Console.WriteLine(text);

        }
    }

}
