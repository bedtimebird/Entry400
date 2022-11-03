using System;
using System.Collections.Generic;

public class ApplicantModel : CompanyContactModel
{

  public ApplicantModel(string name, string address, string city, string postal, string phone, string email, PersonContactModel contact)
  {
  List<PersonContactModel> ContactList = new List<PersonContactModel>();

  CompanyName = name;
  Address = address;
  City = city;
  PostalCode = postal;
  PriPhone = phone;
  Email = email;
  PriContact = contact;
  ContactList.Add(contact);
  }

  public List<PersonContactModel> ContactList{get;set;}
  public PersonContactModel PriContact{get;set;}


}