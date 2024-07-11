class Program {
  static void Main() {
    User NewUser = new User();
    NewUser.UserGet();
    string NewUserName = NewUser.UserName;
    Console.WriteLine("Ваше имя " + NewUserName);
    }
  }

// class User 
// {
//   public string Name = "DefaltName";
//   public void UserGet() {
//     Console.WriteLine("Введіть ім'я користувача");
//     string Name = Convert.ToString(Console.ReadLine()); //При написанні числа замість строки буде помилка.
//   }

// }