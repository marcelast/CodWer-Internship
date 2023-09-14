
namespace MyApplication

{
    abstract class Animal 
    {
        public static int contor;
        public string nume { get; set; }
        public decimal greutate { get; private set; }
        public struct Dimensiune
        {
            public decimal lungime;
            public decimal latime;
            public decimal inaltime;
        }
        public Dimensiune dimensiune { get; private set; }
        public decimal viteza { get; private set; }
        protected List<Mancare> stomac = new List<Mancare>();
        public enum TipAnimal {Lup, Urs, Oaie, Veverita, Pisica, Vaca}

        //constructor
        public Animal(string nume, decimal greutate, Dimensiune dimensiune, decimal viteza)
        {
            this.nume = nume;
            this.greutate = greutate;
            this.dimensiune = dimensiune;
            this.viteza = viteza;
            contor++;
        }
         public void Mananca(Mancare m)
         {
            if (((this is Carnivor && m is Carne) ||
                (this is Erbivor && m is Planta) ||
                (this is Omnivor && (m is Carne || m is Planta))) && (m.greutate <= this.greutate / 8))
            {
                 stomac.Add(m);
                 Console.WriteLine($"{nume} mananca {m.GetType().Name.ToLower()}");
            }
            else
            {
                 Console.WriteLine($"{nume} nu poate manca {m.GetType().Name.ToLower()}!");
            }
         }
       
        public abstract double Energie();
        public void ALearga(decimal distanta)
        {
            decimal timp;
            timp = distanta / (viteza / (decimal)Energie());
            timp = Math.Round(timp, 2);
            Console.WriteLine($"{nume} parcurge {distanta} m in {timp} secunde");
        }
        public override string ToString()
        {
            Console.WriteLine("\n* * * * * * * * * * * * * * ");
            return $"Tip animal: {this.GetType().Name}\n" +
                $"Nume: {this.nume}\n" +
                $"Greutate: {this.greutate} kg\n" +
                $"Dimensiuni: {this.dimensiune.lungime} x {this.dimensiune.latime} x {this.dimensiune.inaltime}" +
                $"\nViteza: {this.viteza} m/s";
        }
    }
    class Carnivor: Animal
    {
        public Carnivor(string nume, decimal greutate, Dimensiune dimensiune, decimal viteza) 
            : base(nume, greutate, dimensiune, viteza) { }
    
        public override double Energie()
        {
            decimal greutateMancare = 0;
            decimal energieMancare = 0;
            foreach (Mancare m in stomac)
            {
                greutateMancare += m.greutate;
                energieMancare += m.energie;
            }
            decimal mediaGreutateMancare = greutateMancare / stomac.Count;
            double nivelEnergie = 0.2 - (double)(1.0 / 5.0) * (double)mediaGreutateMancare + (double)energieMancare;
            return nivelEnergie;
        }
    }
    class Erbivor: Animal
    {
    public Erbivor(string nume, decimal greutate, Dimensiune dimensiune, decimal viteza) 
        : base(nume, greutate, dimensiune, viteza) { }

    public override double Energie()
        {
            decimal greutateMancare = 0;
            decimal energieMancare = 0;
            foreach (var m in stomac)
            {
                greutateMancare += m.greutate;
                energieMancare += m.energie;
            }
            decimal mediaGreutateMancare = greutateMancare / stomac.Count;
            double nivelEnergie = 0.5 + (double)(1.0 / 3.0) * (double)mediaGreutateMancare + (double)energieMancare;
            return nivelEnergie;
        }

    }
    class Omnivor : Animal  
    {
    public Omnivor(string nume, decimal greutate, Dimensiune dimensiune, decimal viteza) 
        : base(nume, greutate, dimensiune, viteza) { }
    public override double Energie()
        {
            double mediaGreutateMancare = 0;
            double sumaEnergieMancare = 0;

            foreach (Mancare m in stomac)
            {
                mediaGreutateMancare += (double)m.greutate;
                sumaEnergieMancare += (double)m.energie;
            }

            if (stomac.Count > 0)
            {
                mediaGreutateMancare /= stomac.Count;

                double coefGreutate = 0;

                foreach (Mancare m in stomac)
                {
                    if (m is Planta)
                    {
                        coefGreutate += 0.5;
                    }
                    else if (m is Carne)
                    {
                        coefGreutate -= 0.5;
                    }
                }

                return 0.35 + coefGreutate * mediaGreutateMancare + sumaEnergieMancare;
            }
            else
            {
                return 0;
            }
        }
    }
    abstract class Mancare
    {
        public decimal greutate { get; set; }
        public decimal energie { get; set; }
        public Mancare(decimal greutate, decimal energie)
        {
            this.greutate = greutate;
            this.energie = energie;
        }
    }
    class Carne : Mancare
    {
        public Carne(decimal greutate, decimal energie) : base(greutate, energie) { }
    }
    class Planta: Mancare
    {
        public Planta(decimal greutate, decimal energie) : base(greutate, energie) { }
    }
}
