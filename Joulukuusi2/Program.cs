using System;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int korkeus = 10;
            PrintChristmasTree(korkeus);
        }

        // Toiminta:
        //   Metodi tulostaa halutun korkuisen joulukuusen.
        // Parametrit:
        //   height = joulukuusen korkeus riveinä
        static void PrintChristmasTree(int height)
        {
            // TOTEUTA TÄHÄN ALGORITMI
        }

        // Toiminta:
        //   Metodi tulostaa yksittäistä merkkiä tietyn määrän. Metodi voi myös tulostaa rivinvaihdon, jos halutaan.
        // Parametrit:
        //   count = tulostettavien merkkien lukumäärä
        //   printChar = tulostettava merkki
        //   newLine = tulostetaanko lopuksi rivinvaihto, oletuksena true
        static void PrintChars(int count, char printChar, bool newLine = true)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(printChar);
            }
            if (newLine)   // Huom. pelkkä newLine tuottaa saman totuusarvon kuin lauseke newLine == true
            {
                Console.WriteLine();
            }
        }
    }
}