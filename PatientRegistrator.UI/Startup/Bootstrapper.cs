namespace PatientRegistrator.UI.Startup
{
    using Autofac;

    using PatientRegistrator.DataAccess;
    using PatientRegistrator.UI.Data;
    using PatientRegistrator.UI.ViewModel;

    using Prism.Events;

    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();
            builder.RegisterType<CoreContext>().AsSelf();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<PatientDetailViewModel>().As<IPatientDetailViewModel>();
            builder.RegisterType<NavigationViewModel>().As<INavigationViewModel>();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<PatientDataService>().As<IPatientDataService>();

            return builder.Build();
        }
    }
}