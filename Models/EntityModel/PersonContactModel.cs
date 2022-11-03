public class PersonContactModel : ContactModel
{
  public PersonContactModel(string first, string last, string phone, string email)
  {
  FirstName = first;
  LastName = last;
  PriPhone = phone;
  Email = email;
  }

  public PersonContactModel()
  {
  
  }

  public string FirstName{get;set;}
  public string LastName{get;set;}
  public string CellPhone{get;set;}
  public string Profession{get;set;}

}