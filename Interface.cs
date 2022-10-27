using System;
using System.Collections.Generic;
using System.Linq;

public class Interface
{
  public ContactLogic contactSession = new ContactLogic();
  public SiteLogic siteSession = new SiteLogic();

  public void InitialGreeting()
  {
    Console.WriteLine("Welcome to Plermit!");
    OverviewOptions();
  }

  public void SiteOptions()
  {
    Console.WriteLine("");
    Console.WriteLine("The following options are available: ");
    Console.WriteLine("1. List all active sites");
    Console.WriteLine("2. Add new site");
    Console.WriteLine("3. Remove site");
    Console.WriteLine("4. Edit site");
    Console.WriteLine("8. Insert temporary data");
    Console.WriteLine("9. Return back to options menu");
    int selection = int.Parse(UserInput.GetInfo(""));
    SiteSelection(selection);
  }

  public void SiteSelection(int number)
  {
    switch(number)
    {
      case 1:
        siteSession.DisplayAllSite();
        SiteOptions();
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

  public void ContactOptions()
  {
    Console.WriteLine("");
    Console.WriteLine("The following options are available: ");
    Console.WriteLine("1. List all contacts");
    Console.WriteLine("2. Add new contact");
    Console.WriteLine("3. Remove contact");
    Console.WriteLine("4. Assign contact to development application");
    Console.WriteLine("8. Insert temporary data");
    Console.WriteLine("9. Return back to options menu");
    int selection = int.Parse(UserInput.GetInfo(""));
    ContactSelection(selection);
  }

  public void ContactSelection(int number)
  {
    switch(number)
    {
      case 1:
        contactSession.DisplayAllContacts();
        ContactOptions();
        break;
      case 2:
        contactSession.EnterNewContact();
        ContactOptions();
        break;
      case 3:
        contactSession.RemoveContact();
        ContactOptions();
        break;
      case 8:
        contactSession.InsertTempContactData();
        ContactOptions();
        break;
      case 9:
        OverviewOptions();
        break;
    }
  }
  public void OverviewOptions()
  {
    //int contacts = newSession.Count;
    Console.WriteLine("");
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. View/Edit Contacts");
    Console.WriteLine("2. View/Edit Sites");
    Console.WriteLine("3. View/Edit Development Applications");
    Console.WriteLine("9. Exit");
    int selection = int.Parse(UserInput.GetInfo(""));
    OverviewSelection(selection);
  }
  public void OverviewSelection(int number)
  {
    switch(number)
    {
      case 1:
        ContactOptions();
        break;
      case 2:
        SiteOptions();
        break;
      case 9:
        Console.WriteLine("Goobye");
        break;
    }
  }
}