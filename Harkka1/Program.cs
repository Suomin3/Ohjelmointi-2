class House{
    public static bool Tarvitaankolammitysta(double arvo){
        bool paluu = true;
        if(arvo > 20.0){
            paluu = false;
        }
        return paluu;
    } 
    public bool Tarvitaankolammitysta2(double arvo){
        bool paluu = true;
        if(arvo > 20.0){
            paluu = false;
        }
        return paluu;
        }
}

class Program
{
    static void Main(string[] args)
    {
        // House porinkamppa = new House();
        bool tarviiks = House.Tarvitaankolammitysta(18.0);
        Console.WriteLine("Heating " + tarviiks);

        House porinkamppa = new House();
        bool tarviiks2 = porinkamppa.Tarvitaankolammitysta2(21.0);
        Console.WriteLine("Heating " + tarviiks2);
    }
}