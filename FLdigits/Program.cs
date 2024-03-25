namespace FLdigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 765432155;
            int fd, ld;
            fd = FirstAndLastDigit(x, out ld);
            Console.WriteLine($"fd:{fd} ld:{ld}");




        }

        static int FirstAndLastDigit(int value , out int lastDigit)
        {
            lastDigit = value % 10;
            for (; value > 10; value /= 10)
            {

            }

            //veya 
            lastDigit = value % 10;
            while(value > 10)
            {
                value/=10;
            }
            return value;
        }
    }
}
