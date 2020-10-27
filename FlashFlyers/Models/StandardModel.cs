using System;
using Microsoft.EntityFrameworkCore;

namespace FlashFlyers.Models
{
    public class StandardModel : DbContext
    {
        public StandardModel(DbContextOptions<StandardModel> options) : base(options) { }
        public DbSet<EventModel> Events { get; set; }
    }
}