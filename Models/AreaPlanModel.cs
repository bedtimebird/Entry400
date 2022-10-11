using System;
using System.Collections.Generic;

// Coquitlam - CWOCP (Citywide Official Community Plan)

public class AreaPlanModel
{
  public AreaPlanModel(string name, string type, CityModel city)
  {
    Name = name;
    PlanType = type;
    City = city;
  }

  public AreaPlanModel(){}
  
  public string Name{get;set;}
  public string PlanType{get;set;}
  public CityModel City{get;set;}
  public string Website{get;set;}
  public DateTime DateModified{get;set;}
  public List<AreaPlanModel> PreviousVersions{get;set;}

  
}