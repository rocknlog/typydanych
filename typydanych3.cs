using System;

enum RzadkoscPrzedmiotu
{
    Powszechny,
    Rzadki,
    Unikalny,
    Epicki
}

enum TypPrzedmiotu
{
    Bron,
    Zbroja,
    Amulet,
    Pierscien,
    Helm,
    Tarcza,
    Buty
}

struct Przedmiot
{
    public double Waga;
    public int Wartosc;
    public RzadkoscPrzedmiotu Rzadkosc;
    public TypPrzedmiotu Typ;
    public string NazwaWlasna;

    public Przedmiot(double waga, int wartosc, RzadkoscPrzedmiotu rzadkosc, TypPrzedmiotu typ, string nazwaWlasna)
    {
        Waga = waga;
        Wartosc = wartosc;
        Rzadkosc = rzadkosc;
        Typ = typ;
        NazwaWlasna = nazwaWlasna;
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine("Przedmiot: " + NazwaWlasna);
        Console.WriteLine("Typ: " + Typ);
        Console.WriteLine("Rzadkosc: " + Rzadkosc);
        Console.WriteLine("Waga: " + Waga);
        Console.WriteLine("Wartosc: " + Wartosc);
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Przedmiot[] przedmioty = new Przedmiot[5];

        przedmioty[0] = new Przedmiot(1.5, 10, RzadkoscPrzedmiotu.Powszechny, TypPrzedmiotu.Bron, "Miecz");
        przedmioty[1] = new Przedmiot(2.0, 20, RzadkoscPrzedmiotu.Rzadki, TypPrzedmiotu.Zbroja, "Pancerz");
        przedmioty[2] = new Przedmiot(0.5, 30, RzadkoscPrzedmiotu.Unikalny, TypPrzedmiotu.Amulet, "Amulet Mocy");
        przedmioty[3] = new Przedmiot(0.2, 40, RzadkoscPrzedmiotu.Epicki, TypPrzedmiotu.Pierscien, "Pierscien Wladzy");
        przedmioty[4] = new Przedmiot(1.0, 50, RzadkoscPrzedmiotu.Powszechny, TypPrzedmiotu.Helm, "Helm Rycerski");

        Console.WriteLine("Lista przedmiotów:");
        foreach (Przedmiot przedmiot in przedmioty)
        {
            przedmiot.WyswietlInformacje();
        }

        Przedmiot losowyPrzedmiot = WylosujPrzedmiot(przedmioty);
        Console.WriteLine("Wylosowany przedmiot:");
        losowyPrzedmiot.WyswietlInformacje();

        Console.ReadLine();
    }

    static Przedmiot WylosujPrzedmiot(Przedmiot[] przedmioty)
    {
        Random random = new Random();
        int indeks = random.Next(0, przedmioty.Length);

        return przedmioty[indeks];
    }
}
