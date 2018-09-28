using Microsoft.AspNetCore.Mvc.ModelBinding;
using OfficePS.Models;
using OfficePS.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OfficePS.ViewModels
{
    public class ClienteVM : IValidatableObject
    {

        public ClienteVM() { }

        public int ClientesId { get; set; }

        [Required]
        [StringLength(100,ErrorMessage ="O nome deve ter entre 5 e 100 caracteres",MinimumLength =5)]
        public string Nome { get; set; }
        [Required]
        [DataType(DataType.EmailAddress,ErrorMessage ="E-mail inválido")]
        public string Email { get; set; }
        [Required]
        public string Cpf { get; set; }

        public string Rg { get; set; }

        public string Telefone { get; set; }

        public string TelefoneCelular { get; set; }
        [Required]
        [DataType(DataType.Date,ErrorMessage ="Data de Nascimento inválida")]
        [DateValidation(ErrorMessage ="Data de nascimento Inválida")]
        public DateTime DtNascimento { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Data de Cadastro inválida")]
        public DateTime DtCadastro { get; set; }

        public bool Ativo { get; set; }

        public string FotoPerfil { get; set; }
        [Required]
        public string Sexo { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> listResult = new List<ValidationResult>();
            if (!Ativo) {
                listResult.Add(new ValidationResult("Para um novo cadastro, o status deve estar ativo"));
            }

            return listResult;
        }
    }
}
