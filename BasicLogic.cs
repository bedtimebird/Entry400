using System;
using System.Collections.Generic;

public class BasicLogic
{
  public List<ContactModel> currentContacts = new List<ContactModel>();
  
  public void GetContactDetails()
  {
    ContactModel contact = new ContactModel();
    contact.FirstName = UI.GetInfo("Enter first name: ");
    contact.LastName = UI.GetInfo("Enter last name: ");
    contact.PriPhone = UI.GetInfo("Enter primary phone number: ");
    contact.Email = UI.GetInfo("Enter email address: ");
    currentContacts.Add(contact);
  }
  
}