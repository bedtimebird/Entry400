public class BuildingDesignModel
{

  // TODO: (Nov 9 22) May require breaking this down in parent child relationship
  // This should also relate at some point into the future towards the Planning requirements?
  // What happens if new bike storage type is created or elec bike storage is created?
  // Future issue
  
  public BuildingDesignModel(decimal lot, int parkingTotal)
  {
    LotCoverage = lot;
    TotalVehicleParking = parkingTotal;
  }
  
  public BuildingDesignModel(){}  
  
  public decimal LotCoverage{get;set;} //percentage
  // ISSUE - AmenityIndoor + Outdoor not required for REQUIRED
  public decimal AmenityIndoor{get;set;}
  public decimal AmenityOutdoor{get;set;}
  public decimal AmenitySpace{get;set;}
  
  public int TotalVehicleParking{get;set;}
  public int ResParking{get;set;}
  public int RentalParking{get;set;}
  public int VisitorParking{get;set;}
  public int CommParking{get;set;}
  public int IndustParking{get;set;}
  public int InstitParking{get;set;}
  public int LoadingBays{get;set;}
  public int BikeResLong{get;set;}
  public int BikeResShort{get;set;}
  public int BikeCommLong{get;set;}
  public int BikeCommShort{get;set;}
  
}