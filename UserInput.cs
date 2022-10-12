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

}