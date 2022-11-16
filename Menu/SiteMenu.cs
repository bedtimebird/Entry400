using System;
using System.Collections.Generic;
using System.Linq;

public class SiteMenu
{
  
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
        break;
      case 2:
        break;
      case 3:
        break;
      case 4:
        break;
      case 8:
        break;
      case 9:
        break;
    }
  }
}