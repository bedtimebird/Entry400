using System;
using System.Collections.Generic;
using System.Linq;

public class CoquitlamDevApp : DevAppModel
{

  public CoquitlamDevApp(ApplicantModel applicant, string name)
  {
    Applicant = applicant;
    ProjectName = name;
    CompleteApplication = false;
  }

  public int NumberBuildings{get;set;}
  public decimal EstimatedCost{get;set;}
  public int CurrentPhase{get;set;}
  public int TotalPhases{get;set;}
  public int ApartmentUnits{get;set;}
  public int TownhouseUnits{get;set;}
  public int SingleFamilyHouses{get;set;}
  public Enums.Multifamily MultifamilyUnits{get;set;}
  public bool ProposedRoad{get;set;}
  public bool LaneCancellation{get;set;}
  public bool ProposedVariance {get;set;}
  public int LotsWithVariance{get;set;}

}