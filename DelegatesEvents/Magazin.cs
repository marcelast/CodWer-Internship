
using System.Net.Http.Headers;

namespace DelegatesEvents
{
    public delegate void MyDelegate<T, T2>(T neww, T old, T2 obj);
    class Reducere
    {
        public string Nume;
        public DateTime Data;
        public Reducere (string nume, DateTime data)
        {
            Nume = nume;
            Data = data; 
        }
        public Action<Produs> Aplica => (produs) =>
        {
            produs.Pret.Valoarea -= produs.Pret.Valoarea * 0.1m;
        };

    }
      class Producator
    {
        public string Nume;
        public List<Reducere> Reduceri;

        public Producator(string nume, List<Reducere> reduceri)
        {
            Nume = nume;
            Reduceri = reduceri;
        }
    }
    class Produs
    {
        public Guid Id;
        public String Nume;
        private Pret pret;
        public Pret Pret
        {
            get { return pret; }
            set
            {
                decimal oldPrice = pret.Valoarea;
                pret = value;
                decimal newPrice = pret.Valoarea;
                OnPriceChanged(newPrice, oldPrice, this);
            }
        }
        private int stoc;
        public int Stoc
        {
            get { return stoc; }
            set
            {
                int oldStock = stoc;
                stoc = value;
                OnStockChanged(stoc, oldStock, this);
            }
        }
        // adaugam evenimente
        public event MyDelegate<int, Produs> StockChanged;
        protected virtual void OnStockChanged(int newStock, int oldStock, Produs obj)
        {
            StockChanged?.Invoke(newStock, oldStock, obj);
        }
       
        public event MyDelegate<decimal, Produs> PriceChanged;

        protected virtual void OnPriceChanged(decimal newPrice, decimal oldPrice, Produs obj)
        {
            PriceChanged?.Invoke(newPrice, oldPrice, obj);
        }

        public Producator Producator;

        public Produs(Guid id, string nume, Pret pret, int stoc, Producator producator)
        {
            Id = id;
            Nume = nume;
            this.pret = pret;
            this.stoc = stoc;
            Producator = producator;
        }
    
    }
 
    class Pret
    {
        public static Dictionary<Moneda, decimal> Curs = new Dictionary<Moneda, decimal>();
        public decimal Valoarea;
        public Moneda Moneda;

        public Pret(decimal valoarea, Moneda moneda)
        {
            Valoarea = valoarea;
            Moneda = moneda;
        }
    
        public decimal ValoareCurs(Moneda moneda)
        {
            if (Curs.ContainsKey(moneda))
            {
                Console.WriteLine("Cursul valutar pentru {0} este = {1}", moneda, Curs[moneda]);
                return Curs[moneda];
            }
            else
            {
                throw new ArgumentException("Nu s-a gasit cursul pentru aceasta moneda");
            }
        }
       
    }
    public enum Moneda
    {
        LEU, EUR, USD
    }
    class Catalog
    {
        public List<Produs> Produse;
        public DateTime? PerioadaStart;
        public DateTime? PerioadaStop;
        public List<Reducere> Reduceri;

        public Catalog(List<Produs> produs, DateTime? start, DateTime? stop, List<Reducere> reduceri) 
        {  
            Produse = produs; 
            PerioadaStart = start;  
            PerioadaStop = stop;
            Reduceri = reduceri;
        
        }
        public void AboneazaClient(Client client)
        {
            foreach (var produs in Produse)
            {
                if (client.ProduseFavorite.Contains(produs.Id))
                {
                    produs.PriceChanged += (newPrice, oldPrice, obj) =>
                    {
                        string mesaj = $"Pret-ul produsului {obj.Nume} s-a schimbat de la {oldPrice} {obj.Pret.Moneda} la {newPrice} {obj.Pret.Moneda}.";
                        client.Notifica(mesaj);
                    };
                }
            }
        }

    }
    class Client
    {
        private string[] inbox = new string[10];
        public string email;
        public Moneda moneda;
        public List<object> ProduseFavorite;


        public bool Notifica(string mesaj)
        {
            if(mesaj.Length > 60)
            {
                return false;
            }
            else if (inbox.Length > 10)
            {
                throw new OutOfMemoryException("Inbox-ul este plin.");
            }
            else
            {
                inbox.Append(mesaj);
                return true;
            }
        }
    }
}
