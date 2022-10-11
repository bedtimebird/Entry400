using System.Collections.Generic;
using System;

public class PermittedUseModel
{
  public string UseName{get;set;}
  public string UseCondition{get;set;}
  public Enums.Use UseType{get;set;}
  public CityModel City{get;set;}
  public DateTime DateModified{get;set;}
  

  public PermittedUseModel(string use, Enums.Use type)
  {
    UseName = use;
    UseType = type;
  }

  public List<PermittedUseModel> CoquitlamUses()
  {
    List<PermittedUseModel> uses = new List<PermittedUseModel>();
    uses.Add(new PermittedUseModel("One-family residential", Enums.Use.Principal));
    uses.Add(new PermittedUseModel("Civic use", Enums.Use.Principal));
    uses.Add(new PermittedUseModel("Agricultural", Enums.Use.Principal));
    uses.Add(new PermittedUseModel("Duplex residential", Enums.Use.Principal));
    uses.Add(new PermittedUseModel("Carriage House", Enums.Use.Principal));
    uses.Add(new PermittedUseModel("Street-Oriented Village Home Residential", Enums.Use.Principal));

    uses.Add(new PermittedUseModel("Boarding", Enums.Use.Accessory));
    uses.Add(new PermittedUseModel("Secondary Suite", Enums.Use.Accessory));
    uses.Add(new PermittedUseModel("Accessory residential", Enums.Use.Accessory));
    uses.Add(new PermittedUseModel("Accessory home occupation", Enums.Use.Accessory));
    uses.Add(new PermittedUseModel("Accessory produce sales", Enums.Use.Accessory));
    
    return uses;
  }
  
}

