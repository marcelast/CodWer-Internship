namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introdu o lista de nr separate prin spatiu: ");
            string input = Console.ReadLine();
            string[] arr_string = input.Split(' ');
            double[] arr_nr = Array.ConvertAll(arr_string, double.Parse);

            Console.WriteLine("Numerele introduse sunt:");
            foreach (double numar in arr_nr)
            {
                Console.Write(numar + " ");
            }
            Console.WriteLine("\nNumerele cu zecimale:");
            foreach (double numar in arr_nr)
            {
                if (numar % 1 != 0)
                {
                    Console.Write(numar + " ");
                }
            }

            double min = arr_nr[0];
            for (int i = 0; i < arr_nr.Length; i++)
            {

                if (arr_nr[i] < min)
                {
                    min = arr_nr[i];
                }
            }
            Console.WriteLine("\nCel mai mic nr: " + min);
        }
    }
}
