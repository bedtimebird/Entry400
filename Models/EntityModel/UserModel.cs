using System;
using System.Collections.Generic;

public class UserModel : PersonContactModel
{

  public UserModel(string userName, string pass, string first, string last, string phone, string email)
  {
  UserName = userName;
  Password = pass;
  FirstName = first;
  LastName = last;
  PriPhone = phone;
  Email = email;
  }

  public string UserName{get; set;}
  public string Password{get; set;}

}