



using System;

Przedmiot[] skrzynka = new Przedmiot[5];
wypelnijDaneGotowe(ref skrzynka[0], "Force of Nature", 400, 2900, klasaRzadkosci.epicki, typPrzedmiotu.zbroja);
wypelnijDaneGotowe(ref skrzynka[1], "B. F. Sword", 200, 1300, klasaRzadkosci.rzadki, typPrzedmiotu.broń);
wypelnijDaneGotowe(ref skrzynka[2], "Ninja Tabi", 50, 1100, klasaRzadkosci.unikalny, typPrzedmiotu.buty);
wypelnijDaneGotowe(ref skrzynka[3], "Doran's Shield", 240, 450, klasaRzadkosci.powszechny, typPrzedmiotu.tarcza);
wypelnijDaneGotowe(ref skrzynka[4], "Duży miecz", 240, 450, klasaRzadkosci.powszechny, typPrzedmiotu.zbroja);


Przedmiot wyciagnietyZeSkrzyni = wylosujZeSkrzyni(ref skrzynka);

wyswietlPrzedmiot(wyciagnietyZeSkrzyni);

void wyswietlPrzedmiot(Przedmiot p)
{
    Console.WriteLine(
        $"{"Nazwa:",-10} {p.nazwa,-10}\n" +
        $"{"Rzadkość:",-10} {p.rzadkosc,-10}\n" +
        $"{"Rodzaj:",-10} {p.typPrzedmiotu,-10}\n" +
        $"{"Wartość:",-10} {p.wartoscWZlocie,-10}\n" +
        $"{"Waga:",-10} {p.waga,-10}\n");
}


void wypelnijDaneGotowe(
    ref Przedmiot a,
    string nazwa,
    int waga,
    int wartoscWZlocie,
    klasaRzadkosci rzadkosc,
    typPrzedmiotu typPrzedmiotu)
{
    a.nazwa = nazwa;
    a.waga = waga;
    a.wartoscWZlocie = wartoscWZlocie;
    a.rzadkosc = rzadkosc;
    a.typPrzedmiotu = typPrzedmiotu;
}

Przedmiot wypelnijDane()
{
    Przedmiot placeholder = new Przedmiot(); ;
    Console.WriteLine("Podaj nazwę: ");
    placeholder.nazwa = Console.ReadLine().Trim();
    Console.WriteLine("\nPodaj wartość w sztukach złota: ");
    placeholder.wartoscWZlocie = int.Parse(Console.ReadLine());
    Console.WriteLine(
        "\nPodaj rzadkość: \n" +
        "powszechy = 1\n rzadki = 2\nunikalny = 3\nepicki = 4");
    int wartosc = int.Parse(Console.ReadLine());
    switch (wartosc)
    {
        case 1: placeholder.rzadkosc = klasaRzadkosci.powszechny; break;
        case 2: placeholder.rzadkosc = klasaRzadkosci.rzadki; break;
        case 3: placeholder.rzadkosc = klasaRzadkosci.unikalny; break;
        case 4: placeholder.rzadkosc = klasaRzadkosci.epicki; break;
    }
    Console.WriteLine(
        "Podaj typ przedmiotu: \n" +
        "broń = 1\nzbroja = 2\namulet = 3\npierścień = 4\nhełm = 5\ntarcza = 6\nbuty = 7\n");
    wartosc = int.Parse(Console.ReadLine());
    switch (wartosc)
    {
        case 1: placeholder.typPrzedmiotu = typPrzedmiotu.broń; break;
        case 2: placeholder.typPrzedmiotu = typPrzedmiotu.zbroja; break;
        case 3: placeholder.typPrzedmiotu = typPrzedmiotu.amulet; break;
        case 4: placeholder.typPrzedmiotu = typPrzedmiotu.pierścień; break;
        case 5: placeholder.typPrzedmiotu = typPrzedmiotu.hełm; break;
        case 6: placeholder.typPrzedmiotu = typPrzedmiotu.tarcza; break;
        case 7: placeholder.typPrzedmiotu = typPrzedmiotu.buty; break;

    }
    return placeholder;
}

Przedmiot wylosujPosrodTejSamejRzadkosci(ref Przedmiot[] tablica, klasaRzadkosci rzadkoscPrzedmiotu)
{
    //placeholdery
    Random random = new Random();

    //wybor przedmiotow
    var listaPrzedmiotow = from p in tablica
                           where p.rzadkosc == rzadkoscPrzedmiotu
                           select p;

    //losowanie
    int index = random.Next(listaPrzedmiotow.Count());

    //przekształcenie
    List<Przedmiot> wylosowane = listaPrzedmiotow.ToList();

    return wylosowane[index];
}


Przedmiot wylosujZeSkrzyni(ref Przedmiot[] zawartoscSkrzyni)
{
    //placeholders
    Przedmiot wylosowany = new Przedmiot();

    //losowanie
    Random random = new Random();
    int wynik = random.Next(1, 100);


    //powszechny 
    if (Enumerable.Range(1, 50).Contains(wynik))
    {
        wylosowany = wylosujPosrodTejSamejRzadkosci(
                            ref zawartoscSkrzyni,
                            klasaRzadkosci.powszechny);
    }
    //rzadki
    else if (Enumerable.Range(51, 75).Contains(wynik))
    {
        wylosowany = wylosujPosrodTejSamejRzadkosci(
                    ref zawartoscSkrzyni,
                    klasaRzadkosci.rzadki);
    }
    //unikalny
    else if (Enumerable.Range(76, 90).Contains(wynik))
    {
        wylosowany = wylosujPosrodTejSamejRzadkosci(
                    ref zawartoscSkrzyni,
                    klasaRzadkosci.unikalny);
    }
    //epicki
    else if (Enumerable.Range(91, 100).Contains(wynik))
    {
        wylosowany = wylosujPosrodTejSamejRzadkosci(
                    ref zawartoscSkrzyni,
                    klasaRzadkosci.epicki);
    }
    return wylosowany;
}


enum klasaRzadkosci
{
    powszechny = 1,
    rzadki,
    unikalny,
    epicki
}

enum typPrzedmiotu
{
    broń = 1,
    zbroja,
    amulet,
    pierścień,
    hełm,
    tarcza,
    buty
}
struct Przedmiot
{
    public int waga { get; set; }
    public int wartoscWZlocie { get; set; }
    public klasaRzadkosci rzadkosc;
    public typPrzedmiotu typPrzedmiotu;
    public string nazwa { get; set; }
}