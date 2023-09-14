namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int nr;
            do
            {
                Console.WriteLine("Enter a number that has at least 3 digits: ");
                nr = Convert.ToInt32(Console.ReadLine());
                if (nr < 100)
                {
                    Console.WriteLine("The number has less than 3 digits! Enter another one! ");
                }
            } while (nr < 100);
            Console.WriteLine("You have entered the number {0}.", nr);
            int oglinda = 0, restul, i = 0;
            int temp = nr;
            while (temp > 0)
            {
                restul = temp % 10;
                oglinda = (oglinda * 10) + restul;
                temp = temp / 10;
                i++;
            }
            Console.WriteLine("Oglinda numarului intrdus este {0}", oglinda);
            Console.WriteLine("Numarul {0} este format din {1} cifre.", oglinda, i);
            double sqrt = Math.Sqrt(oglinda);
            if (sqrt % 1 == 0)
            {
                Console.WriteLine("Numarul {0} este patrat perfect!", oglinda);
            }
            else { Console.WriteLine("Numarul {0} NU este patrat perfect!", oglinda); }
        }

    }
}
