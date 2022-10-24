using System.ComponentModel.DataAnnotations.Schema;

namespace InterviewTest.Models
{
    public class ProductList
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string? ProductName { get; set; }
        public string ProductDescription { get; set; }
        public Decimal Quantity { get; set; }
        public Decimal Delieverd { get; set; }
        public Decimal Invoiced { get; set; }
        public Decimal UnitofMeasure { get; set; }
        public Decimal UnitPrice { get; set; }
        public string Taxes { get; set; }
        public Decimal SubTotal { get; set; }

    }
}
