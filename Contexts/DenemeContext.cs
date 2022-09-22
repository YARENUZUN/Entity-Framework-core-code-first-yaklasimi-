using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using örnek.Entities;
using System.Data.Entity;
using Database = System.Data.Entity.Database;
using DbContext = System.Data.Entity.DbContext;

namespace örnek.Contexts
{
    public class DenemeContext : DbContext
    {
        static DenemeContext()
        {
            Database.SetInitializer<DenemeContext>(null);
        }

        

        public System.Data.Entity.DbSet<Urunler>? Urunlers { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UrunlerTable());
        }
    }
}
