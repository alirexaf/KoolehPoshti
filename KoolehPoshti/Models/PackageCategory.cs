using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace KoolehPoshti.Models
{
    public class PackageCategory
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        [JsonIgnore]
        public ICollection<Package> Packages { get; set; }

    }
}
