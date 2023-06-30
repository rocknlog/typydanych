using System;

enum Plec
{
    Mezczyzna,
    Kobieta
}

struct Student
{
    public string Nazwisko;
    public int NrAlbumu;
    public double Ocena;
    public Plec Plec;

    public Student(string nazwisko, int nrAlbumu, double ocena, Plec plec)
    {
        Nazwisko = nazwisko;
        NrAlbumu = nrAlbumu;
        Ocena = Math.Max(2.0, Math.Min(5.0, ocena)); // Ograniczenie oceny do zakresu 2.0 - 5.0
        Plec = plec;
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine($"Student: {Nazwisko}, Nr Albumu: {NrAlbumu}, Ocena: {Ocena}, Płeć: {Plec}");
    }
}

class Program
{
    static void Main()
    {
        Student[] grupaStudentow = new Student[5];

        grupaStudentow[0] = new Student("Kowalski", 12345, 4.5, Plec.Mezczyzna);
        grupaStudentow[1] = new Student("Nowak", 23456, 3.7, Plec.Kobieta);
        grupaStudentow[2] = new Student("Wisniewski", 34567, 5.5, Plec.Mezczyzna); // Ocena zostanie ograniczona do 5.0
        grupaStudentow[3] = new Student("Wojcik", 45678, 1.8, Plec.Mezczyzna); // Ocena zostanie ograniczona do 2.0
        grupaStudentow[4] = new Student("Kaminska", 56789, 4.2, Plec.Kobieta);

        Console.WriteLine("Grupa studentów:");
        foreach (Student student in grupaStudentow)
        {
            student.WyswietlInformacje();
        }

        double sredniaOcen = ObliczSredniaOcen(grupaStudentow);
        Console.WriteLine($"Średnia ocen w grupie: {sredniaOcen}");

        Console.ReadLine();
    }

    static double ObliczSredniaOcen(Student[] grupaStudentow)
    {
        double sumaOcen = 0;
        foreach (Student student in grupaStudentow)
        {
            sumaOcen += student.Ocena;
        }

        return sumaOcen / grupaStudentow.Length;
    }
}
