namespace CastleDefender
{
    public class Castle{
        bool Gold = true;
        bool Gems = true;
        int Arrows = 10;
        int Food = 1000;

        public void Defend(Enemy Name) {
            Arrows--;
            Console.WriteLine(Name.Name + " is attacking!");
            Console.WriteLine("Gold: " + Gold);
            Console.WriteLine("Gems: " + Gems);
            Console.WriteLine("Arrows: " + Arrows);
        }

        public void GiveFood(Resident Resident1, int amount) { // Antaa ruokaa pyytäjälle
            Resident1.Food += amount;
            Food = Food - amount;
            Console.WriteLine("Food left: " + Food);
        }
    }

    public class Resident{
        public int Food = 0;
        public void AskFood(Castle castle1) {
            castle1.GiveFood(this,10);
            Console.WriteLine("Thank you for the food.");
        }
    }
    public class Enemy{
        public string Name = "Lord Voldemort";

        public void Attack(Castle castle1){
            castle1.Defend(this);
            Console.WriteLine(Name + " Yells: Heeeeeelp!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Castle someCastle = new Castle();
            Resident someResident = new Resident();
            someResident.AskFood(someCastle);
        }
    }
}