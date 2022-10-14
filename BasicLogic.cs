using System;
using System.Collections.Generic;

public class BasicLogic
{
  public List<ContactModel> currentContacts = new List<ContactModel>();
  public List<SiteModel> currentSites = new List<SiteModel>();
  public List<LotModel> currentLots = new List<LotModel>();

  public void DisplayAllSite()
  {
    foreach(var siteModel in currentSites)
    {
      foreach(var lot in siteModel.SiteAddress)
      {
        Console.Write(lot.Address + " ,");
      }
    }
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
  
  public void EnterNewContact()
  {
    ContactModel contact = new ContactModel();
    contact.FirstName = UserInput.GetInfo("Enter first name: ");
    contact.LastName = UserInput.GetInfo("Enter last name: ");
    contact.PriPhone = UserInput.GetInfo("Enter primary phone number: ");
    contact.Email = UserInput.GetInfo("Enter email address: ");
    currentContacts.Add(contact);
  }

  public void DisplayAllContacts()
  {
    foreach(var item in currentContacts)
      {
        Console.WriteLine(item.ToString());
        Console.WriteLine(" ");
      }
  }

  public void RemoveContact()
  {
    Console.WriteLine("Please select contact to remove: ");
    int count = 1;
    foreach(var item in currentContacts)
      {
        Console.WriteLine($"{count}: {item.BasicContactOutput(item)}");
        count += 1;
      }
    int bob;
    bob = int.Parse(UserInput.GetInfo("Enter contact number to be removed: "));
    currentContacts.RemoveAt(bob-1);
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
    SiteModel newSite = new SiteModel(lots);
    currentSites.Add(newSite);
  }

  public void InsertTempContactData()
  {
    ContactModel person1 = new ContactModel("Auston", "Matthews", "999", "AM34@gmail.com");
    ContactModel person2 = new ContactModel("Cale", "Makar", "999", "CK8@gmail.com");
    ContactModel person3 = new ContactModel("Igor", "Shesterkin", "999", "IG31@gmail.com");
    ContactModel person4 = new ContactModel("Moritz", "Seider", "999", "MS53@gmail.com");
    currentContacts.Add(person1);
    currentContacts.Add(person2);
    currentContacts.Add(person3);
    currentContacts.Add(person4);
  }
  
}