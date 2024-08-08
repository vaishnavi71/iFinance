namespace S5G11_PVFAPP.Models
{
    public class VendorRawMaterial
    {
        public long VendorId { get; set; }
        public int MaterialID { get; set; }
        public float SupplyUnitPrice { get; set; }

        public Vendor Vendor { get; set; }
        public RawMaterial RawMaterial { get; set; }
    }
}
