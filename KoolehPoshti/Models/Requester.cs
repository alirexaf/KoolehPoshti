using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace KoolehPoshti.Models
{
    public class Requester
    {
        public Guid Id { get; set; }
        public string Name { get; set;}
        public string PhoneNumber { get; set;}
        public string Email { get; set;}
        public string? TelegramId { get; set; }
        public string? WhatsAppNumnber { get; set; }
        [JsonIgnore]
        public ICollection<Request> Requests { get; set; }
    }
}
