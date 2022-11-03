using System;
using System.Collections.Generic;

public class CompanyContactModel : ContactModel
{
  public CompanyContactModel(string name)
  {
  CompanyName = name;
  }
  
  public CompanyContactModel()
  {

  }

  public CompanyContactModel(string name, string address, string city, string postal, string phone, string email)
  {
  CompanyName = name;
  Address = address;
  City = city;
  PostalCode = postal;
  PriPhone = phone;
  Email = email;
  }

  public string CompanyName{get;set;}
}