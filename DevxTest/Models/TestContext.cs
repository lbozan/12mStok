using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DevxTest.Models.Mapping;

namespace DevxTest.Models
{
    public partial class TestContext : DbContext
    {
        static TestContext()
        {
            Database.SetInitializer<TestContext>(null);
        }

        public TestContext()
            : base("Name=TestContext")
        {
        }

        public DbSet<STI> STIs { get; set; }
        public DbSet<STK> STKs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new STIMap());
            modelBuilder.Configurations.Add(new STKMap());
        }
    }
}
