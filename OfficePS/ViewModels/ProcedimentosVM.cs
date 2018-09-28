using Microsoft.AspNetCore.Mvc.ModelBinding;
using OfficePS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OfficePS.ViewModels
{
    public class ProcedimentosVM
    {

        [BindNever]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100, ErrorMessage = "Esse campo é de no máximo 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public decimal Valor { get; set; }

        public bool Ativo { get; set; }
    }
}
