namespace PatientRegistrator.UI.ViewModel
{
    using System;
    using System.Diagnostics.Eventing.Reader;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Input;

    using Microsoft.Win32;

    using PatientRegistrator.Model;
    using PatientRegistrator.UI.Data;
    using PatientRegistrator.UI.Events;

    using Prism.Commands;
    using Prism.Events;

    public class MainViewModel : ViewModelBase
    {
        private IEventAggregator _eventAggregator;

        private Func<IPatientDetailViewModel> _patientDetailViewModelCreator;

        public MainViewModel(INavigationViewModel navigationViewModel, 
                             Func<IPatientDetailViewModel> patientDetailViewModelCreator,
                             IEventAggregator eventAggregator,
                             IPatientDataService patientPatientDataService)
        {
            this._patientDataService = patientPatientDataService;
            this._patientDetailViewModelCreator = patientDetailViewModelCreator;
            this.NavigationViewModel = navigationViewModel;

            this._eventAggregator = eventAggregator;
            this._eventAggregator.GetEvent<OpenPatientDetailViewEvent>().Subscribe(OnEditPatientDetail);
            this._eventAggregator.GetEvent<AfterPatientSavedEvent>().Subscribe(AfterPatientSaved);
            this.CreateNewPatientCommand = new DelegateCommand(this.OnCreateNewPatientExecute);
            this.ExportPatientsCommand = new DelegateCommand(this.OnExportPatientsExecute);
            this.CancelPatientDetail = new DelegateCommand(this.CancelPatientDetailForm);
        }

        private async void OnExportPatientsExecute()
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == true)
            {
                await this._patientDataService.Export(saveFileDialog.FileName);
            }
        }

        private void CancelPatientDetailForm()
        {
            this.PatientDetailViewModel = null;
        }

        public ICommand CreateNewPatientCommand { get; }
        public ICommand ExportPatientsCommand { get; }
        public ICommand CancelPatientDetail { get; }
        public INavigationViewModel NavigationViewModel { get; }

        private IPatientDetailViewModel _patientDetailViewModel;

        private IPatientDataService _patientDataService;

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

        private void AfterPatientSaved(Patient obj)
        {
            this.PatientDetailViewModel = null;
        }
    }
}