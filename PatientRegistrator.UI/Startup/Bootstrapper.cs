namespace PatientRegistrator.UI.Startup
{
    using System.Runtime.InteropServices.ComTypes;

    using Autofac;

    using PatientRegistrator.DataAccess;
    using PatientRegistrator.UI.Data;
    using PatientRegistrator.UI.ViewModel;

    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<CoreContext>().AsSelf();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<PatientDataService>().As<IPatientDataService>();

            return builder.Build();
        }

    }
}