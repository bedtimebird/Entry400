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

    ConsoleOutput.DisplayActiveDevelopments(devApps);
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. View/Edit Development Application");
    Console.WriteLine("2. Create Developent Application");
    Console.WriteLine("3. Remove Development Application");
    Console.WriteLine("8. Sign out");
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
    
  ApplicantModel user1 = new ApplicantModel("Howard Hughes Builders", "132 Gateway", "Vancouver", "B5D 2Z4", "555-954-8475", "requests@hhbuilders.com", "Howard", "Flanigan", "993-725-2334", "Howard@hhbuilders.ca");
    
    DevAppModel new1 = new DevAppModel("1595 High St, Coquitlam");
    LotModel lot1a = new LotModel("1595 High Street", "Coquitlam", "BC");
    List<LotModel> list1 = new List<LotModel>();
    list1.Add(lot1a);
    SiteModel site1a = new SiteModel("1595 High St", list1);
    new1.DevSite = site1a;
    new1.Applicant = user1;
    
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
    new2.Applicant = user1;
    
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
    new3.Applicant = user1;
    
    DevAppModel new4 = new DevAppModel("200 Big Tree Lane, Coquitlam");
    LotModel lot4a = new LotModel("200 Big Tree Lane", "Coquitlam", "BC");
    List<LotModel> list4 = new List<LotModel>();
    list4.Add(lot4a);
    SiteModel site4a = new SiteModel("200 Big Tree Lane", list4);
    new4.DevSite = site4a;
    new4.Applicant = user1;
    
    devApps.Add(new1);
    devApps.Add(new2);
    devApps.Add(new3);
    devApps.Add(new4);
  }
  
}