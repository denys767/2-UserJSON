class User
{
  public string UserName;
  public void SetUserData()
  {
    Console.WriteLine("Введите имя пользователя:");
    string Name = Console.ReadLine();

    if (Name == "" || int.TryParse(Name, out _) || double.TryParse(Name, out _)) //"out _" - означає що отримане значення непотрібне. Tryparse виводить bool: "Чи є вміст MailString числом?"
    //Я без ідей, що треба зробити щоб кидалася помилка при дробу через крапку
    {
      throw new ArgumentException("Нельзя ввести что-то кроме строки", nameof(Name));
    }

    else
    {
      UserName = Name;
    }
  }
}