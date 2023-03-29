using System;

namespace luokka {
    class Pankkitili {
        protected double rahaa = 1234.12;
        }
    // class randomAsiakas {
    //     Pankkitili tiettypankkitili = new Pankkitili();
    //     public randomAsiakas() {
    //         Console.WriteLine(tiettypankkitili.rahaa);
    //     }
    // }
    class omistajaAsiakas : Pankkitili {
        // Pankkitili tiettypankkitili = new Pankkitili();
        public omistajaAsiakas() {
            Console.WriteLine(rahaa);
        }
    }
    class Program {
        static void Main(string[] args) {
            omistajaAsiakas omis = new omistajaAsiakas();
            // randomAsiakas rand = new randomAsiakas();
        }
    }
}