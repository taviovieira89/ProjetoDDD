using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDDD.Domain.Entities
{
    public class Cargo
    {
        public int CargoId { get; set; }

        public string Descricao { get; set; }

        public DateTime DataCadastro { get; set; }

        public int FuncionarioId { get; set; }

        public virtual Funcionario Funcioanrio { get; set; }
    }
}
