using System.ComponentModel.DataAnnotations;

namespace test.Models
{
    public class item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal price { get; set; }
        
        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}
