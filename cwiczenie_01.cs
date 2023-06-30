foreach (dniTygodnia day in Enum.GetValues(typeof(dniTygodnia)))
{
    Console.WriteLine(day);
}


foreach (bierkiSzachowe b in Enum.GetValues(typeof(bierkiSzachowe)))
{
    Console.WriteLine((int) b);
}

enum dniTygodnia
{
    Niedziela = 1,
    Poniedziałek,
    Wtorek,
    Środa,
    Czwartek,
    Piątek,
    Sobota
}

enum etapyPrania
{
    Moczenie,
    Wirowanie,
    Suszenie
}

enum posilkiWCiaguDnia
{
    Sniadanie = 1,
    Obiad = 3,
    Kolacja = 5
}

enum bierkiSzachowe
{
    Pion = 1,
    Skoczek = 3,
    Goniec = 3,
    Wieża = 5,
    Hetman = 9
}


