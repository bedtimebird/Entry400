public class BuildingDesignModel
{

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
  public int ResidentialParking{get;set;}
  public int RentalParking{get;set;}
  public int VisitorParking{get;set;}
  public int CommercialParking{get;set;}
  public int IndustrialParking{get;set;}
  public int InstitutionalParking{get;set;}
  public int LoadingBays{get;set;}
  public int BikeResLong{get;set;}
  public int BikeResShort{get;set;}
  public int BikeComLong{get;set;}
  public int BikeComShort{get;set;}
  
}