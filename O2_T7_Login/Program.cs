namespace T7_Login;

class Program{
    static void Main (string[] args){

    }
}
class User
{
    List<string> users = new List<string>();
        users.Add("Kayttaja1");
        users.Add("Kayttaja2");
}
class Admins : User
{

}
class NotAdmins : User
{

}