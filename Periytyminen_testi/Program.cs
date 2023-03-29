
// class Program
// {
//     static void Main(string[] args)
//     {
//         AdminKayttaja admin1 = new AdminKayttaja();
//         admin1.Luo("admin","asdasd");
//         PerusKayttaja admin1 = new PerusKayttaja();
//         perus1.Luo("perus","asdasd");

//         Console.WriteLine("Anna käyttäjätunnus: (qwerty ja asdasd)");
//         string kt = Console.ReadLine();
//         Console.WriteLine("Anna salasana:");
//         string ss = Console.ReadLine();

//         admin1.Testaa(kt,ss);
//         perus1.Testaa(kt,ss);
//     }
// }
// class Kayttaja{
//     static string kayttajatunnus = "";
//     string salasana = "";
//     public void Luo(string _kayttajatunnus, string _salasana){
//         kayttajatunnus = _kayttajatunnus;
//         salasana = _salasana;
//         Console.WriteLine("Käyttäjä: {0} luotu", kayttajatunnus);
//     }
//     public void Ohje(){
//         Console.WriteLine("Ohjeet tulossa ...");
//     }
//     protected virtual void NaytaKayttaja(){
//     string kayttajatunnusVain3 = kayttajatunnus.Substring(kayttajatunnus.Length - 3);
//         Console.WriteLine("--Käyttäjä--");
//         Console.WriteLine($"Käyttäjänimi loppuu: {kayttajatunnusVain3}");
//         Console.WriteLine("Salasana: ***************");
//         }
//     public void Testaa(string kt, string ss){
//         if(kt == kayttajatunnus && ss == salasana){
//             Console.WriteLine("Kirjautuminen onnistui!");
//             NaytaKayttaja();
//         }else{
//             Console.WriteLine("Kirjautuminen epäonnistui!");
//         }
//     }
// }
// class PerusKayttaja : Kayttaja {
//     public PerusKayttaja() {
//     }

//     protected override void NaytaKayttaja() {
//         base.NaytaKayttaja();
//     }
// }

// class AdminKayttaja : Kayttaja {
//     private string kayttajatunnus;
//     private string salasana;

//     public AdminKayttaja(string kt, string ss) {
//         kayttajatunnus = kt;
//         salasana = ss;
//     }

//     protected override void NaytaKayttaja() {
//         Console.WriteLine("Käyttäjätunnus: " + kayttajatunnus);
//         Console.WriteLine("Salasana: " + salasana);
//     }
// }
// // static void Main(string[] args)
// // {
// //     Kayttaja kayttaja;

// //     Console;
// // }
