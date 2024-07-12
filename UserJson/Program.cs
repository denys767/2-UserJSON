class Program
{
  static void Main()
  {
    var user = new User();
    user.SetUserData();
    string username = user.UserName;

    var userAge = new Age();
    userAge.SetAge();
    int newUserAge = userAge.UserNumber;

    var userMail = new Mail();
    userMail.SetUserMail();
    string usermail = userMail.UserMail;
  }
}
