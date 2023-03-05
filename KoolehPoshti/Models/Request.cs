using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace KoolehPoshti.Models
{
    public class Request
    {
        public Guid Id { get; set; }
        public bool IsAccepted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime TimeCreated { get; set; }
        [ForeignKey("Requester")]
        public Guid RequesterId { get; set; }
        public Requester Requester { get; set; }
        [ForeignKey("Traveler")]
        public Guid TravelerId { get; set; }
        public Traveler Traveler { get; set; }
        [ForeignKey("Package")]
        public Guid PackageId { get; set; }
        public Package Package { get; set; }

    }
}
