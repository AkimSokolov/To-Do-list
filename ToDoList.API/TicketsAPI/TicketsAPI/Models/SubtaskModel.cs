using System.ComponentModel.DataAnnotations;

namespace TicketsAPI.Models
{
    public class SubtaskModel
    {
        public int Id { get; set; }
        [Required]
        public string Name{ get; set; }
        [Required]
        public string Description { get; set; }
        public int Status { get; set; }
    }
}
