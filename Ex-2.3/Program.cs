using System;

namespace Ex_2._3
{
    class Program
    {

        delegate bool MyDelegate(int x, int y, int z);
        static void Main(string[] args)
        {
            CoffeeMachine coffee= new CoffeeMachine();
            MyDelegate check = coffee.VerificaResurse;
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Selectati o optiune: ");
                Console.WriteLine("1. Prepara espresso");
                Console.WriteLine("2. Prepara cappuccino");
                Console.WriteLine("3. Curata aparat");
                Console.WriteLine("4. Verifica nivelul de resurse");
                Console.WriteLine("0. Exit");

                if(coffee.VerificaResurse())
                {
                    Console.Clear();
                    Console.WriteLine("Adauga resurse:");
                    Console.WriteLine("Nivelul de apa este = {0} -> Tasteaza 5 pentru a adauga apa", coffee.nivelApa);
                    Console.WriteLine("Nivelul de lapte este = {0} -> Tasteaza 6 pentru a adauga lapte", coffee.nivelLapte);
                    Console.WriteLine("Nivelul de cafea este = {0} -> Tasteaza 7 pentru a adauga cafea", coffee.nivelCafea);
                }
                if(coffee.nivelZatCafea == 5)
                {
                    Console.Clear();
                    Console.WriteLine("E nevoie sa curatati aparatul pentru a continua");
                    Console.WriteLine("Tasteaza 3 pentru a curati aparatul.");
                }
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        exit = true;
                        break;
                    case 1:
                        if (check(1, 1, 0))
                        {
                            coffee.PreparaEspresso();
                            Console.WriteLine("Espresso preparat!");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Resurse insuficiente pentru a prepara espresso.\n Adauga Resursele necesare.");
                        }
                        break;
                    case 2:
                        if (check(1, 1, 1))
                        {
                            coffee.PreparaCappuccino();
                            Console.WriteLine("Cappuccino preparat!");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Resurse insuficiente pentru a prepara cappuccino.\n Adauga Resursele necesare.");
                        }
                        break;
                    case 3:
                        coffee.CurataAparat();
                        Console.Clear();
                        Console.WriteLine("Aparatul de cafea a fost curatat.");
                        break;
                    case 4:
                        coffee.AfiseazaResurse();
                        break;
                    case 5: Console.WriteLine("Introdu nivelul de apa:");
                        int apa = Convert.ToInt32(Console.ReadLine());
                        coffee.nivelApa = apa;
                        break;
                    case 6:
                        Console.WriteLine("Introdu nivelul de lapte:");
                        int lapte = Convert.ToInt32(Console.ReadLine());
                        coffee.nivelLapte = lapte;
                        break;
                    case 7:
                        Console.WriteLine("Introdu nivelul de cafea:");
                        int cafea = Convert.ToInt32(Console.ReadLine());
                        coffee.nivelCafea = cafea;
                        break;
                    default:
                        Console.WriteLine("Optiune invalida");
                        break;

                }
                Console.WriteLine("Apasati o tasta pentru a continua...");
                Console.ReadKey();
            }
        }
    }
}