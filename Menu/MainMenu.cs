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
    devApps = PopulateDevAppList(user);
    Console.WriteLine(ConsoleOutput.headerShort);
    Console.WriteLine("Main Menu");
    //TODO: Create summary view of all permit data on file taken from lists
    Console.WriteLine(ConsoleOutput.headerShort);
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. View/Edit Development Applications");
    Console.WriteLine("2. View/Edit Applicants");
    Console.WriteLine("3. View/Edit Sites");
    Console.WriteLine("9. Exit");
    int selection = int.Parse(UserInput.GetInfo(""));
    MainMenuSelection(selection);
  }

  public void MainMenuSelection(int selection)
  {
    switch(selection)
    {
      case 1:
        ApplicantMenu applicant = new ApplicantMenu();
        applicant.ApplicantMainMenu(devApplicants);
        //applicant.DisplayAllSite();
        //SiteOptions();
        break;
      case 2:
        siteSession.EnterNewSite();
        SiteOptions();
        break;
      case 3:
        siteSession.RemoveSite();
        SiteOptions();
        break;
      case 4:
        siteSession.EditSite();
        SiteOptions();
        break;
      case 8:
        siteSession.InsertTempSiteData();
        SiteOptions();
        break;
      case 9:
        OverviewOptions();
        break;
    }
  }

  public List<DevAppModel> PopulateDevAppList(UserModel user)
  {
    List<DevAppModel> devApp = new List<DevAppModel>();

    
  }
  
}