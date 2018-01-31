using GalaSoft.MvvmLight.Command;
using MvvmDialogs.ViewModels;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ProyectoCalendar.Model;
using System.Windows.Input;

namespace ProyectoCalendar.ViewModel
{

    class RegisterViewModel : IUserDialogViewModel
    {
        private PasswordPropertyTextAttribute _passTex;

        public PasswordPropertyTextAttribute PassTex
        {
            get { return _passTex; }
            set { _passTex = value; }
        }
        public event PropertyChangedEventHandler PropertyChanged;


        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }


        private Entidad _entidadToAdd;

        private bool _textEnabled;
        public bool TextEnabled
        {
            get { return _textEnabled; }
            set { _textEnabled = value; }
        }

        private Usuario _usrToRegist;
        public Usuario UsrToRegist
        {
            get { return (_usrToRegist); }
            set { _usrToRegist = value; NotifyPropertyChanged(); }
        }

        public Entidad EntidadToAdd
        {
            get { return (_entidadToAdd); }
            set { _entidadToAdd = value; NotifyPropertyChanged(); }
        }


        public ICommand AddConCommand
        {
            get { return new RelayCommand(AddCon); }
        }

        public void AddCon()
        {
            if (this.OnAdd != null)
                this.OnAdd(this);
            else
                Close();

        }

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

        public Action<RegisterViewModel> OnAdd { get; set; }


        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


    }
}
