namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            string[] arrNames = names.Split(" ");
            Console.WriteLine("The Names: ");
            foreach (string el in arrNames)
            {
                Console.WriteLine(Array.IndexOf(arrNames, el) + 1 + ". " + el);
            }
            Dictionary<char, int> caractere = new Dictionary<char, int>();
            foreach (string el in arrNames)
            {
                foreach (char ch in el)
                {
                    char ch2 = Char.ToLower(ch);
                    if (caractere.ContainsKey(ch2))
                    {
                        caractere[ch2]++;
                    }
                    else
                    {
                        caractere.Add(ch2, 1);
                    }
                }
            }
            Console.WriteLine("The characters ");
            foreach (KeyValuePair<char, int> el in caractere)
            {
                Console.WriteLine("{0} : {1}", el.Key, el.Value);
            }
        }
    }
}
