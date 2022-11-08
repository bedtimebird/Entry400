using System;
using System.Collections.Generic;
using System.Linq;

// Class to hold the high level development details - each Ciy extends from this class
// also holds a object that contains various development options (DevOpt) where site configurations
// or other site can be easily compared against each other
// TODO - future state: create templates for standard development types (6 storey strata / 8 storey rental ect...)


public class DevAppModel
{

  public DevAppModel(){}
  
  public string ProjName{get;set;}
  public string ProjDesc{get;set;}
  public SiteModel DevSite{get;set;}
  public ApplicantModel Applicant{get;set;}
  public ExDetailsModel ExDev{get;set;}
  public PropDetailsModel PropDev{get;set;}
  public bool CompApp {get;set;}
  
  public List<DevAppDetailsModel> DevOpt {get;set;}

}

