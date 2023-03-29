namespace Summa;

class Laske{
    public int Summa_(int luku1, int luku2){
        // return luku1 + luku2;

        int summa = luku1 + luku2;
        return summa;
    }
}

class Laske2{
    // Julkinen, staattinen (ei tehä sitä oliota), mitä palautetaan, metodin nimi, (mitä se ottaa sisään, mitä se ottaa sisään2)
    public static int Summa_(int luku1, int luku2, int luku3){
        // return luku1 + luku2;

        int summa = luku1 + luku2 - luku3;
        return summa;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Laske lasku1 = new Laske();
        int summa = lasku1.Summa_(1, 2);
        int summa2 = lasku1.Summa_(4, 1);

        Console.WriteLine("Tästä tulee " + summa);
        Console.WriteLine("Tästä tulee " + summa2);

        ///////////////////////////////////

        int summa3 = Laske2.Summa_(1000, 1, 1);
        int summa4 = Laske2.Summa_(1000, 1000, 1000);
        Console.WriteLine("Siitä tulee (staattinen) " + summa3);
        Console.WriteLine("Siitä tulee (staattinen) " + summa4);
    }
}

// Laske 1 + 2