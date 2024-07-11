using System.Security.Cryptography.X509Certificates;

class User 
{
  public string UserName;
  public void UserGet() {
    Console.WriteLine ("Введите имя пользователя:");
    string Name =  Console.ReadLine();
    UserName = Name;
}
}