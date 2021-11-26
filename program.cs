using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
int minLength = 8;
string uppercase = "ABCEDFGHIJKLMNOPQRSTUVWXYZ";
string lowercase = "abcdefghijklmnopqrstuvwxyz";
string digits = "0123456789";
string specialChars = "~!@#$%^&*()-+";      

Console.WriteLine("Please enter password: ");
string password = Console.ReadLine();

int score = 0;
if (password.Length >= minLength){
  score++;
}
if (Tools.Contains(password, uppercase)){
  score++;
}
if (Tools.Contains(password, lowercase)){
  score++;
}
if (Tools.Contains(password, digits)){
  score++;
}
if(Tools.Contains(password, specialChars)){
  score++;
}

switch (score){
  case 5:
  Console.WriteLine("Your password is awesome and super secure!");
  break;
  case 4:
  Console.WriteLine("Your password is will keep MOST of the bad guys out. Could be better.");
  break;
  case 3:
  Console.WriteLine("Your password is average, but needs to be more secure!");
  break;
  case 2:
  Console.WriteLine("Your password is valid, BUT sucks and needs better security!");
  break;
  case 1:
  Console.WriteLine("Your password needs some work in order to be secure! I HIGHLY suggest adding additional digits, characters, and an uppercase letter.");
  break;
  default:
  Console.WriteLine("Your password does not meet any of the requirements. Please try again!");
  break;
}
    }
  }
}
