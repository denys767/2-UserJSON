class User
{
  public string UserName;
  public void SetUserData()
  {
    Console.WriteLine("Введите имя пользователя:");
    string Name = Console.ReadLine();

    if (Name == "" || int.TryParse(Name, out _)) //"out _" - означає що отримане значення непотрібне. Tryparse виводить bool: "Чи є вміст MailString числом?"
    {
      Console.WriteLine("Нельзя ввести число или ничего");
      throw new ArgumentNullException(nameof(Name)); //Треба переробити Exception - він сюди не підходить
    }

    else
    {
      UserName = Name;
    }
  }
}