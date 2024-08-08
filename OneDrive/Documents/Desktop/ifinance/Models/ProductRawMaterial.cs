namespace S5G11_PVFAPP.Models
{
    public class ProductRawMaterial
    {
        public long ProductId { get; set; }
        public int MaterialID { get; set; }
        public float RequiredQuantity { get; set; }

        public Product Product { get; set; }
        public RawMaterial RawMaterial { get; set; }
    }
}
