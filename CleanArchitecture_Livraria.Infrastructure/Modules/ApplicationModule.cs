namespace CleanArchitecture_Livraria.Infrastructure.Modules
{
    using Autofac;
    using CleanArchitecture_Livraria.Application;

    public class ApplicationModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //
            // Register all Types in CleanArchitecture_Livraria.Application
            //
            builder.RegisterAssemblyTypes(typeof(IOutputConverter).Assembly)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
