using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace KoolehPoshti.Models
{
    public class Traveler
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime TravelDate { get; set; }
        public string PhoneNumber { get; set; }
        public string? TelegramId { get; set; }
        public string? WhatsAppNumnber { get; set; }
        [JsonIgnore]
        public ICollection<Request> Requests { get; set; }




    }
}
