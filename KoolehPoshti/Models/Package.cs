using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace KoolehPoshti.Models
{
    public class Package
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public int? Weight { get; set; }
        public string? Dimension { get; set; }

        [ForeignKey("PackageCategory")]
        public Guid PackageCategoryId { get; set; }
        public PackageCategory Category { get; set; }
        [JsonIgnore]
        [AllowNull]
        public ICollection<PackageImage> Images { get; set; }
        public bool IsVisible { get; set; }
        [JsonIgnore]
        public Request Request { get; set; }
    }
}
