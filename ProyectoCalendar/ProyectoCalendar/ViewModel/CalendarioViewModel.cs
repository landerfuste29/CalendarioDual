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
using ProyectoCalendar.Model;

namespace ProyectoCalendar.ViewModel
{
    class CalendarioViewModel : IUserDialogViewModel
    {
        CalendarEntities db = new CalendarEntities();
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
            Evento EventoToAdd = new Evento();
            this.Dialogs.Add(new NewEventViewModel()
            {
                //cargar combobox de tipo de evento.
                TipEventos = db.TipoEventoes.OrderBy(x => x.Nombre).ToList(),
                CboxHora = loadLisHoras(),
                CboxMin = loadLisMin(),
                NewEvento = EventoToAdd,

                OnAdd = (sender) =>
                    {
                        EventoToAdd.nombre= "asd";

                        sender.Close();
                    }

            });
        }
        public static List<int> loadLisHoras()
        {
            List<int> lista = new List<int>();
            for (int i = 00; i <= 23; i++)
            {
                lista.Add(i);
            }
            return lista;
        }

        public static List<int> loadLisMin()
        {
            List<int> lista = new List<int>();
            for (int i = 00; i <= 59; i++)
            {
                lista.Add(i);
            }
            return lista;
        }


        public ICommand GoToAddEvent
        {
            get { return new RelayCommand(calendarioView); }
        }

    }
}
