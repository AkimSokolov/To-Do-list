#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TicketsAPI.Models;

namespace TicketsAPI.Data
{
    public class TicketsAPIContext : DbContext
    {
        public TicketsAPIContext (DbContextOptions<TicketsAPIContext> options)
            : base(options)
        {
            Database.EnsureCreated();           
        }

        public DbSet<TicketsAPI.Models.TicketModel> TicketModel { get; set; }

        public DbSet<TicketsAPI.Models.SubtaskModel> SubtaskModel { get; set; }
    }
}
