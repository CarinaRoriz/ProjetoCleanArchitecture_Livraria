namespace CleanArchitecture_Livraria.Infrastructure.Modules
{
    using Autofac;
    using CleanArchitecture_Livraria.Application;
    using CleanArchitecture_Livraria.Application.UseCases.CadastrarLivro;
    using System.Reflection;

    public class WebApiModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //
            // Register all Types in CleanArchitecture_Livraria.WebApi
            //
            builder.RegisterAssemblyTypes(Assembly.GetEntryAssembly())
                .AsClosedTypesOf(typeof(IOutputBoundary<>))
                .InstancePerLifetimeScope();

           // builder.RegisterType<LivroOutput>().As(typeof(IOutputBoundary<>));

        }
    }
}
