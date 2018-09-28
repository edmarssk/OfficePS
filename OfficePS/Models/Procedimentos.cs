namespace OfficePS.Models
{
    public class Procedimentos
    {
        public Procedimentos() { }

        public int ProcedimentosId { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public bool Ativo { get; set; }

    }
}
