using System;
using System.Collections.Generic;
using System.Linq;

public static class UserInput
{

  public static string GetInfo(string msg)
    {
      string rtn = "";
      Console.WriteLine(msg);
      rtn = Console.ReadLine();
      return rtn;
    }

  public static string ModifyString(string msg)
  {
    string rtn = "";
    Console.WriteLine(msg);
    rtn = Console.ReadLine();
    return rtn;
  }
  public static decimal ModifyDecimal(string msg)
  {
    decimal rtn;
    Console.WriteLine(msg);
    rtn = decimal.Parse(Console.ReadLine());
    return rtn;
  }
  public static Nullable<bool> ModifyBool(string msg)
  {
    Nullable<bool> rtn;
    Console.WriteLine(msg);
    string choice;
    choice = Console.ReadLine();
    if(choice.ToLower() == "y"){
      rtn = true;
    } 
    else if (choice.ToLower() == "n")
    {
      rtn = false;
    } 
    else
    {
      rtn = null;
    }
    return rtn;
  }

}