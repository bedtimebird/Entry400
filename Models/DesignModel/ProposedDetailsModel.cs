using System;
using System.Collections.Generic;

public class ProposalDetailsModel : DevDetailModel
{
  public ProposalDetailsModel(decimal tGFA)
  {
  TotalGFA = tGFA;
  }

  public ProposalDetailsModel(){}

  public List<PermittedUseModel> TargetLandUses {get;set;}
  public List<ZoneModel> TargetZoning {get;set;}
  public int TargetLotCount {get;set;}
  public decimal BaseResidentialGFA {get;set;}
  public decimal BonusResidentialGFA{get;set;}

}