namespace T5_koodit;

class Program{
    static void Main(string[] args){

        Peruspertti peruspertti1 = new Peruspertti();
        peruspertti1.LuoKayttaja1("Peruspertti","salasana1");

        Admin admin1 = new Admin();
        admin1.LuoKayttaja2("Admin","salasana2");

        Console.Write("Anna käyttäjätunnus: ");
        string kt = Console.ReadLine();
        Console.Write("Anna salasana: ");
        string ss = Console.ReadLine();

        if(kt == "Admin" && ss == "salasana2"){
            admin1.TestaaKayttaja2(kt, ss);
        }else if(kt == "Peruspertti" && ss == "salasana1"){
            peruspertti1.TestaaKayttaja1(kt, ss);
        }else{
            Console.WriteLine("Kirjautuminen epäonnistui!");
        }
    }
}

class Kayttaja{
    static string kayttajatunnus1 = "Peruspertti";
    string salasana1 = "salasana1";
    static string kayttajatunnus2 = "Admin";
    string salasana2 = "salasana2";

    protected void LuoKayttaja(string _kayttajatunnus, string _salasana){
        kayttajatunnus1 = _kayttajatunnus;
        salasana1 = _salasana;
        Console.WriteLine("Käyttäjä {0} luotu", kayttajatunnus1);
    }
    protected void Ohje(){
        Console.WriteLine("Ohjeet tulossa...");
    }
    protected virtual void NaytaKayttaja(){
        string kayttajatunnusVain3 = kayttajatunnus1.Substring(kayttajatunnus1.Length - 3);
        Console.WriteLine("--Käyttäjä--");
        Console.WriteLine($"Käyttäjänimi loppuu: {kayttajatunnusVain3}");
        Console.WriteLine("Salasana: ***");
    }
    protected virtual void TestaaKayttaja(string kt, string ss){
        if(kt == "Peruspertti" && ss == "salasana1"){
            Console.WriteLine("Kirjautuminen onnistui!");
            Ohje();
        }else if(kt == "Admin" && ss == "salasana2"){
            Console.WriteLine("Kirjautuminen onnistui!");
            NaytaKayttaja();
        }
    }
}
class Peruspertti : Kayttaja{
    public void LuoKayttaja1(string _kayttajatunnus, string _salasana){
        LuoKayttaja(_kayttajatunnus, _salasana);
    }
    public void TestaaKayttaja1(string kt, string ss){
        TestaaKayttaja(kt, ss);
    }
    protected override void NaytaKayttaja(){
        Console.WriteLine(" ");
    }
}
class Admin : Kayttaja{
    public void LuoKayttaja2(string _kayttajatunnus, string _salasana){
        LuoKayttaja(_kayttajatunnus, _salasana);
    }
    public void TestaaKayttaja2(string kt, string ss){
        TestaaKayttaja(kt, ss);
    }
    protected override void NaytaKayttaja(){
            Console.WriteLine("--Käyttäjä--");
            Console.WriteLine("Käyttäjätunnus: Admin");
            Console.WriteLine("Salasana: salasana2");
    }
}