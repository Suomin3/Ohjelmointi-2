namespace Kertaustehtävät;

class Program 
{
    static void Tehtava1() {
        Console.Write("Mihin asti? ");
        string num = Console.ReadLine();

        int num2 = int.Parse(num);
        for (int i = 1; i <= num2; i++) {
            Console.WriteLine(i);
        }
    }
    static void Tehtava2() {
        double paaoma;
        int korko;
        int vuodet;

        Console.Write("Alkupääoma: ");
        paaoma = double.Parse(Console.ReadLine());
        Console.Write("Korkoprosentti: ");
        korko = int.Parse(Console.ReadLine());
        Console.Write("Talletusaika (vuosina): ");
        vuodet = int.Parse(Console.ReadLine());

        for (int i = 1; i < vuodet; i++) {
            paaoma += paaoma * korko / 100;
            Console.WriteLine($"Pääoma {i} vuoden jälkeen on " + Math.Round(paaoma, 2), vuodet);
        }
    }
    static void Tehtava3() {
        int pituus;
        int maara;

        Console.WriteLine("Anna rivin pituus: ");
        pituus = Convert.ToInt32(Console.ReadLine());
        Console.Write("Anna rivien määrä: ");
        maara = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < maara; i++)
        {
            for (int j = 0; j < pituus; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine(" " + (i + 1));
        }
    }
    static void Tehtava4() {
        Console.Write("Anna teksti: ");
        string input = Console.ReadLine();
        Console.Write("Toistot?: ");
        int toistot = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < toistot; i++) {
            Console.WriteLine(input);
            if (i > 3) {
                break;
            }
        }
    }
    static void Main(string[] args) {
        Console.Write("Valitse tehtävä (1-4): ");
        string valinta = Console.ReadLine();
        if(valinta == "1") {
            Console.WriteLine(" ");
            Tehtava1();
        }
        else if(valinta == "2"){
            Console.WriteLine(" ");
            Tehtava2();
        }
        else if(valinta == "3") {
            Console.WriteLine(" ");
            Tehtava3();
        }
        else if(valinta == "4") {
            Console.WriteLine(" ");
            Tehtava4();
        }
    }
}