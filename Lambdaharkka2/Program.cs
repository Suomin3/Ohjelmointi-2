namespace Lambdaharkka2;

class Program {
    static int[] lukuja = new int[] {1, 2, 2, 2, 6, 4, 19, 19, 24, 31, 34, 3434};

    static int VertaaMetodi(int vertaaLukua, int[] luvut) {
        int tulos = 0;
        foreach (int yksiLuku in luvut) {
            if (yksiLuku == vertaaLukua) {
                tulos++;
            }
        }
        return tulos;
    }
    static void Main(string[] args) {
        try {
            Console.Write("Anna verrattava luku: ");
            Func<int, int[], int> vertailunTulos = (_vertaaLukua, _luvut) => VertaaMetodi(_vertaaLukua, _luvut);
            int tulos = vertailunTulos(int.Parse(Console.ReadLine()), lukuja);
            Console.WriteLine($"Tulos: {tulos}, listasta {string.Join(",", lukuja)}");
        }
        catch(Exception e) {
            Console.WriteLine("Virheellinen syöte: " + e.Message);
            Main(new string[]{});
        }
    }
}