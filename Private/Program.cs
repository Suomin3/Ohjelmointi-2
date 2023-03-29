
class Koira{
    protected string nimi;
}
class Koiranpentu : Koira{
    // public void Set(string _nimi){
    //     nimi = _nimi;
    //     // Console.WriteLine(_nimi + " asetettiin");
    //     // Console.WriteLine(nimi + " asetettiin");
    // }
    // public string Get(){
    //     return nimi;
    // }
    public string Nimi_{
        get{
            if(nimi == "Regina"){
                return "Älä käytä tätä enää";
            }else{
                return nimi;
            }
        }
        set{ nimi = value; }
    }
}
class Program{
    static void Main(string[] args)
    {
        // Koira jokuKoira1 = new Koira();
        // jokuKoira1.nimi = "Musti";
        // Console.WriteLine(jokuKoira1.nimi);
        Koiranpentu pentu1 = new Koiranpentu();
        // pentu1.Set("Regina");
        pentu1.Nimi_ = "Regina";
        // string pentu1Nimi = pentu1.Get();
        Console.WriteLine(pentu1.Nimi_);
    }
}