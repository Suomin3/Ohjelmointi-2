
class Kauppa{
    private string nimi;

    public Kauppa(){
        nimi = "K-Market Kampus";
    }
    // overload 1

    public Kauppa(string _nimi){
        nimi = _nimi;
    }
    public string GiveName(){
        return nimi;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kauppa kauppa1 = new Kauppa();
        Console.WriteLine(kauppa1.GiveName());

        Kauppa kauppa2 = new Kauppa("Sale");
        Console.WriteLine(kauppa2.GiveName());
    }
}