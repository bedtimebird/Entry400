using System;
using System.Collections.Generic;
using System.Linq;

public static class PermitOutput
{
  public static string header = new string('-', 40);
  public static string headerShort = new string('-', 20);

  public static void PrintCoquitlamDP()
  {
    Console.WriteLine("-- Applicant " + headerShort);
    Console.WriteLine("Date: " + DateTime.Now);
    
  }
}