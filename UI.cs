using System;
using System.Collections.Generic;

public static class UI
{
  public static BasicLogic newSession = new BasicLogic();
  
  public static string GetInfo(string msg)
  {
    string rtn = "";
    Console.WriteLine(msg);
    rtn = Console.ReadLine();
    return rtn;
  }

  public static void InitialGreeting()
  {
    Console.WriteLine("Welcome to Plermit!");
    ListOptions();
  }

  public static void ListOptions()
  {
    Console.WriteLine("");
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Input new contact information");
    Console.WriteLine("2. Start new development application");
    Console.WriteLine("3. List all contacts");
    Console.WriteLine("50. Exit");
    int selection = int.Parse(GetInfo(""));
    PlermitOptions(selection);
  }


  public static void PlermitOptions(int number)
  {
    
    
    if(number == 1)
    {
      newSession.GetContactDetails();
      Console.WriteLine("Details recorded");
      //Console.WriteLine(newContact.ToString());
      ListOptions();
    } 
    else if (number == 3)
    {
      foreach(var item in newSession.currentContacts)
      {
        Console.WriteLine(item.ToString());
      }
      ListOptions();
    }
    else if (number == 50) 
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