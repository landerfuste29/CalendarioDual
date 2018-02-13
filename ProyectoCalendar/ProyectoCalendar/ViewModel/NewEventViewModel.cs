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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs; 
using System.Windows;
using System.Collections.ObjectModel;
using MahApps.Metro.Behaviours;



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


        private Evento _newEvento;

        public Evento NewEvento
        {
            get
            {
                return _newEvento;
            }
            set
            {
                _newEvento = value;
                NotifyPropertyChanged();
            }
        }
        //texEve
        private String _texEve;

        public String TexEve
        {
            get
            {
                return _texEve;
            }
            set
            {
                _texEve = value;
            }
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
                _selectedEvento = value;
                FillTipoEvID();
                NotifyPropertyChanged();
            }
        }

        public ICommand AddEventCommand
        {
            get { return new RelayCommand(AddEvent); }
        }

        private DateTime _chosenDate = new DateTime();

        public DateTime ChosenDate
        {
            get { return _chosenDate; }
            set
            {
                _chosenDate = value;
            }
        }
        private void FillTipoEvID()
        {
            
            NewEvento.TipoEvento_idTipoEvento = SelectedEvento.idTipoEvento;
        }


        public void AddEvent()
        {
            

            if (this.OnAdd != null)
                this.OnAdd(this);
            else
                Close();

        }
        public Action<NewEventViewModel> OnAdd { get; set; }
        public void Close()
        {
            
            if (this.DialogClosing != null)
                this.DialogClosing(this, new EventArgs());

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




        private void FillHora()
        {

            TimeSpan hora = new TimeSpan(SelectedCboxHora, SelectedCboxMin, 0);
            NewEvento.fecha = ChosenDate + hora;
        }

        private void FillMin()
        {

            TimeSpan hora = new TimeSpan(SelectedCboxHora, SelectedCboxMin, 0);
            NewEvento.fecha = ChosenDate + hora;
        }




        private List<int> _cboxHora;
        private int _selectedCboxHora;
        public List<int> CboxHora
        {
            get
            {
                return _cboxHora;
            }
            set
            {
                _cboxHora = value;
                NotifyPropertyChanged();
            }
        }
        public int SelectedCboxHora
        {
            get
            {
                return _selectedCboxHora;
            }
            set
            {
                _selectedCboxHora = value;
                FillHora();
                NotifyPropertyChanged();
            }
        }


        

        private List<int> _cboxMin;
        private int _selectedCboxMin;
        public List<int> CboxMin
        {
            get
            {
                return _cboxMin;
            }
            set
            {
                _cboxMin = value;
                NotifyPropertyChanged();
            }
        }
        public int SelectedCboxMin
        {
            get
            {
                return _selectedCboxMin;
            }
            set
            {
                _selectedCboxMin = value;
                FillMin();
                NotifyPropertyChanged();
            }
        }
        

    }
}
