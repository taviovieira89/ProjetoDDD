using ProjetDDD.Infra.Data.EntityConfig;
using ProjetoDDD.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProjetDDD.Infra.Data.Contexto
{
    public class DbContexto : DbContext
    {
        public DbContexto()
            : base("ProjetoDDD")
        {

        }

        public DbSet<Funcionario> Funcionarios { get; set; }

        public DbSet<Cargo> Cargos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>().Where(p => p.Name == p.ReflectedType.Name + "Id").Configure(x => x.IsKey());

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new FuncionarioConfig());

            modelBuilder.Configurations.Add(new CargoConfig());
        }

    }
}
