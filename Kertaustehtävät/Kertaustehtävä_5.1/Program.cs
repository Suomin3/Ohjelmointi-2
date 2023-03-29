using System;

namespace luokka {
    class Pankkitili {
        public double rahaa = 1234.12;
        }
    class randomAsiakas {
        Pankkitili tiettypankkitili = new Pankkitili();
        public randomAsiakas() {
            Console.WriteLine(tiettypankkitili.rahaa);
        }
    }
    class omistajaAsiakas {
        Pankkitili tiettypankkitili = new Pankkitili();
        public omistajaAsiakas() {
            Console.WriteLine(tiettypankkitili.rahaa);
        }
    }
    class Program {
        static void Main(string[] args) {
            omistajaAsiakas omis = new omistajaAsiakas();
            randomAsiakas rand = new randomAsiakas();
        }
    }
}
