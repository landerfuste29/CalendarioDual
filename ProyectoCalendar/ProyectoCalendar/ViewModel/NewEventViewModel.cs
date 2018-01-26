using GalaSoft.MvvmLight.Command;
using MvvmDialogs.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ProyectoCalendar.Model;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace ProyectoCalendar.ViewModel
{
    class NewEventViewModel : IUserDialogViewModel
    {
        private Usuario _usrRegist;
        public Usuario UsrRegist
        {
            get { return (_usrRegist); }
            set { _usrRegist = value; NotifyPropertyChanged(); }
        }

        

        private List<TipoEvento> _tipEventos;
        private TipoEvento _selectedEvento;

        public List<TipoEvento> TipEventos
        {
            get
            {
                return _tipEventos;
            }
            set
            {
                _tipEventos = value;
                NotifyPropertyChanged();
            }
        }

        public TipoEvento SelectedEvento
        {
            get
            {
                return _selectedEvento;
            }
            set
            {
                _selectedEvento = value; NotifyPropertyChanged();
            }
        }



        public virtual bool IsModal { get { return true; } }
        public event EventHandler DialogClosing;

        public void RequestClose()
        {
            this.DialogClosing(this, null);
        }

        public ICommand CloseCommand
        {
            get { return new RelayCommand(RequestClose); }
        }
        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
