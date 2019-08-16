namespace CleanArchitecture_Livraria.Infrastructure.Repository
{
    using CleanArchitecture_Livraria.Domain;
    using CleanArchitecture_Livraria.Domain.Accounts;
    using CleanArchitecture_Livraria.Domain.Autores;
    using CleanArchitecture_Livraria.Domain.CarrinhosCompras;
    using CleanArchitecture_Livraria.Domain.Clientes;
    using CleanArchitecture_Livraria.Domain.Customers;
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
        }


        //private readonly MongoClient mongoClient;
        //private readonly IMongoDatabase database;

        //public Context(string connectionString, string databaseName)
        //{
        //    this.mongoClient = new MongoClient(connectionString);
        //    this.database = mongoClient.GetDatabase(databaseName);
        //    Map();
        //}

        //public IMongoCollection<Customer> Customers
        //{
        //    get
        //    {
        //        return database.GetCollection<Customer>("Customers");
        //    }
        //}

        //public IMongoCollection<Account> Accounts
        //{
        //    get
        //    {
        //        return database.GetCollection<Account>("Accounts");
        //    }
        //}

        //private void Map()
        //{
        //    BsonClassMap.RegisterClassMap<Entity>(cm =>
        //    {
        //        cm.AutoMap();
        //    });

        //    BsonClassMap.RegisterClassMap<Account>(cm =>
        //    {
        //        cm.AutoMap();
        //    });

        //    BsonClassMap.RegisterClassMap<AccountCollection>(cm =>
        //    {
        //        cm.AutoMap();
        //    });

        //    BsonClassMap.RegisterClassMap<Transaction>(cm =>
        //    {
        //        cm.AutoMap();
        //        cm.SetIsRootClass(true);
        //        cm.AddKnownType(typeof(Debit));
        //        cm.AddKnownType(typeof(Credit));
        //    });

        //    BsonClassMap.RegisterClassMap<TransactionCollection>(cm =>
        //    {
        //        cm.AutoMap();
        //    });

        //    BsonClassMap.RegisterClassMap<Customer>(cm =>
        //    {
        //        cm.AutoMap();
        //    });

    }
}
