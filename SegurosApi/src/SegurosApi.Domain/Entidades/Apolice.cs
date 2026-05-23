

namespace  SegurosApi.Domain.Entidades
{

    public class Apolice
    {
        public Guid Id { get; set; }

        public Guid ClienteId { get; set; }

        public Cliente Cliente { get; set; }

        public Guid SeguroId { get; set; }

        public Seguro Seguro { get; set; }

        public DateTime DataCriacao { get; set; }

        public string Status { get; set; } = "Ativa";
    }
}