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

  public decimal DemoResGFA{get;set;}
  public decimal DemoCommGFA{get;set;}
  public decimal DemoIndustGFA{get;set;}
  public decimal DemoInstitGFA{get;set;}
}