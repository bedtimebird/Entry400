using System.Collections.Generic;

// maybe this should be broken up into different application types (inheritance)
// single family, multifamily, mixed-use, commercial, industrial, agricultural(separate?), phased development
// 

public class DevelopmentApplicationModel
{

  public DevelopmentApplicationModel(SiteModel site, ContactModel primaryContact, string name)
  {
    List<ContactModel> contacts = new List<ContactModel>();
    contacts.Add(primaryContact);
    DevelopmentSite = site;
    ProjectName = name;
  }

  public DevelopmentApplicationModel(){}
  
  public string ProjectName{get;set;}
  public int NumberBuildings{get;set;}
  public decimal EstimatedCost{get;set;}
  public int CurrentPhase{get;set;}
  public int TotalPhases{get;set;}
  public int ProjectDescription{get;set;}
  public int ApartmentUnits{get;set;}
  public int TownhouseUnits{get;set;}
  public int SingleFamilyHouses{get;set;}
  public Enums.Multifamily MultifamilyUnits{get;set;}
  public bool ProposedRoad{get;set;}
  public bool LaneCancellation{get;set;}
  public bool ProposedVariance {get;set;}
  public int LotsWithVariance{get;set;}
  public SiteModel DevelopmentSite{get;set;}
  public List<ContactModel> DevelopmentContact{get;set;}
  public ExistingDetailsModel ExistingDevelopment{get;set;}
  public ProposedDetailsModel ProposedDevelopment{get;set;}

}

