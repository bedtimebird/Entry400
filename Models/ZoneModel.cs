using System.Collections.Generic;

public class ZoneModel
{
  
  public string Zone{get;set;}
  public string ProjectClass{get;set;}
  public CityModel City{get;set;}
  public List<PermittedUseModel> Uses{get;set;}

  public ZoneModel(string zone, string classification)
  {
    Zone = zone;
    ProjectClass = classification;
  }

  public ZoneModel()
  {
    
  }

  public List<ZoneModel> CoquitlamZones()
  {
    List<ZoneModel> allZones = new List<ZoneModel>();
    allZones.Add(new ZoneModel("A", "Standard"));
    allZones.Add(new ZoneModel("RS", "Standard"));
    allZones.Add(new ZoneModel("RT", "Standard"));
    allZones.Add(new ZoneModel("RTM", "Standard"));
    allZones.Add(new ZoneModel("RM-1", "Standard"));
    allZones.Add(new ZoneModel("RM-2", "Standard"));
    allZones.Add(new ZoneModel("RM-3", "Standard"));
    allZones.Add(new ZoneModel("C-1", "Standard"));
    allZones.Add(new ZoneModel("C-2", "Standard"));
    allZones.Add(new ZoneModel("C-3", "Standard"));
    allZones.Add(new ZoneModel("CS", "Standard"));
    allZones.Add(new ZoneModel("SS", "Standard"));
    allZones.Add(new ZoneModel("M", "Standard"));
    allZones.Add(new ZoneModel("B", "Standard"));
    allZones.Add(new ZoneModel("P", "Standard"));
    allZones.Add(new ZoneModel("CD", "Standard"));

    allZones.Add(new ZoneModel("RM-4", "Major"));
    allZones.Add(new ZoneModel("RM-5", "Major"));
    allZones.Add(new ZoneModel("RM-6", "Major"));
    allZones.Add(new ZoneModel("C-5", "Major"));
    allZones.Add(new ZoneModel("C-6", "Major"));
    allZones.Add(new ZoneModel("C-7", "Major"));
    allZones.Add(new ZoneModel("CD", "Major"));
    
    return allZones;
  } 
}