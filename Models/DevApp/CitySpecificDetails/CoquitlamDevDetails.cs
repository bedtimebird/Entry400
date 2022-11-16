using System;
using System.Collections.Generic;
using System.Linq;

public class CoquitlamDevDetails : DevAppDetailsModel
{

  public CoquitlamDevDetails()
  {
    City = "Coquitlam";
  }

  public int NumBuildings{get;set;}
  public decimal EstCost{get;set;}
  public int CurrentPhase{get;set;}
  public int TotalPhases{get;set;}
  public int ApartUnits{get;set;}
  public int TownhouseUnits{get;set;}
  public int SingleFamilyHouses{get;set;}
  public Enums.Multifamily MultifamilyUnits{get;set;}
  public bool PropRoad{get;set;}
  public bool LaneCancellation{get;set;}
  public bool PropVariance {get;set;}
  public int LotsWithVariance{get;set;}

}