namespace CleanArchitecture_Livraria.Infrastructure.Repository
{
    using CleanArchitecture_Livraria.Domain;
    using CleanArchitecture_Livraria.Domain.Autores;
    using CleanArchitecture_Livraria.Domain.CarrinhosCompras;
    using CleanArchitecture_Livraria.Domain.Clientes;
    using CleanArchitecture_Livraria.Domain.Livros;
    using CleanArchitecture_Livraria.Domain.Pedidos;
    using CleanArchitecture_Livraria.Infrastructure.Mappings;
    using Microsoft.EntityFrameworkCore;
    using MongoDB.Bson.Serialization;
    using MongoDB.Driver;

    public class Context : DbContext
    {
        public DbSet<Livro> Livro { get; set; }
        public DbSet<CarrinhoCompras> CarrinhoCommpras { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<CarrinhoComprasLivro> CarrinhoComprasLivro { get; set; }
        public DbSet<LivroAutor> LivroAutor { get; set; }
        public DbSet<PedidosLivro> PedidosLivro { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Utilizando um servidor SQLite local. Aqui poderíamos configurar qualquer outro banco de dados.
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseInMemoryDatabase(databaseName: "test1");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Livro>(new LivroMap().Configure);
            modelBuilder.Entity<CarrinhoCompras>(new CarrinhoComprasMap().Configure);
            modelBuilder.Entity<Pedido>(new PedidoMap().Configure);
            modelBuilder.Entity<Autor>(new AutorMap().Configure);
            modelBuilder.Entity<Cliente>(new ClienteMap().Configure);

            modelBuilder.Entity<CarrinhoComprasLivro>(new CarrinhoComprasLivroMap().Configure);
            modelBuilder.Entity<LivroAutor>(new LivroAutorMap().Configure);
            modelBuilder.Entity<PedidosLivro>(new PedidosLivroMap().Configure);
        }

    }
}
