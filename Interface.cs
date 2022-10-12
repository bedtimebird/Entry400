using System;
using System.Collections.Generic;
using System.Linq;

public class Interface
{
  public BasicLogic newSession = new BasicLogic();

  public void InitialGreeting()
  {
    Console.WriteLine("Welcome to Plermit!");
    OverviewOptions();
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

  public void ContactOptions()
  {
    Console.WriteLine("");
  }

  public void OverviewSelection(int number)
  {
    // add new contact
    if(number == 1)
    {
      newSession.EnterNewContact();
      Console.WriteLine("Details recorded");
      //Console.WriteLine(newContact.ToString());
      OverviewOptions();
    } 
    // 
    else if (number == 2)
    {
      
    }
    // List all applications
    else if (number == 3)
    {
      foreach(var item in newSession.currentContacts)
      {
        Console.WriteLine(item.ToString());
        Console.WriteLine(" ");
      }
      OverviewOptions();
    }
    else if (number == 9) 
    {
      Console.WriteLine("Goodbye");
    }
    else 
    {
      Console.WriteLine("Sorry that option is currently unavailable");
      Console.WriteLine("Goodbye");
    }
  }
}