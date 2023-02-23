using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KoolehPoshti.Models
{
    public class Package
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public List<PackageImage> Images { get; set; }
        public int Weight { get; set; }
        public string Dimension { get; set; }
        [Required]
        public PackageCategory Category { get; set; }
        [Required]
        public bool IsVisible { get; set; }


    }
}
