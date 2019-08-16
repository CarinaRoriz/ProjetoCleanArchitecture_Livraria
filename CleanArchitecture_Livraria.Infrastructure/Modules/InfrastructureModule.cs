namespace CleanArchitecture_Livraria.Infrastructure.Modules
{
    using Autofac;
    using CleanArchitecture_Livraria.Infrastructure.Repository;
    using CleanArchitecture_Livraria.Infrastructure.Mappings;
    using CleanArchitecture_Livraria.Application;
    using CleanArchitecture_Livraria.Application.UseCases.CadastrarLivro;

    public class InfrastructureModule : Autofac.Module
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Context>()
                .As<Context>()
                .SingleInstance();

            ////
            //// Register all Types in CleanArchitecture_Livraria.Infrastructure
            ////
            builder.RegisterAssemblyTypes(typeof(OutputConverter).Assembly)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            

        }
    }
}
