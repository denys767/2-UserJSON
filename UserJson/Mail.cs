class Mail
{
    public string UserMail;
    public void SetUserMail()
    {
        Console.WriteLine("Введите почту пользователя:");
        string MailString = Convert.ToString(Console.ReadLine());

        if (MailString == "" || int.TryParse(MailString, out _)) //"out _" - означає що отримане значення непотрібне. Tryparse виводить bool: "Чи є вміст MailString числом?"
        { 
            Console.WriteLine("Нельзя ввести число или ничего");
            throw new ArgumentNullException(nameof(MailString)); //Треба переробити Exception - він сюди не підходить
        }
        else
        {
            UserMail = MailString;
        }
    }
}