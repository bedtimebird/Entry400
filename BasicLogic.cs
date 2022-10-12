using System;
using System.Collections.Generic;

public class BasicLogic
{
  public List<ContactModel> currentContacts = new List<ContactModel>();
  public List<SiteModel> currentSites = new List<SiteModel>();
  public List<LotModel> currentLots = new List<LotModel>();
    
  public void EnterNewContact()
  {
    ContactModel contact = new ContactModel();
    contact.FirstName = UserInput.GetInfo("Enter first name: ");
    contact.LastName = UserInput.GetInfo("Enter last name: ");
    contact.PriPhone = UserInput.GetInfo("Enter primary phone number: ");
    contact.Email = UserInput.GetInfo("Enter email address: ");
    currentContacts.Add(contact);
  }

  public void EnterNewLots()
  {
    SiteModel site = new SiteModel();
    LotModel lot = new LotModel();
    lot.Province = UserInput.GetInfo("Enter province: ");
    lot.City = UserInput.GetInfo("Enter city: ");
    lot.Address = UserInput.GetInfo("Enter address: ");
    currentLots.Add(lot);
  }
  
}