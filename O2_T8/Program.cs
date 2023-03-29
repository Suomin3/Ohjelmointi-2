namespace Harkka8;

class Program{
    static void Osa1(){
        double summa = 0;
        int lukuja = 0;
        int luettu;

        Console.Write("Anna lukuja, nolla lopettaa: ");

        while(true) {
            luettu = int.Parse(Console.ReadLine());
            if(luettu == 0) {
                Console.WriteLine("Summa lopussa: " + summa);

                double ka = summa / lukuja;
                Console.WriteLine("Keskiarvo: " + ka);
                break;
            }
            else{
                lukuja++;
                summa = summa + luettu;
                Console.WriteLine("Summa nyt: " + summa);
            }
        }
    }
    enum Paivat {
        Maanantai = 1, Tiistai, Keskiviikko, Torstai, Perjantai, Lauantai, Sunnuntai
    }
    enum Kuukaudet {
        Tammikuu = 1, Helmikuu, Maaliskuu, Huhtikuu, Toukokuu, Kesäkuu, Heinäkuu, Elokuu, Syyskuu, Lokakuu, Marraskuu, Joulukuu
    }
    enum Days {
        Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    enum Months {
        January = 1, February, March, April, May, June, July, August, September, October, November, December
    }
    static void Osa2() {
        Console.WriteLine("Anna päivän numero (1-7): ");
        string inputDay = Console.ReadLine();
        Console.WriteLine("Anna kuukauden numero (1-12): ");
        string inputMonth = Console.ReadLine();
        Console.WriteLine("Valitse kieli FI (oletus) / EN: ");
        string inputLanguage = Console.ReadLine().ToLower();
        if (inputLanguage == "") {
            Paivat numberPaiva;

            if (int.Parse(inputDay) > 7 || int.Parse(inputDay) < 1) {
                Console.WriteLine("Virheellinen päivä!");
                Osa2();
            }
            else if (Enum.TryParse(inputDay, out numberPaiva)){
                Console.Write("{0},", numberPaiva);
            }

            Kuukaudet numberKuukausi;
            if (int.Parse(inputMonth) > 12 ||int.Parse(inputMonth) < 1){
                Console.WriteLine(" Virheellinen kuukausi!");
                Osa2();
            }
            else if (Enum.TryParse(inputMonth, out numberKuukausi)) {
                Console.Write(" {0}", numberKuukausi);
            }
        }    
        if (inputLanguage == "en") {
            Days numberDay;

            Console.WriteLine(" ");

            if (int.Parse(inputDay) > 7 || int.Parse(inputDay) < 1) {
                Console.WriteLine("Incorrect day!");
                Osa2();
            }
            else if (Enum.TryParse(inputDay, out numberDay)){
                Console.Write("{0},", numberDay);
            }

            Months numberMonth;
            if (int.Parse(inputMonth) > 12 ||int.Parse(inputMonth) < 1){
                Console.WriteLine(" Incorrect month!");
                Osa2();
            }
            else if (Enum.TryParse(inputMonth, out numberMonth)) {
                Console.Write(" {0}", numberMonth);
            }
        }
    }
    static void Osa3(){
        Console.Write("Syötä lause: ");
        string input = Console.ReadLine();
        Tuple<char, int>[] array = new Tuple<char, int>[input.Length];

        int count = 0;

        for (int i = 0; i < input.Length; i++) {
            count = input.Count(x => x == input[i]);
            array[i] = Tuple.Create(input[i], count);
        }
        var dArray = array.Distinct().ToArray();

        for (int i = 0; i < dArray.Length; i++) {
            Console.WriteLine(dArray[i].Item1 + " löytyi yht. " + array[i].Item2);
        }
    }
    static void Main(string[] args) {
        Console.Write("Valitse osa (1, 2 tai 3): ");
        string valinta = Console.ReadLine();
        if(valinta == "1") {
            Console.WriteLine(" ");
            Osa1();
        }
        else if(valinta == "2"){
            Console.WriteLine(" ");
            Osa2();
        }
        else if(valinta == "3") {
            Console.WriteLine(" ");
            Osa3();
        }
    }
}