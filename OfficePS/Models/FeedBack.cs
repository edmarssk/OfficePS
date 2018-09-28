using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficePS.Models
{
    public class FeedBack
    {

        public FeedBack() { }

        public int FeedBackId { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string Email { get; set; }

        public bool Ativo { get; set; }

        public DateTime Data { get; set; }

        public int ClientesId { get; set; }

        public virtual Clientes Cliente { get; set; }
    }
}
