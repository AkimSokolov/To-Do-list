using System.ComponentModel.DataAnnotations;
using TicketsAPI.Models;
namespace TicketsAPI.Models
{
    public class TicketModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public List<SubtaskModel>? Subtasks { get; set; }
        [Required]
        public string Type { get; set; }
        public int Status { get; set; }
    }
}
