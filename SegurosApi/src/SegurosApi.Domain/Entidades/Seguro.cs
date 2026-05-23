namespace SegurosApi.Domain.Entidades{
    public class Seguro
    {
        public Guid Id { get; set; }

        public string TipoSeguro { get; set; } = string.Empty;

        public decimal ValorMensal { get; set; }

        public string Cobertura { get; set; } = string.Empty;

        public ICollection<Apolice> Apolices { get; set; }
            = new List<Apolice>();
    }
}