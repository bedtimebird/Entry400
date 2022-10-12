using System.Collections.Generic;

public class SiteModel
{
  public SiteModel(List<LotModel> lots, string area, string frontage, string depth, string existingStructure, string floodplain, string steepSlope, string streamSide)
  {
    SiteAddress = lots;
    Area = ParseDecimal(area);
    Frontage = ParseDecimal(frontage);
    Depth = ParseDecimal(depth);
    ExistingStructure = ParseBool(existingStructure);
    Floodplain = ParseBool(floodplain);
    SteepSlope = ParseBool(steepSlope);
    StreamSide = ParseBool(streamSide);
  }
  
  public SiteModel(List<LotModel> lots)
  {
    SiteAddress = lots;
  }

  public SiteModel(){}

  // Parse all decimals
  public decimal ParseDecimal(string s)
  {
    if(decimal.TryParse(s, out decimal n))
    {
      return n;
    } else
    {
      return 0;
    }
  }
  
  //WRITE METHOD TO PARSE ALL BOOLs
  public bool ParseBool(string s)
  {
    if (s.ToLower() == "y"){
      return true;
    } else 
    {
      return false;
    }
  }
  
  public List<LotModel> SiteAddress{get;set;}
  public decimal Area{get;set;}
  public decimal Frontage{get;set;}
  public decimal Depth{get;set;}
  public bool ExistingStructure{get;set;}
  public bool Floodplain{get;set;}
  public bool SteepSlope{get;set;}
  public bool StreamSide{get;set;}
  public Enums.StructureStatus Structure{get;set;}

}

