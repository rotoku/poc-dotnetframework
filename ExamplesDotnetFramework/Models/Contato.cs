using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamplesDotnetFramework.Models
{
    public class Contato
    {
        [Key]
        public int codigo { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Required(ErrorMessage = "O campo telefone é obrigatório")]
        [Display(Name = "Telefone")]
        public string telefone { get; set; }

        [Required(ErrorMessage = "O campo data de nascimento é obrigatório")]
        [Column("data_nascimento")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime dataNascimento { get; set; }
    }
}