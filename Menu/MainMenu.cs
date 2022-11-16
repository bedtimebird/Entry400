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
    ConsoleOutput.PrintTitle("Main Menu");
    //TODO: Create summary view of all permit data on file taken from lists
    ConsoleOutput.DisplayActiveDevelopments(devApps);
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
        ConsoleOutput.PrintTitle("Goodbye");
        break;
    }
  }



  public void PopulateDevAppList()
  {
    DevAppModel new1 = new DevAppModel("1595 High St, Coquitlam");
    LotModel lot1a = new LotModel("1595 High Street", "Coquitlam", "BC");
    List<LotModel> list1 = new List<LotModel>();
    list1.Add(lot1a);
    SiteModel site1a = new SiteModel("1595 High St", list1);
    new1.DevSite = site1a;
    
    DevAppModel new2 = new DevAppModel("15-25 Bottom Rd, Coquitlam");
    LotModel lot2a = new LotModel("15 Bottom Road", "Coquitlam", "BC");
    LotModel lot2b = new LotModel("19 Bottom Road", "Coquitlam", "BC");
    LotModel lot2c = new LotModel("25 Bottom Road", "Coquitlam", "BC");
    List<LotModel> list2 = new List<LotModel>();
    list2.Add(lot2a);
    list2.Add(lot2b);
    list2.Add(lot2c);
    SiteModel site2a = new SiteModel("25 Bottom Rd", list2);
    new2.DevSite = site2a;
    
    DevAppModel new3 = new DevAppModel("66-88 Rutter Rd, Coquitlam");
    LotModel lot3a = new LotModel("66 Rutter Road", "Coquitlam", "BC");
    LotModel lot3b = new LotModel("70 Rutter Road", "Coquitlam", "BC");
    LotModel lot3c = new LotModel("78 Rutter Road", "Coquitlam", "BC");
    LotModel lot3d = new LotModel("88 Rutter Road", "Coquitlam", "BC");
    List<LotModel> list3 = new List<LotModel>();
    list3.Add(lot3a);
    list3.Add(lot3b);
    list3.Add(lot3c);
    list3.Add(lot3d);
    SiteModel site3a = new SiteModel("66 Rutter Road", list3);
    new3.DevSite = site3a;
    
    
    DevAppModel new4 = new DevAppModel("200 Big Tree Lane, Coquitlam");
    LotModel lot4a = new LotModel("200 Big Tree Lane", "Coquitlam", "BC");
    List<LotModel> list4 = new List<LotModel>();
    list4.Add(lot4a);
    SiteModel site4a = new SiteModel("200 Big Tree Lane", list4);
    new4.DevSite = site4a;
    
    devApps.Add(new1);
    devApps.Add(new2);
    devApps.Add(new3);
    devApps.Add(new4);
  }
  
}