using System;
using System.Collections.Generic;

public class PropZoningModel : DevZoningModel
{
  public PropZoningModel(decimal tGFA)
  {
  TotalGFA = tGFA;
  }

  public PropZoningModel(){}

  public List<PermittedUseModel> TargetLandUses {get;set;}
  public List<ZoneModel> TargetZoning {get;set;}
  public int TargetLotCount {get;set;}
  public decimal BaseResidentialGFA {get;set;}
  public decimal BonusResidentialGFA{get;set;}

}