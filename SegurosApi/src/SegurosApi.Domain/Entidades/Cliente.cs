namespace SegurosApi.Domain.Entidades
{
    public class Cliente
    {
        public Guid Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public string Cpf { get; set; } = string.Empty;

        public string Telefone { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public ICollection<Apolice> Apolices { get; set; }
            = new List<Apolice>();
    }
}