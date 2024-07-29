using System.ComponentModel.DataAnnotations.Schema;

namespace DemoSPS.Entities
{
    [Table("Products")]
    public class Product
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Quantity { get; set; } 
        public bool IsActive { get; set; }
    }
}
