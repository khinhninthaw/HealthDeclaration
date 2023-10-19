using HealthDeclarationSolution.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HealthDeclarationSolution.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<HealthDeclarationViewModel> HealthDeclarations { get; set; }
    }
}
