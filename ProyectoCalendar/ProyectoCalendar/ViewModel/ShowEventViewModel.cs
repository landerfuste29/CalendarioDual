using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using MvvmDialogs.ViewModels;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace ProyectoCalendar.ViewModel
{
    class ShowEventViewModel : IUserDialogViewModel
    {

        private PasswordPropertyTextAttribute _passTex;

        public PasswordPropertyTextAttribute PassTex
        {
            get { return _passTex; }
            set { _passTex = value; }
        }
        public event PropertyChangedEventHandler PropertyChanged;


        public virtual bool IsModal { get { return true; } }
        public event EventHandler DialogClosing;
        public ICommand CloseCommand
        {
            get { return new RelayCommand(RequestClose); }
        }


        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public void RequestClose()
        {
            this.DialogClosing(this, null);
        }
        public void Close()
        {
            if (this.DialogClosing != null)
                this.DialogClosing(this, new EventArgs());

        }

    }
}
