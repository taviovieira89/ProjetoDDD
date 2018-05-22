using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetDDD.Presentation.Views.Models
{
    public class ViewModelsCargo
    {
        [Key]
        public int CargoId { get; set; }

        [Required(ErrorMessage = "Preencha a descrição.")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres.")]
        public string Descricao { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public int FuncionarioId { get; set; }

        public virtual ViewModelsFuncionario Funcioanrio { get; set; }
    }
}