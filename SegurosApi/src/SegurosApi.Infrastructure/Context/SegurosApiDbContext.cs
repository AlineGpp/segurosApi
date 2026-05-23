using Microsoft.EntityFrameworkCore;
using SegurosApi.Domain.Entidades;


namespace SegurosApi.Infrastructure.Context;

public class SegurosApiDbContext : DbContext
{
    public SegurosApiDbContext(
        DbContextOptions<SegurosApiDbContext> options)
        : base(options)
    {
    }

    public DbSet<Cliente> Clientes { get; set; }

    public DbSet<Seguro> Seguros { get; set; }

    public DbSet<Apolice> Apolices { get; set; }

    protected override void OnModelCreating(
        ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}