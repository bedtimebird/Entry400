using System;
using System.Collections.Generic;
using System.Linq;

public class MainMenu
{
  // TODO: Populate this object from database
  List<DevAppModel> devApps = new List<DevAppModel>();

  public void MainMenuOptions(UserModel user)
  {
    //TODO: create method to populate devApps based on UserModel
    PopulateDevAppList();
    Console.WriteLine(ConsoleOutput.headerShort);
    Console.WriteLine("Main Menu");
    //TODO: Create summary view of all permit data on file taken from lists
    Console.WriteLine(ConsoleOutput.headerShort);
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. View/Edit Development Applications");
    Console.WriteLine("2. View/Edit Applicants");
    Console.WriteLine("3. View/Edit Sites");
    Console.WriteLine("8. Logout");
    Console.WriteLine("9. Exit");
    int selection = int.Parse(UserInput.GetInfo(""));
    MainMenuSelection(selection);
  }

  public void MainMenuSelection(int selection)
  {
    switch(selection)
    {
      case 1:
        break;
      case 2:
        break;
      case 3:
        break;
      case 8:
        LoginMenu newSession = new LoginMenu();
        newSession.LoginMenuOptions();
        break;
      case 9:
        ConsoleOutput.PrintProgramExit();
        break;
    }
  }

  public void PopulateDevAppList()
  {
    DevAppModel new1 = new DevAppModel("1595 High St, Coquitlam");
    DevAppModel new2 = new DevAppModel("15-25 Bottom Rd, Coquitlam");
    DevAppModel new3 = new DevAppModel("66-88 Rutter Rd, Coquitlam");
    DevAppModel new4 = new DevAppModel("200 Big Tree Lane, Coquitlam");
    devApps.Add(new1);
    devApps.Add(new2);
    devApps.Add(new3);
    devApps.Add(new4);
  }
  
}