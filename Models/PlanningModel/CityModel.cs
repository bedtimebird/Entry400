using System.Collections.Generic;

public class CityModel
{
  public string Name{get;set;}
  public string ShortName{get;set;}
  public string Initials{get;set;}
  public int Population{get;set;}
  public int Area{get;set;}
  public string Website{get;set;}

  public CityModel(string name, string shortName, string intials)
  {
    Name = name;
    ShortName = shortName;
    Initials = intials;
  }

  public CityModel(){}

  public List<CityModel> MetroCities()
  {
    List<CityModel> metroVan = new List<CityModel>();
    metroVan.Add(new CityModel("City of Vancouver", "Vancouver", "CoV"));
    metroVan.Add(new CityModel("Village of Lions Bay", "Lions Bay", "VoLB"));
    metroVan.Add(new CityModel("Bowen Island Municipality", "Bowen Island", "BI"));
    metroVan.Add(new CityModel("The Corporation of the District of West Vancouver", "West Vancouver", "DoWV"));
    metroVan.Add(new CityModel("The Corporation of the District of North Vancouver", "District of North Vancouver", "DNV"));
    metroVan.Add(new CityModel("The Corporation of the City of North Vancouver", "North Vancouver", "CNV"));
    metroVan.Add(new CityModel("Village of Belcarra", "Belcarra", "VoB"));
    metroVan.Add(new CityModel("Metro Vancouver Electoral Area A", "Electoral Area A", "EAA"));
    metroVan.Add(new CityModel("Village of Anmore", "Anmore", "VoA"));
    metroVan.Add(new CityModel("City of Port Moody", "Port Moody", "CoPM"));
    metroVan.Add(new CityModel("Village of Belcarra", "Belcarra", "VoB"));
    metroVan.Add(new CityModel("The City of New Westminster", "New Westminster", "CoNW"));
    metroVan.Add(new CityModel("City of Burnaby", "Burnaby", "CoB"));
    metroVan.Add(new CityModel("City of Richmond", "Richmond", "CoR"));
    metroVan.Add(new CityModel("City of Delta", "Delta", "CoD"));
    metroVan.Add(new CityModel("City of Surrey", "Surrey", "CoS"));
    metroVan.Add(new CityModel("The Corporation of the City of White Rock", "White Rock", "CoWR"));
    metroVan.Add(new CityModel("City of Langley", "City of Langley", "CoL"));
    metroVan.Add(new CityModel("The Corporation of the Township of Langley", "Township of Langley", "ToL"));
    metroVan.Add(new CityModel("City of Maple Ridge", "Maple Ridge", "CoMR"));
    metroVan.Add(new CityModel("City of Pitt Meadows", "Pitt Meadows", "CoPM"));
    metroVan.Add(new CityModel("The Corporation of the City of Port Coquitlam", "Port Coquitlam", "PoCo"));
    metroVan.Add(new CityModel("City of Coquitlam", "Coquitlam", "CoC"));
    
    return metroVan;
  }
  
}