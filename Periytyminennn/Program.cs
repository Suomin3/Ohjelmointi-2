
class periTasta{
    public string joku(){
        return "Tiedonpaskaa";
    }
}
class periTanne : periTasta{
    static void Main(string[] args) {
        periTanne p1 = new periTanne();
        Console.WriteLine(p1.joku());
    }
}