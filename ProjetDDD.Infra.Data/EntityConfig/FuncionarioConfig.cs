using ProjetoDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetDDD.Infra.Data.EntityConfig
{
    public class FuncionarioConfig : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioConfig()
        {
            HasKey(x => x.FuncionarioId);

            Property(x => x.Nome).IsRequired().HasMaxLength(150);

        }
    }
}
