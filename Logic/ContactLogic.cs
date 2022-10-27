using System;
using System.Collections.Generic;

public class ContactLogic : BasicLogic
{
  public List<ContactModel> currentContacts = new List<ContactModel>();
  
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