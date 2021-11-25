namespace PatientRegistrator.UI.ViewModel
{
    using System;
    using System.Diagnostics.Eventing.Reader;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Input;

    using PatientRegistrator.UI.Events;

    using Prism.Commands;
    using Prism.Events;

    public class MainViewModel : ViewModelBase
    {
        private IEventAggregator _eventAggregator;

        private Func<IPatientDetailViewModel> _patientDetailViewModelCreator;

        public MainViewModel(INavigationViewModel navigationViewModel, 
                             Func<IPatientDetailViewModel> patientDetailViewModelCreator,
                             IEventAggregator eventAggregator)
        {
            this._patientDetailViewModelCreator = patientDetailViewModelCreator;
            this.NavigationViewModel = navigationViewModel;

            this._eventAggregator = eventAggregator;
            this._eventAggregator.GetEvent<OpenPatientDetailViewEvent>().Subscribe(OnEditPatientDetail);

            this.CreateNewPatientCommand = new DelegateCommand(this.OnCreateNewPatientExecute);
            this.CancelPatientDetail = new DelegateCommand(this.CancelPatientDetailForm);
        }



        private void CancelPatientDetailForm()
        {
            this.PatientDetailViewModel = null;
        }

        public ICommand CreateNewPatientCommand { get; }
        public ICommand CancelPatientDetail { get; }
        public INavigationViewModel NavigationViewModel { get; }

        private IPatientDetailViewModel _patientDetailViewModel;

        public IPatientDetailViewModel PatientDetailViewModel
        {
            get => this._patientDetailViewModel;
            private set
            {
                this._patientDetailViewModel = value;
                this.OnPropertyChanged();
                OnPropertyChanged(nameof(IsFormVisible));
            }
        }

        public Visibility IsFormVisible
        {
            get
            {
                if (this.PatientDetailViewModel != null)
                {
                    return Visibility.Visible;
                }

                return Visibility.Collapsed;
            }
        }

        public async Task LoadAsync()
        {
            await this.NavigationViewModel.LoadAsync();
        }

        private async void OnEditPatientDetail(int? patientId)
        {
            this.PatientDetailViewModel = this._patientDetailViewModelCreator();
            await this.PatientDetailViewModel.Init(patientId);
        }

        private void OnCreateNewPatientExecute()
        {
            this.OnEditPatientDetail(null);
        }
    }
}