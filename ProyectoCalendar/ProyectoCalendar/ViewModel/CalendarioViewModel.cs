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
using System.Windows.Controls;
using System.Windows;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

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

        private Usuario _userCalApp;

        public Usuario UserCalApp
        {

            get { return _userCalApp; }
            set { _userCalApp = value; }
        }

        private Evento _listaData;
        public Evento ListaData
        {

            get { return _listaData; }
            set { _listaData = value; }
        }


        private string _title;
        public string Title
        {

            get { return _title; }
            set { _title = value; }
        }

        private DateTime _dateSelect;
        public DateTime DateSelect
        {

            get { return _dateSelect; }
            set { _dateSelect = value; }
        }


        //  public class GoToAddEvent
        public void calendarioView()
        {
            if (DateSelect.ToString().Contains("01-01-01"))
            {

                DateSelect = DateTime.Today;
            }
            //List<string> asdf = loadCalendar();
            Usuario userToEnt = UserCalApp;
            Evento EventoToAdd = new Evento();
            //Boolean contAddEvent= true;
            this.Dialogs.Add(new NewEventViewModel()
            {

                //cargar combobox de tipo de evento.
                TipEventos = db.TipoEventoes.OrderBy(x => x.Nombre).ToList(),
                CboxHora = loadLisHoras(),
                CboxMin = loadLisMin(),
                NewEvento = EventoToAdd,
                ChosenDate = DateSelect,

                OnAdd = (sender) =>
                    {
                        try
                        {
                            EventoToAdd.TipoEvento = db.TipoEventoes.Where(w => w.idTipoEvento.Equals(EventoToAdd.TipoEvento_idTipoEvento)).FirstOrDefault();
                            EventoToAdd.idEvento = db.TipoEventoes.Where(w => w.idTipoEvento.Equals(EventoToAdd.TipoEvento_idTipoEvento)).Select(s => s.idTipoEvento).FirstOrDefault();
                            EventoToAdd.Usuario = db.Usuarios.Where(w => w.idUsuario.Equals(userToEnt.idUsuario)).FirstOrDefault();
                            EventoToAdd.Usuario_idUsuario = EventoToAdd.Usuario.idUsuario;
                            EventoToAdd.Usuario_Entidad_idEntidad = EventoToAdd.Usuario.Entidad_idEntidad;


                            db.Eventoes.Add(EventoToAdd);
                            db.SaveChanges();
                            sender.Close();
                        }
                        catch (Exception e)
                        {
                            //contAddEvent = false;
                            showMessageError(Properties.Resources.errorAddEvent, Properties.Resources.errorAddEventMessage);
                        }
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

        public static DateTime loadCalendar()
        {
            CalendarEntities db = new CalendarEntities();
            List<DateTime> vista = db.vw_Listar_Fecha.Where(x => x.idEntidad_User == 1).Select(s => s.fecha).ToList();
            // var calendar = sender as Calendar;
            /* for (int i = 00; i <= 59; i++)
             {*/
            //calendar.BlackoutDates.Add(new CalendarDateRange(new DateTime(2018, 2, 16)));
            // }
            /*
         calendarWithBlackoutDates.BlackoutDates.Add(    new CalendarDateRange(new DateTime(2009, 1, 16)));

         */
            return vista[0];
        }

        public ICommand GoToAddEvent
        {
            get { return new RelayCommand(calendarioView); }
        }
        public ICommand GoToShowEvent
        {
            get { return new RelayCommand(ShowEventView); }
        }

        public void ShowEventView()
        {
            //List<string> asdf = loadCalendar();
            this.Dialogs.Add(new ShowEventViewModel()
            {

                //cargar combobox de tipo de evento.

            });
        }
        public async void showMessageError(String titulo, String error)
        {
            var metroWindow = (Application.Current.Windows.OfType<Window>()
                                     .SingleOrDefault(x => x.IsActive) as MetroWindow);
            
            metroWindow.MetroDialogOptions.ColorScheme = MetroDialogColorScheme.Theme;
            await metroWindow.ShowMessageAsync(titulo, error, MessageDialogStyle.Affirmative, metroWindow.MetroDialogOptions);
        }
    }
}
