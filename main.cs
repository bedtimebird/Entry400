using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
      
      // Test ZoneModel
      ZoneModel bob = new ZoneModel();
      List<ZoneModel> master = new List<ZoneModel>();
      master = bob.ReturnZones();
      foreach(var zone in master)
      {
        Console.WriteLine(zone.Zone + " " + zone.ProjectClass + " " + zone.City);
      }

      // Test ContactModel
      ContactModel tempContact = new ContactModel();
      tempContact = tempContact.TempContactData();
      Console.WriteLine(tempContact.FirstName);

      // Test LotModel
      LotModel tempLot = new LotModel();
      tempLot = tempLot.TempLotData();
      Console.WriteLine(tempLot.Address);

      // Test SiteModel
      List<LotModel> devLots = new List<LotModel>();
      devLots.Add(tempLot);
      SiteModel tempSite = new SiteModel(devLots);
      foreach(var item in tempSite.SiteAddress)
      {
        Console.WriteLine(item.Address);
      }

      // Test DevelopmentApplicationModel
      DevelopmentApplicationModel development = new DevelopmentApplicationModel(tempSite, tempContact, "Raven Greens");
      Console.WriteLine(development.ProjectName);

      // Test CityModel
      CityModel tempCity = new CityModel();
      List<CityModel> cities = new List<CityModel>();
      cities = tempCity.MetroCities();
      foreach(var item in cities)
        {
          Console.WriteLine($"City (long): {item.Name}");
          Console.WriteLine($"City (short): {item.ShortName}");
          Console.WriteLine("--------------");
        }
      
        
    }
}