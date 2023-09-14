class CoffeeMachine
{
    public int nivelCafea = 2;
    public int nivelApa = 2;
    public int nivelZatCafea = 3;
    public int nivelLapte = 2;
    public bool cup = true;

    public bool VerificaResurse(int cafeaNecesara, int apaNecesara, int lapteNecesar)
    {
        return nivelCafea >= cafeaNecesara && nivelApa >= apaNecesara && nivelLapte >= lapteNecesar;
    }
    public bool VerificaResurse()
    {
        return nivelCafea <= 0 || nivelApa <= 0 || nivelLapte <= 0;
    }

    public void PreparaEspresso()
    {
        nivelCafea -= 1;
        nivelApa -= 1;
        nivelZatCafea += 1;
    }

    public void PreparaCappuccino()
    {
        nivelCafea -= 1;
        nivelApa -= 1;
        nivelZatCafea += 1;
        nivelLapte -= 1;
    }

    public void CurataAparat()
    {
        nivelZatCafea = 0;
    }

    public void AfiseazaResurse()
    {
        Console.WriteLine("- nivelul de cafea: " + nivelCafea);
        Console.WriteLine("- nivelul de apa: " + nivelApa);
        Console.WriteLine("- nivelul de lapte: " + nivelLapte);
        Console.WriteLine("- nivelul de zat de cafea: " + nivelZatCafea);
    }
}
