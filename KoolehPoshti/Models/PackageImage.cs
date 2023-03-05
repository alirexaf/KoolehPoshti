using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace KoolehPoshti.Models
{
    public class PackageImage
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        [AllowNull]
        public byte[] Data { get; set; }
        [ForeignKey("Package")]
        public Guid PackageId { get; set; }
        public Package Package { get; set; }
    }
}
