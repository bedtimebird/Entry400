using System;
using System.Collections.Generic;
using System.Linq;

public class SiteLogic
{
  public List<SiteModel> currentSites = new List<SiteModel>();
  public List<LotModel> currentLots = new List<LotModel>();

  //Move to ConsoleOutput
  public void DisplayAllSite()
  {
    int count = 1;
    foreach(var siteModel in currentSites)
    {
      Console.WriteLine(count + ". " + siteModel.PrimaryAddress);
      Console.WriteLine("   Lot count: " + siteModel.SiteAddress.Count);
      Console.WriteLine("");
      count += 1; 
    }
  }

  public void EditSite()
  {
    DisplayAllSite();
    int rec;
    rec = int.Parse(UserInput.GetInfo("Please enter site # to edit: "));
    rec = rec-1;
    ConsoleOutput.PrintSiteModel(currentSites.ElementAt(rec));
    
    int sel;
    sel = int.Parse(UserInput.GetInfo("Enter field # to modify: "));
    if(sel < 10)
    {
      EditSiteDetails(sel, rec);
    } else if (sel > 99)
    {
      int  lot = sel - 100;
      ConsoleOutput.PrintLotModel(currentSites.ElementAt(rec).SiteAddress.ElementAt(lot));
      int fieldMod;
      fieldMod = int.Parse(UserInput.GetInfo("Enter field # to modify: "));
      EditLotDetails(sel, rec, fieldMod);
    } else 
    {
      Console.WriteLine("Incorrect value provided.");
    }
    //ConsoleOutput.PrintSiteModel(currentSites.ElementAt(rec));
  }
  public void EditLotDetails(int sel, int rec, int fieldMod)
  {
    int  lot = sel - 100;
    switch(fieldMod)
    {
      case 1:
        Console.WriteLine("Current Value: " + currentSites.ElementAt(rec).SiteAddress.ElementAt(lot).Address);
        currentSites.ElementAt(rec).SiteAddress.ElementAt(lot).Address = UserInput.ModifyString("Enter new address: ");
        break;
      case 2:
        Console.WriteLine("Current Value: " + currentSites.ElementAt(rec).SiteAddress.ElementAt(lot).City);
        currentSites.ElementAt(rec).SiteAddress.ElementAt(lot).City = UserInput.ModifyString("Enter new City: ");
        break;
      case 3:
        Console.WriteLine("Current Value: " + currentSites.ElementAt(rec).SiteAddress.ElementAt(lot).Province);
        currentSites.ElementAt(rec).SiteAddress.ElementAt(lot).Province = UserInput.ModifyString("Enter new Province: ");
        break;
      case 4:
        Console.WriteLine("Current Value: " + currentSites.ElementAt(rec).SiteAddress.ElementAt(lot).PostalCode);
        currentSites.ElementAt(rec).SiteAddress.ElementAt(lot).PostalCode = UserInput.ModifyString("Enter new Postal Code: ");
        break;
      case 5:
        //CREATE METHOD TO ADD MORE OWNERS
        break;
      case 6:
        Console.WriteLine("Current Value: " + currentSites.ElementAt(rec).SiteAddress.ElementAt(lot).PropertyID);
        currentSites.ElementAt(rec).SiteAddress.ElementAt(lot).PropertyID = UserInput.ModifyString("Enter new Property ID: ");
        break;
      case 7:
        Console.WriteLine("Current Value: " + currentSites.ElementAt(rec).SiteAddress.ElementAt(lot).LotArea);
        currentSites.ElementAt(rec).SiteAddress.ElementAt(lot).LotArea = UserInput.ModifyDecimal("Enter new Property ID: ");
        break;
      case 8:
        Console.WriteLine("Current Value: " + currentSites.ElementAt(rec).StreamSide);
        currentSites.ElementAt(rec).StreamSide = UserInput.ModifyBool("Is there an existing structure (y/n): ");
        break;
      case 8:
        Console.WriteLine("Current Value: " + currentSites.ElementAt(rec).StreamSide);
        currentSites.ElementAt(rec).StreamSide = UserInput.ModifyBool("Is there an existing structure (y/n): ");
        break;
      case 9:
        Console.WriteLine("Current Value: " + currentSites.ElementAt(rec).SiteAddress.ElementAt(lot).LegalDescription);
        currentSites.ElementAt(rec).SiteAddress.ElementAt(lot).LegalDescription = UserInput.ModifyString("Enter new Legal Description: ");
        break;
      case 10:
        Console.WriteLine("Current Value: " + currentSites.ElementAt(rec).SiteAddress.ElementAt(lot).Block);
        currentSites.ElementAt(rec).SiteAddress.ElementAt(lot).Block = UserInput.ModifyString("Enter new Block: ");
        break;
      case 11:
        Console.WriteLine("Current Value: " + currentSites.ElementAt(rec).SiteAddress.ElementAt(lot).Plan);
        currentSites.ElementAt(rec).SiteAddress.ElementAt(lot).Plan = UserInput.ModifyString("Enter new Plan: ");
        break;
      case 12:
        Console.WriteLine("Current Value: " + currentSites.ElementAt(rec).SiteAddress.ElementAt(lot).Lot);
        currentSites.ElementAt(rec).SiteAddress.ElementAt(lot).Lot = UserInput.ModifyString("Enter new Lot: ");
        break;
      case 13:
        Console.WriteLine("Current Value: " + currentSites.ElementAt(rec).SiteAddress.ElementAt(lot).PlanArea);
        currentSites.ElementAt(rec).SiteAddress.ElementAt(lot).PlanArea = UserInput.ModifyString("Enter new Plan Area: ");
        break;
      case 14:
        Console.WriteLine("Current Value: " + currentSites.ElementAt(rec).SiteAddress.ElementAt(lot).ParcelID);
        currentSites.ElementAt(rec).SiteAddress.ElementAt(lot).ParcelID = UserInput.ModifyString("Enter new Parcel ID: ");
        break;
      case 15:
        // TO BE ADDRESSED
        // Need to access list of ZoneModel - loop through to show available
        break;
      case 16:
        // TO BE ADDRESSED
        // Same as case 15 - loop through list of Area Plan Models
        break;
    }
  }

  // Method is working - not pretty at all - also after inputting change person is kick back to main menu
  // not ideal
  public void EditSiteDetails(int sel, int rec)
  {
    switch(sel)
    {
      case 1:
        Console.WriteLine("Current Value: " + currentSites.ElementAt(rec).PrimaryAddress);
        currentSites.ElementAt(rec).PrimaryAddress = UserInput.ModifyString("Enter new value: ");
        break;
      case 2:
        EnterNewLots();
        break;
      case 3:
        Console.WriteLine("Current Value: " + currentSites.ElementAt(rec).Area);
        currentSites.ElementAt(rec).Area = UserInput.ModifyDecimal("Enter site area value (m2): ");
        break;
      case 4:
        Console.WriteLine("Current Value: " + currentSites.ElementAt(rec).Frontage);
        currentSites.ElementAt(rec).Frontage = UserInput.ModifyDecimal("Enter site frontage value (m): ");
        break;
      case 5:
        Console.WriteLine("Current Value: " + currentSites.ElementAt(rec).ExistingStructure);
        currentSites.ElementAt(rec).ExistingStructure = UserInput.ModifyBool("Is there an existing structure on site (y/n): ");
        break;
      case 6:
        Console.WriteLine("Current Value: " + currentSites.ElementAt(rec).Floodplain);
        currentSites.ElementAt(rec).Floodplain = UserInput.ModifyBool("Is the site located within a floodplain (y/n): ");
        break;
      case 7:
        Console.WriteLine("Current Value: " + currentSites.ElementAt(rec).SteepSlope);
        currentSites.ElementAt(rec).SteepSlope = UserInput.ModifyBool("Is the site located within steep slope area (y/n): ");
        break;
      case 8:
        Console.WriteLine("Current Value: " + currentSites.ElementAt(rec).StreamSide);
        currentSites.ElementAt(rec).StreamSide = UserInput.ModifyBool("Is the site located within stream side setback area (y/n): ");
        break;
    }
  }

  

  public void EnterNewSite()
  {
    string primaryAddress = "";
    primaryAddress = UserInput.GetInfo("Enter primary address: ");
    EnterNewLots();
    SiteModel site = new SiteModel(primaryAddress, currentLots);
    currentSites.Add(site);
    currentLots = new List<LotModel>();
  }

  public void EnterNewLots()
  {
    //SiteModel site = new SiteModel();
    LotModel lot = new LotModel();
    string province = "";
    string city = "";
    
    province = UserInput.GetInfo("Enter province: ");
    city = UserInput.GetInfo("Enter city: ");
    lot.Province = province;
    lot.City = city;
    lot.Address = UserInput.GetInfo("Enter address: ");
    currentLots.Add(lot);
    EnterAnotherLot(province, city);
  }

  public void EnterQuickLot(string province, string city)
  {
    LotModel lot = new LotModel();
    lot.Address = UserInput.GetInfo("Enter address: ");
    lot.Province = province;
    lot.City = city;
    currentLots.Add(lot);
    EnterAnotherLot(province, city);
  }

  public void EnterAnotherLot(string province, string city)
  {
    string response = "n";
    response = UserInput.GetInfo("Would you like to enter another lot? (y/n)");
    if(response.ToLower() == "y")
    {
      EnterQuickLot(province, city);
    } 
  }

  public void RemoveSite()
  {
    DisplayAllSite();
    int bob;
    bob = int.Parse(UserInput.GetInfo("Please enter site # to remove: "));
    currentSites.RemoveAt(bob-1);
  }


  public void InsertTempSiteData()
  {
    LotModel lot1 = new LotModel("113 Penny St", "Coquitlam", "BC");
    LotModel lot2 = new LotModel("115 Penny St", "Coquitlam", "BC");
    LotModel lot3 = new LotModel("117 Penny St", "Coquitlam", "BC");
    List<LotModel> lots = new List<LotModel>();
    lots.Add(lot1);
    lots.Add(lot2);
    lots.Add(lot3);
    SiteModel newSite = new SiteModel("Penny Lane Development", lots);
    currentSites.Add(newSite);
  }

}