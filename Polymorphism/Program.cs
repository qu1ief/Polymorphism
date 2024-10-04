namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2
            Square square = new(16);
            Rectangular rectangular = new Rectangular(3, 5);

            Console.WriteLine("1. Square\r\n2. Rectangular\r\n0. Quit");

            string input = Console.ReadLine();

            if (input == "1")
            {
                square.CalcArea();
            }
            else if (input == "2")
            {
                rectangular.CalcArea();
            }
            else if (input == "0")
            {
                return;
            }
            else
            {
                Console.WriteLine("Duzgun deyer daxil edin");
            }


            //3


        }
    }
}
