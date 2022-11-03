using System;
using System.Collections.Generic;

public class ContactLogic
{
  public List<PersonContactModel> currentContacts = new List<PersonContactModel>();
  
  public void EnterNewContact()
  {
    PersonContactModel contact = new PersonContactModel();
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
    foreach(var contact in currentContacts)
      {
        Console.WriteLine($"{count}: {ConsoleOutput.PrintBasicPersonContact(contact)}");
        count += 1;
      }
    int bob;
    bob = int.Parse(UserInput.GetInfo("Enter contact number to be removed: "));
    currentContacts.RemoveAt(bob-1);
  }


  public void InsertTempContactData()
  {
    PersonContactModel person1 = new PersonContactModel("Auston", "Matthews", "999", "AM34@gmail.com");
    PersonContactModel person2 = new PersonContactModel("Cale", "Makar", "999", "CK8@gmail.com");
    PersonContactModel person3 = new PersonContactModel("Igor", "Shesterkin", "999", "IG31@gmail.com");
    PersonContactModel person4 = new PersonContactModel("Moritz", "Seider", "999", "MS53@gmail.com");
    currentContacts.Add(person1);
    currentContacts.Add(person2);
    currentContacts.Add(person3);
    currentContacts.Add(person4);
  }
}