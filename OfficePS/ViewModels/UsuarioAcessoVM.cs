using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OfficePS.ViewModels
{
    public class UsuarioAcessoVM
    {
        [Required]
        [Display(Name ="Nome Usuario")]
        public string NomeUsuario { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
