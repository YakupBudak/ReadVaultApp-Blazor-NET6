using Microsoft.EntityFrameworkCore;
using ReadVaultApp.Models;

namespace ReadVaultApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Document> Documents { get; set; }

    
    }
}