Student andrzej = new Student();
andrzej.CzyDebil = true;
Console.WriteLine(andrzej.CzyDebil);

struct Student
{
    public int NumerIndeksu { get; set; }
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public Boolean CzyDebil { get; set; }
}

struct Przedmiot
{

    public int LiczbaGodzin { get; set; }
    public int LiczbaECTS { get; set; }
    public string Nazwa { get; set; }

}

struct NauczycielAkademicki
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public enum TytulNaukowy
    {
        Magister,
        Doktor,
        Doktor_Hab,
        Profesor
    }
}