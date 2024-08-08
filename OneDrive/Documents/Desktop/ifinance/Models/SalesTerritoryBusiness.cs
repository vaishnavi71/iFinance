namespace S5G11_PVFAPP.Models
{
    public class SalesTerritoryBusiness
    {
        public long? TerritoryID { get; set; }
        public SalesTerritory Territory { get; set; }

        public long? BusinessID { get; set; }
        public DoesBusinessIn Business { get; set; }
    }
}
