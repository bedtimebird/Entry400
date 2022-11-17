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

  public ApplicantModel(string companyName, string address, string city, string postal, string companyPhone, string companyEmail, string firstName, string lastName, string phone, string email)
  {
  List<PersonContactModel> ContactList = new List<PersonContactModel>();
  PersonContactModel newPerson = new PersonContactModel(firstName, lastName, phone, email);

  CompanyName = companyName;
  Address = address;
  City = city;
  PostalCode = postal;
  PriPhone = companyPhone;
  Email = companyEmail;
  PriContact = newPerson;
  ContactList.Add(newPerson);
  }

  public List<PersonContactModel> ContactList{get;set;}
  public PersonContactModel PriContact{get;set;}


}