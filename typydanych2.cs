using System;

struct Student
{
    public string Imie;
    public string Nazwisko;
    public int NumerIndeksu;
    public string Kierunek;
}

struct Przedmiot
{
    public string Nazwa;
    public string Kod;
    public int ECTS;
    public string Wydzial;
}

struct NauczycielAkademicki
{
    public string Imie;
    public string Nazwisko;
    public string TytulNaukowy;
    public string Specjalizacja;
}

class Program
{
    static void Main()
    {
        Student student = new Student();
        student.Imie = "Jan";
        student.Nazwisko = "Kowalski";
        student.NumerIndeksu = 12345;
        student.Kierunek = "Informatyka";

        Przedmiot przedmiot = new Przedmiot();
        przedmiot.Nazwa = "Programowanie";
        przedmiot.Kod = "INF123";
        przedmiot.ECTS = 6;
        przedmiot.Wydzial = "Wydział Informatyki";

        NauczycielAkademicki nauczyciel = new NauczycielAkademicki();
        nauczyciel.Imie = "Anna";
        nauczyciel.Nazwisko = "Nowak";
        nauczyciel.TytulNaukowy = "dr";
        nauczyciel.Specjalizacja = "Sztuczna inteligencja";

        Console.WriteLine("Informacje o studencie:");
        Console.WriteLine("Imię: " + student.Imie);
        Console.WriteLine("Nazwisko: " + student.Nazwisko);
        Console.WriteLine("Numer indeksu: " + student.NumerIndeksu);
        Console.WriteLine("Kierunek: " + student.Kierunek);

        Console.WriteLine("\nInformacje o przedmiocie:");
        Console.WriteLine("Nazwa: " + przedmiot.Nazwa);
        Console.WriteLine("Kod: " + przedmiot.Kod);
        Console.WriteLine("ECTS: " + przedmiot.ECTS);
        Console.WriteLine("Wydział: " + przedmiot.Wydzial);

        Console.WriteLine("\nInformacje o nauczycielu akademickim:");
        Console.WriteLine("Imię: " + nauczyciel.Imie);
        Console.WriteLine("Nazwisko: " + nauczyciel.Nazwisko);
        Console.WriteLine("Tytuł naukowy: " + nauczyciel.TytulNaukowy);
        Console.WriteLine("Specjalizacja: " + nauczyciel.Specjalizacja);

        Console.ReadLine();
    }
}

