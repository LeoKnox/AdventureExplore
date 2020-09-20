using Microsoft.EntityFrameworkCore;
using AdventureExplore.Models;

namespace AdventureExplore.Data
{
    public class MvcRoomContext : DbContext
    {
        public MvcRoomContext (DbContextOptions<MvcRoomContext> options) : base(options)
        {
        }

        public DbSet<Room> Room { get; set; }
    }
}