using System;
using System.Collections.Generic;
using System.Linq;

public class SiteLogic : ContactLogic
{
  public List<SiteModel> currentSites = new List<SiteModel>();
  public List<LotModel> currentLots = new List<LotModel>();
  
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
    SiteModel editSite = new SiteModel();
    DisplayAllSite();
    int bob;
    bob = int.Parse(UserInput.GetInfo("Please enter site # to edit: "));
    editSite = currentSites.ElementAt(bob-1);
    Console.WriteLine(editSite.PrimaryAddress);
    foreach(var lot in editSite.SiteAddress)
    {
      Console.WriteLine(lot.Address);
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