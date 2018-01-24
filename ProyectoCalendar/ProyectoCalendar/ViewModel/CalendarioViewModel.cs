﻿using GalaSoft.MvvmLight.Command;
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
    class CalendarioViewModel : IUserDialogViewModel
    {
        private ObservableCollection<IDialogViewModel> _Dialogs = new ObservableCollection<IDialogViewModel>();
        public event PropertyChangedEventHandler PropertyChanged;
        public System.Collections.ObjectModel.ObservableCollection<IDialogViewModel> Dialogs { get { return _Dialogs; } }

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

        //  public class GoToAddEvent
        public void calendarioView()
        {
            this.Dialogs.Add(new NewEventViewModel()
            {
                //  Title = "Esto es una mierda"

            });
        }

        public ICommand GoToAddEvent
        {
            get { return new RelayCommand(calendarioView); }
        }

    }
}