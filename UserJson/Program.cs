using System.Text.Json;
class Program
{
  static void Main()
  {
    var user = new User();
    user.SetUserData();
    user.SetUserMail();
    user.SetAge();

    var options = new JsonSerializerOptions { WriteIndented = true };
    string jsonUserInfo = JsonSerializer.Serialize(user, options);
    string filename = "User.json";
    File.WriteAllText(filename, jsonUserInfo);

    Console.WriteLine($"Файл {filename} успешно создан/дополнен.");

  }
}
