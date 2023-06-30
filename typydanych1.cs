using System;

enum DniTygodnia
{
    Poniedzialek,
    Wtorek,
    Sroda,
    Czwartek,
    Piatek,
    Sobota,
    Niedziela
}

enum EtapyPrania
{
    WstepnePlukanie,
    Pranie,
    Plukanie,
    Suszenie
}

enum Posilki
{
    Sniadanie = 1,
    DrugieSniadanie,
    Obiad,
    Podwieczorek,
    Kolacja
}

[Flags]
enum BierkiSzachowe
{
    Brak = 0,
    Pionek = 1,
    Wieza = 2,
    Skoczek = 4,
    Goniec = 8,
    Hetman = 16,
    Krol = 32
}

class Program
{
    static void Main(string[] args)
    {
        DniTygodnia dzien = DniTygodnia.Poniedzialek;
        Console.WriteLine("Dzień tygodnia: " + dzien);

        EtapyPrania etap = EtapyPrania.Pranie;
        Console.WriteLine("Etap prania: " + etap);

        Posilki posilek = Posilki.DrugieSniadanie;
        Console.WriteLine("Posiłek: " + posilek);

        BierkiSzachowe bierki = BierkiSzachowe.Pionek | BierkiSzachowe.Wieza | BierkiSzachowe.Skoczek;
        Console.WriteLine("Bierki szachowe: " + bierki);
    }
}
