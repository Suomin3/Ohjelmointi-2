
class Koira {
    public string nimi;
    public bool murisee = false;
    public string Juo (){
        return "lurps lurps";
    }
    public string Syo (){
        return "nom nom";
    }
    public string Haukkuu (){
        return "vuh";
    }
}
class Koiranpentu : Koira{
    public bool pieni;
}
class Susi : Koira{
    bool peloton;

    public Susi(bool _peloton){
        peloton = _peloton;
    Console.WriteLine("Susi on peloton = " + peloton);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Koira koira1 = new Koira();
        koira1.nimi = "Musti";
        Console.WriteLine($"{koira1.nimi} syö " + koira1.Syo());

        Koiranpentu pentu1 = new Koiranpentu();
        pentu1.nimi = "Regina";
        pentu1.pieni = false;
        Console.WriteLine($"{pentu1.nimi} juo " + pentu1.Juo());

        Susi susi1 = new Susi(true);
        susi1.nimi = "Jyrki";
        // susi1.peloton = true;
        Console.WriteLine($"{susi1.nimi} haukkuu " + susi1.Haukkuu());
    }
}