namespace DelegatesEvents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a. Lista de producatori
            List<Producator> producatori = new List<Producator>();

            Producator prod1 = new Producator("Apple", new List<Reducere>
           {
               new Reducere ("reducere de vara", new DateTime(2023, 7, 10)),
               new Reducere ("reducere de tomana", new DateTime(2023, 9, 20))
           });
            Producator prod2 = new Producator("Samsung", new List<Reducere>
           {
               new Reducere ("reducere de vara", new DateTime(2023, 8, 10)),
               new Reducere ("reducere de tomana", new DateTime(2023, 10, 20))
           });
            Producator prod3 = new Producator("Nokia", new List<Reducere>
           {
               new Reducere ("reducere de vara", new DateTime(2023, 6, 10)),
               new Reducere ("reducere de tomana", new DateTime(2023, 11, 1))
           });
            producatori.Add(prod1);
            producatori.Add(prod2);
            producatori.Add(prod3);

            // b. instantiere catalog
            List<Produs> produse = new List<Produs>();
            Produs produs1 = new Produs(Guid.NewGuid(),"Iphone 11", new Pret(15000, Moneda.LEU), 20, prod1);
            Produs produs2 = new Produs(Guid.NewGuid(), "Samsung Galaxy 5", new Pret(10000, Moneda.LEU), 10, prod2);
            Produs produs3 = new Produs(Guid.NewGuid(), "Nokia 6300", new Pret(3000, Moneda.LEU), 0, prod3);
            produse.Add(produs1);
            produse.Add(produs2);
            produse.Add(produs3);

            Catalog catalog1 = new Catalog(produse, DateTime.Now.AddDays(5), null, new List<Reducere>
           {
               new Reducere ("reducere de vara", new DateTime(2023, 7, 10)),
               new Reducere ("reducere de tomana", new DateTime(2023, 9, 20))
           });

            // c. stabilire curs valutar
            Pret.Curs[Moneda.LEU] = 4.05m;
            Pret.Curs[Moneda.EUR] = 19.99m;
            Pret.Curs[Moneda.USD] = 18.35m;

            // d. Instantiere lista clienti

            List<Client> clienti = new List<Client>
    {
        new Client
        {
            email = "marcela@email.com",
            moneda = Moneda.LEU,
            ProduseFavorite = new List<object> { produs1.Id} 
        },
        new Client
        {
            email = "claudiu@email.com",
            moneda = Moneda.EUR,
            ProduseFavorite = new List<object> { produs1.Id, produs2.Id}
        },
        new Client
        {
            email = "marius@email.com",
            moneda = Moneda.USD,
            ProduseFavorite = new List<object> { produs1.Id, produs3.Id, produs2.Id}
        }
    };
            //verificare evenimente
            produs1.StockChanged += NotifyStock;
            produs1.PriceChanged += NotifyPrice;
           // produs1.Stoc = 25;
           // produs1.Pret = new Pret(20000, Moneda.LEU);

            //abonarea la catlog
            Client client1 = new Client
            {
                email = "andrei@email.com",
                moneda = Moneda.USD,
                ProduseFavorite = new List<object> { produs1.Id, produs3.Id, produs2.Id }
            };
            catalog1.AboneazaClient(client1);




        }
        public static void NotifyPrice(decimal newp, decimal oldp, Produs obj)
        {
            Console.WriteLine($"Pretul pentru produsul: {obj.Nume}");
            Console.WriteLine($"Pretul nou este {newp} \nPretul vechi este {oldp}");
            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
            Console.ReadLine();
        }
        public static void NotifyStock(int news, int olds, Produs obj)
        {
            Console.WriteLine($"Stocul pentru produsul: {obj.Nume}");
            Console.WriteLine($"Stocul noue este {news} \nStocul vechi este {olds}");
            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
            Console.ReadLine();
        }
    }
}