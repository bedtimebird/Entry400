using System;
using System.Collections.Generic;

// Pull land uses + CWOCP + zoning from SiteModel
// How does that connection work? 

public class ExZoningModel : DevZoningModel
{

  public ExZoningModel(decimal tGFA)
  {
  TotalGFA = tGFA;
  }

  public decimal DemoResidentialGFA{get;set;}
  public decimal DemoCommercialGFA{get;set;}
  public decimal DemoIndustrialGFA{get;set;}
  public decimal DemoInstitutionalGFA{get;set;}
}