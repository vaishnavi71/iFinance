using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S5G11_PVFAPP.Models
{
    [Table("sales_person")]
    public class SalesPerson
    {
        [Key]
        public int SalesPersonID { get; set; }

        public string SalesPersonName { get; set; }

        public string SalesPersonTelephone { get; set; }

        public string? SalesPersonFax { get; set; }

        public ICollection<SalesTerritory> Territories { get; set; }
    }
}
