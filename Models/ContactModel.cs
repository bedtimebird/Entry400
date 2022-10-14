public class ContactModel
{

  public ContactModel(string first, string last, string primaryPhone, string email)
  {
    FirstName = first;
    LastName = last;
    PriPhone = primaryPhone;
    Email = email;
  }
  
  public ContactModel(){}

  public string BasicContactOutput(ContactModel c)
  {
    return ($"Name: {c.FirstName} {c.LastName}");
  }

  public override string ToString()
  {
    return $"First name: {FirstName}\n" + 
      $"Last name: {LastName}\n" + 
      $"Primary number: {PriPhone}\n" + 
      $"Email address: {Email}";
  }
  
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
}