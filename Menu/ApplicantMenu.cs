using System;
using System.Collections.Generic;
using System.Linq;

public class ApplicantMenu
{
  
  public void ApplicantMainMenu()
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
}