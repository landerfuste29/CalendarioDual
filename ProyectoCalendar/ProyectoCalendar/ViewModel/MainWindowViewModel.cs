using GalaSoft.MvvmLight.Command;
using MvvmDialogs.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProyectoCalendar.ViewModel
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<IDialogViewModel> _Dialogs = new ObservableCollection<IDialogViewModel>();

        public event PropertyChangedEventHandler PropertyChanged;
        public System.Collections.ObjectModel.ObservableCollection<IDialogViewModel> Dialogs { get { return _Dialogs; } }
        public void registreView()
        {
            this.Dialogs.Add(new RegisterViewModel()
            {
                //  Title = "Esto es una mierda"

            });
        }
        public void CalendarioView()
        {
            this.Dialogs.Add(new CalendarioViewModel()
            {
                //  Title = "Esto es una mierda"

            });
        }

        public ICommand GoToRegister
        {
            get { return new RelayCommand(registreView); }
        }
        public ICommand GoToCalendario
        {
            get { return new RelayCommand(CalendarioView); }
        }
    }
}
