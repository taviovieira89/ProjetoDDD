using ProjetoDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDDD.Infra.Data.EntityConfig
{
    public class CargoConfig : EntityTypeConfiguration<Cargo>
    {
        public CargoConfig()
        {
            HasKey(x => x.CargoId);

            Property(x => x.Descricao).IsRequired().HasMaxLength(150);

            HasRequired(p => p.Funcioanrio).WithMany().HasForeignKey(p => p.FuncionarioId);

        }

    }
}
