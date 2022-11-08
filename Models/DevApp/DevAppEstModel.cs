using System;
using System.Collections.Generic;
using System.Linq;

// Class to hold different variations for the way a development could progress
public class DevAppEstModel
{
  public DevAppEstModel(string name)
  {
    EstimateName = name;
  }
  
  public string EstimateName{get;set;}
  public int DisplayOrder{get;set;}
  public SiteModel DevSite{get;set;}
  public DevAppDetailsModel DevDetails{get;set;}
  
}