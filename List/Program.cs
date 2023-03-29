namespace List;

class Program
{
    static void Main(string[] args) {
        List<string> words = new List<string>();

        words.Add("Moi");
        words.Add("Hei");
        words.Add("Terve");
        words.Add("Perkele");

        foreach(string word in words)
        {
            Console.WriteLine(word);
        }
        words.Remove("Terve");

        foreach(string word in words)
        {
            Console.WriteLine(word);
        }
    }
}