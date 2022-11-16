using System;
using System.Collections.Generic;
using System.Linq;

// Class to hold the high level development details
// also holds a object that contains various development options (DevOpt) where site configurations
// or other site can be easily compared against each other
// TODO - future-future state: create templates for standard development types (6 storey strata / 8 storey rental ect...)

public class DevAppModel
{
  public DevAppModel(string name)
  {
    ProjName = name;
    CompleteApp = false;
  }
  public DevAppModel(){}
  
  public string ProjName{get;set;}
  public string ProjDesc{get;set;}
  public bool CompleteApp {get;set;}
  
  public SiteModel DevSite{get;set;}
  public ApplicantModel Applicant{get;set;}
  public DevAppDetailsModel DevDetails{get;set;}

  public List<DevVariantModel> DevVariant {get;set;}

}

