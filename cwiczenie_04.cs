using static Student;

Student[] tablicaStudentow = new Student[5];

for (int i = 0; i < tablicaStudentow.Length; i++)
{
    Console.WriteLine($"\nPodaj dane studenta nr {i + 1}: ");
    tablicaStudentow[i] = wypelnijTresciaStudent();
}
Console.Clear();

wypiszStudentow(tablicaStudentow);

Console.WriteLine(
    $"Średnia dla tych studentów to: {zwrocSredniaStudentow(tablicaStudentow)}"
    );

// wypisanie średniej
void wypiszStudentow(Student[] studenci)
{
    Console.WriteLine(
        $"{"Indeks",-10}" +
        $"{"Nazwisko",-10}" +
        $"{"Płeć",-10}" +
        $"{"Ocena",-10}");
    Console.WriteLine("+---------+---------+---------+---------+");
    foreach (Student student in studenci)
        Console.WriteLine(
        $"{student.NumerIndeksu,-10} " +
        $"{student.Nazwisko,-10} " +
        $"{(Plec)student.plec,-10} " +
        $"{student.Ocena,-10}");
    Console.WriteLine("+---------+---------+---------+---------+");
}


float zwrocSredniaStudentow(Student[] studenci)
{
    float wartosc = 0;
    foreach (Student st in studenci)
        wartosc += st.Ocena;

    return wartosc / studenci.Length;
}

void wypiszStudenta(ref Student tymczasowy)
{



    Console.WriteLine(
        $"{tymczasowy.NumerIndeksu,-10}" +
        $"{tymczasowy.Nazwisko,-10}" +
        $"{(Plec)tymczasowy.plec,-10}" +
        $"{tymczasowy.Ocena,-10}");
}


Student wypelnijTresciaStudent()
{

    Student tymczasowy = new Student();
    Console.WriteLine("Podaj Nazwisko: ");
    tymczasowy.Nazwisko = Console.ReadLine();

    Console.WriteLine("Podaj Nr Albumu: ");
    tymczasowy.NumerIndeksu = int.Parse(Console.ReadLine());

    Console.WriteLine("Podaj Płeć [ m | k ]: ");
    tymczasowy.plec = char.Parse(Console.ReadLine());

    Console.WriteLine("Podaj Ocenę: ");
    tymczasowy.Ocena = float.Parse(Console.ReadLine());
    if (tymczasowy.Ocena > 5)
        tymczasowy.Ocena = 5f;
    else if (tymczasowy.Ocena < 2)
        tymczasowy.Ocena = 2f;
    else
    {
        if (tymczasowy.Ocena >= 2 && tymczasowy.Ocena < 2.75)
            tymczasowy.Ocena = 2f;
        else if (tymczasowy.Ocena >= 2.75 && tymczasowy.Ocena < 3.25)
            tymczasowy.Ocena = 3f;
        else if (tymczasowy.Ocena >= 3.25 && tymczasowy.Ocena < 3.75)
            tymczasowy.Ocena = 3.5f;
        else if (tymczasowy.Ocena >= 3.75 && tymczasowy.Ocena < 4.25)
            tymczasowy.Ocena = 4f;
        else if (tymczasowy.Ocena >= 4.25 && tymczasowy.Ocena < 4.75)
            tymczasowy.Ocena = 4.5f;
        else
            tymczasowy.Ocena = 5f;
    }

    return tymczasowy;
}




struct Student
{
    public int NumerIndeksu { get; set; }
    public string Nazwisko { get; set; }
    public char plec { get; set; }
    public enum Plec
    {
        Mężczyzna = 'm',
        Kobieta = 'k'
    }
    public float Ocena { get; set; }
}
