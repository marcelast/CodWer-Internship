using System;
using static MyApplication.Animal;

namespace MyApplication
{

    class Program
    {
        public static Animal CreeazaAnimal(TipAnimal tip, string nume, decimal greutate, Dimensiune dimensiune, decimal viteza)
            {
            switch (tip)
            {
                case TipAnimal.Lup: 
                    return new Carnivor(nume, greutate, dimensiune, viteza);
                case TipAnimal.Urs:
                    return new Omnivor(nume, greutate, dimensiune, viteza);
                case TipAnimal.Oaie: 
                    return new Carnivor(nume, greutate, dimensiune, viteza);
                case TipAnimal.Veverita: 
                    return new Omnivor(nume, greutate, dimensiune, viteza);
                case TipAnimal.Pisica: 
                    return new Carnivor(nume, greutate, dimensiune, viteza);
                case TipAnimal.Vaca:
                    return new Erbivor(nume, greutate, dimensiune, viteza);
                default:
                    throw new ArgumentException("Tipul de animal dat nu este valid.");

            }
            }
        public static void Main(string[] args)
        {
            Carnivor lup = new Carnivor("Lupul", 30.5m, new Dimensiune { lungime = 0.7m, latime = 0.4m, inaltime = 0.8m }, 20m);
            Erbivor oaie = new Erbivor("Oaia", 15.2m, new Dimensiune { lungime = 0.9m, latime = 0.5m, inaltime = 0.6m }, 15m);
            Omnivor urs = new Omnivor("Ursul", 150m, new Dimensiune { lungime = 2m, latime = 1.2m, inaltime = 1.8m }, 10m);
            Planta salata = new Planta(0.5m, 0.01m);
            Carne sunca = new Carne(1, 0.05m);

            //Hranim animalele
            lup.Mananca(sunca);
            lup.Mananca(sunca);
            oaie.Mananca(salata);
            oaie.Mananca(salata); 
            oaie.Mananca(salata);
            urs.Mananca(sunca);
            urs.Mananca(salata);
            urs.Mananca(salata);

            //Punem animalele sa alerge
            lup.ALearga(200);
            oaie.ALearga(200);
            urs.ALearga(200);

            //nr de animale create
            Console.WriteLine($"Numar total animale instantiate: {Animal.contor}");

            //verificare dupa tipul de mancare
            lup.Mananca(salata);

            //afisare obiect prin functia suprascrisa ToString()
            Erbivor capra = new Erbivor("Capra", 15m, new Dimensiune { lungime = 0.6m, latime = 0.5m, inaltime = 0.6m }, 10m);
            Console.WriteLine(capra);

            //Creare animal prin fucntia statica CreeazaAnimal(...)
            Animal vaca = CreeazaAnimal(TipAnimal.Vaca, "Vaca", 120m, new Dimensiune { inaltime = 1.50m, latime = 0.9m, lungime = 0.9m }, 5m);
            Console.WriteLine(vaca);

            List<Animal> animaleList = new List<Animal>();
            Random rand = new Random();
            for (int i = 1; i<=10; i++)
            {
                int nrAnimal = rand.Next(6);
                Animal animal = CreeazaAnimal((TipAnimal)nrAnimal, "Animal "+i,
                                                rand.Next(1, 200),
                                                new Dimensiune
                                                {
                                                    lungime = rand.Next(1, 11) / 10m,
                                                    latime = rand.Next(1, 11) / 10m,
                                                    inaltime = rand.Next(1, 11) / 10m
                                                },
                                                rand.Next(1, 21));
                animaleList.Add(animal);

            }
          
            int manancaCarne = 0, manancaPlante = 0;
            foreach(Animal a in animaleList)
            {
                if(a is Carnivor)
                {
                    manancaCarne++;
                    a.Mananca(sunca);
                }
                else if(a is Erbivor)
                {
                    manancaPlante++;
                    a.Mananca(salata);
                }
                else
                {
                    manancaPlante++;
                    manancaCarne++;
                    a.Mananca(sunca);
                    a.Mananca(salata);
                }
               
            }
            Console.WriteLine("\n\nStatistici");
            Console.WriteLine($"{animaleList.Count()} animale mananca Mancare.");
            Console.WriteLine($"{manancaCarne} animale mananca Carne.");
            Console.WriteLine($"{manancaPlante} animale mananca Plante.");
        }
    }
}