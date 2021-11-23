namespace PatientRegistrator.UI.ViewModel
{
    using System;
    using System.ComponentModel;
    using System.Windows.Input;

    public class DelegateCommand : ICommand 
    {
        private Action _execute;

        private Func<bool> _canExecute;

        public DelegateCommand(Action execute, Func<bool> canExecute = null)
        {
            this._execute = execute ?? throw new ArgumentNullException(nameof(execute));
            this._canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return this._canExecute == null ? true : this._canExecute();
        }

        public void Execute(object parameter)
        {
            this._execute();
        }

        public event EventHandler CanExecuteChanged;

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}