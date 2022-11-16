using System;
using System.Collections.Generic;
using System.Linq;

public class ConsoleOutput
{
  public static string header = new string('-', 40);
  public static string headerShort = new string('-', 20);

  public static string PrintBasicPersonContact(PersonContactModel person)
  {
    string output = person.FirstName + " " + person.LastName;
    return output;
  }

  public static void DisplayActiveDevelopments(List<DevAppModel> devApps)
  {
    Console.WriteLine(headerShort);
    Console.WriteLine("Active Developments");
    Console.WriteLine(headerShort);
    foreach(var item in devApps)
    {
      Console.WriteLine(item.ProjName);
    }
    Console.WriteLine(headerShort);
  }

  public static void PrintTitle(string title)
  {
    Console.WriteLine(header);
    Console.WriteLine(title);
    Console.WriteLine(header);
  }

  public static void PrintSiteModel(SiteModel site)
  {
    Console.WriteLine(header);
    Console.WriteLine("Site Details");
    Console.WriteLine(header);
    Console.WriteLine(String.Format("{0,-4}{1,-20}{2,1}", "(1)", "Primary Address:", site.PrimaryAddress));
    Console.WriteLine(String.Format("{0,-4}{1,-20}{2,1}", "(2)", "Number of Lots:", site.SiteAddress.Count));
    Console.WriteLine(String.Format("{0,-4}{1,-20}{2,1}", "(3)", "Site Area(m2):", site.Area));
    Console.WriteLine(String.Format("{0,-4}{1,-20}{2,1}", "(4)", "Site Frontage(m):", site.Frontage));
    Console.WriteLine(String.Format("{0,-4}{1,-20}{2,1}", "(5)", "Existing Structure:", site.ExistingStructure));
    Console.WriteLine(String.Format("{0,-4}{1,-20}{2,1}", "(6)", "Floodplain:", site.Floodplain));
    Console.WriteLine(String.Format("{0,-4}{1,-20}{2,1}", "(7)", "Steep Slope:", site.SteepSlope));
    Console.WriteLine(String.Format("{0,-4}{1,-20}{2,1}", "(8)", "Stream Side:", site.StreamSide));
    Console.WriteLine(" ");
    Console.WriteLine("List of included lots: ");
    int count = 100;
    foreach (var lot in site.SiteAddress){
      Console.WriteLine(String.Format("({0,-3}) {1,-20}", count, lot.Address));
      count +=1;
    }
  }

  public static void PrintLotModel(LotModel lot)
  {
    Console.WriteLine(header);
    Console.WriteLine("Lot Details");
    Console.WriteLine(header);
    Console.WriteLine(String.Format("{0,-5}{1,-20}{2,1}", "(1)", "Address:", lot.Address));
    Console.WriteLine(String.Format("{0,-5}{1,-20}{2,1}", "(2)", "City:", lot.City));
    Console.WriteLine(String.Format("{0,-5}{1,-20}{2,1}", "(3)", "Province:", lot.Province));
    Console.WriteLine(String.Format("{0,-5}{1,-20}{2,1}", "(4)", "Postal Code:", lot.PostalCode));
    Console.WriteLine(headerShort);
    if(lot.Owner.Count != null){
      Console.WriteLine(String.Format("{0,-5}{1,-20}{2,1}", "(5)", "Number of Owners:", lot.Owner.Count));
    } else {
      Console.WriteLine(String.Format("{0,-5}{1,-20}{2,1}", "(5)", "Number of Owners:", "None listed"));
    }
    
    Console.WriteLine(String.Format("{0,-5}{1,-20}{2,1}", "(6)", "Property ID:", lot.PropertyID));
    Console.WriteLine(String.Format("{0,-5}{1,-20}{2,1}", "(7)", "Lot Area:", lot.LotArea));
    Console.WriteLine(String.Format("{0,-5}{1,-20}{2,1}", "(8)", "Existing Building:", lot.ExistingBuilding));
    Console.WriteLine(headerShort);
    Console.WriteLine(String.Format("{0,-5}{1,-20}{2,1}", "(9)", "Legal Description:", lot.LegalDescription));
    Console.WriteLine(String.Format("{0,-5}{1,-20}{2,1}", "(10)", "Block:", lot.Block));
    Console.WriteLine(String.Format("{0,-5}{1,-20}{2,1}", "(11)", "Plan:", lot.Plan));
    Console.WriteLine(String.Format("{0,-5}{1,-20}{2,1}", "(12)", "Lot:", lot.Lot));
    Console.WriteLine(headerShort);
    Console.WriteLine(String.Format("{0,-5}{1,-20}{2,1}", "(13)", "Plan Area:", lot.PlanArea));
    Console.WriteLine(String.Format("{0,-5}{1,-20}{2,1}", "(14)", "Parcel ID:", lot.ParcelID));
    Console.WriteLine(String.Format("{0,-5}{1,-20}{2,1}", "(15)", "Zoning:", lot.Zoning));
    Console.WriteLine(String.Format("{0,-5}{1,-20}{2,1}", "(16)", "Area Plan:", lot.AreaPlan));
    Console.WriteLine(String.Format("{0,-5}{1,-20}{2,1}", "(99)", "Exit:", lot.AreaPlan));
    Console.WriteLine(header);
  }
  
}