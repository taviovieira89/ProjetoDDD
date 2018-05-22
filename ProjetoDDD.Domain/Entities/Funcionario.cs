using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDDD.Domain.Entities
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
        public bool Situacao { get; set; }
        public virtual IEnumerable<Cargo> Cargo { get; set; }

        public bool MaiorIdade(Funcionario oFuncioanrio)
        {
            return DateTime.Now.Year - oFuncioanrio.DataNasc.Year >= 18;
        }
    }
}
