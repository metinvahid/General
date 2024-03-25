namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x=10 ;
            //Console.WriteLine($"x1 {x}");
            Intstatic( out x);
            Console.WriteLine($"x2 {x}");
        }

        
       

        static int Intstatic(  out int value)
        {
            value=20;
           
            Console.WriteLine($"value1 {value}");
            value++;
            Console.WriteLine($"value2 {value}");
            return 0;
        }

       




    }
}
