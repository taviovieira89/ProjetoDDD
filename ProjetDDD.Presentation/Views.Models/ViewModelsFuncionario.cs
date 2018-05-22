using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetDDD.Presentation.Views.Models
{
    public class ViewModelsFuncionario
    {
        [Key]
        public int FuncionarioId { get; set; }

        [Required(ErrorMessage = "Preencha o Nome")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        public string Nome { get; set; }

        
        public DateTime DataNasc { get; set; }


        [DisplayName("Ativo?")]
        public bool Situacao { get; set; }

        public virtual IEnumerable<ViewModelsCargo> Cargo { get; set; }

    }
}