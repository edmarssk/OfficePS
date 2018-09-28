using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficePS.Models
{
    public class Clientes
    {
        public Clientes() { }

        public int ClientesId { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Cpf { get; set; }

        public string Rg { get; set; }

        public string Telefone { get; set; }

        public string TelefoneCelular { get; set; }

        public DateTime DtNascimento { get; set; }

        public DateTime DtCadastro { get; set; }

        public bool Ativo { get; set; }

        public string FotoPerfil { get; set; }

        public string Sexo { get; set; }
    }
}
