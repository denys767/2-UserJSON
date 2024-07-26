using System.Text.Json;

class Program
{
  static void Main()
  {
    var user = new User();
    user.SetUserName();
    user.SetUserMail();
    user.SetAge();

    var options = new JsonSerializerOptions { WriteIndented = true };
    string jsonUserInfo = JsonSerializer.Serialize(user, options);
    string filePath = @"c:\Users\kdeni\Документы\Development\2-UserJSON\UserJson\user.json";
    File.WriteAllText(filePath, jsonUserInfo);

    Console.WriteLine("Файл успешно создан/дополнен.");
  }
}
