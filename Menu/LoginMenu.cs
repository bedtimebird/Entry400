using System;
using System.Collections.Generic;
using System.Linq;

public class LoginMenu
{

  public void LoginMenuOptions()
  {
    Console.WriteLine(ConsoleOutput.headerShort);
    Console.WriteLine("Welcome to Plermit!");
    Console.WriteLine(ConsoleOutput.headerShort);
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Login");
    Console.WriteLine("2. Create new account");
    Console.WriteLine("3. Forgot password");
    Console.WriteLine("9. Exit");
    int selection = int.Parse(UserInput.GetInfo(""));
    LoginMenuSelection(selection);
  }

  public void LoginMenuSelection(int selection)
  {
    LoginLogic login = new LoginLogic();
    switch(selection)
    {
      case 1:
        login.Login();
        break;
      case 2:
        login.NewAccount();
        break;
      case 3:
        login.RetrievePassword();
        break;
      case 9:
        ConsoleOutput.PrintProgramExit();
        break;
    }
  }
  
}