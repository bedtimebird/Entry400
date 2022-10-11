public class ContactModel
{
  public string FirstName{get;set;}
  public string LastName{get;set;}
  public string Employer{get;set;}
  public string Profession{get;set;}
  public string Address{get;set;}
  public string City{get;set;}
  public string PostalCode{get;set;}
  public string PriPhone{get;set;}
  public string SecPhone{get;set;}
  public string Email{get;set;}

  public ContactModel(string first, string last, string primaryPhone, string email)
  {
    FirstName = first;
    LastName = last;
    PriPhone = primaryPhone;
    Email = email;
  }
  
  public ContactModel(){}

  public ContactModel TempContactData()
  {
    ContactModel bob = new ContactModel("Bob", "Builder", "999-492-9234", "bobbyB@gmail.com");
    return bob;
  }
  
}