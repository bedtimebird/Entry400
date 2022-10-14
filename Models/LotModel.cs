using System.Collections.Generic;

public class LotModel
{
  public LotModel(string address, string city, string province)
  {
    Address = address;
    City = city;
    Province = province;
  }
  public LotModel(){}
  
  public string Address{get;set;}
  public string City{get;set;}
  public string Province{get;set;}
  public string PostalCode{get;set;}
  public List<ContactModel> Owner{get;set;}
  public string PropertyID{get;set;}
  public decimal LotArea{get;set;}
  public bool ExistingBuilding{get;set;}
  public string LegalDescription{get;set;}
  public string Block{get;set;}
  public string Plan{get;set;}
  public string Lot{get;set;}
  public string PlanArea{get;set;}
  public string ParcelID{get;set;}
  public ZoneModel Zoning{get;set;}
  public AreaPlanModel AreaPlan{get;set;}

  
}