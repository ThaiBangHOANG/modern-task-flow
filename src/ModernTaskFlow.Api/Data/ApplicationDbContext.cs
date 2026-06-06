using Microsoft.EntityFrameworkCore;
using ModernTaskFlow.Api.Entities;

namespace ModernTaskFlow.Api.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<WorkItem> WorkItems { get; set; }
    
}