using System.Data.Entity;

namespace _494KazantsevAM_Variant_7
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Model> Models { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OptimizationMethod> OptimizationMethods { get; set; }
        public ApplicationContext() : base("DefaultConnection") { }
    }
}
