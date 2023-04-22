namespace EventTehtava11;
/*
//Muuta tätä ohjelmaa niin, että ohjelma tulostaa mallitulostuksen mukaisen tulostuksen.
//HUOM. tehtävässä EI saa käyttää minkäänlaista looppia! -> 0pts
//Vinkki: tehtävä on mahdollista ratkaista kolmella rivillä koodia.

Mallitulostus
> dotnet run
No
nyt
toimii file1.txt
hyvin!

No
nyt
toimii file2.txt
hyvin!

No
nyt
toimii file3.txt
hyvin!
*/
class Program
{
    static EventManager eventManager = new EventManager();
    static FileStuff fileStuff = new FileStuff(eventManager);
    static void Main(string[] args)
    {
        eventManager.WriteEvent += Writer;

        FileStuff someFile1 = new FileStuff(eventManager, @"file1.txt");

        FileStuff someFile2 = new FileStuff(eventManager, @"file2.txt");

        FileStuff someFile3 = new FileStuff(eventManager, @"file3.txt");

        
    }
}