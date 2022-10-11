using System.Collections.Generic;

public class SiteModel
{
  public List<LotModel> SiteAddress{get;set;}
  public decimal Area{get;set;}
  public decimal Frontage{get;set;}
  public decimal Depth{get;set;}
  public bool ExistingStructure{get;set;}
  public bool Floodplain{get;set;}
  public bool SteepSlope{get;set;}
  public bool StreamSide{get;set;}
  public Enums.StructureStatus Structure{get;set;}

  public SiteModel(List<LotModel> lots)
  {
    SiteAddress = lots;
  }

  public SiteModel(){}

  public SiteModel TempSiteModelData(List<LotModel> lots)
  {
    SiteModel newDev = new SiteModel();
    newDev.SiteAddress = lots;
    return newDev;
  }
  
}

