using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class EventModels
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "An event name is absolutely required.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 characters.")]
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "You must specify a location.")]
        public string Location { get; set; } = string.Empty;
    }
}