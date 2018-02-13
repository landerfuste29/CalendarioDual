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
using ProyectoCalendar.Model;
using System.Collections.ObjectModel;

namespace ProyectoCalendar.ViewModel
{
    class ShowEventViewModel : IUserDialogViewModel, INotifyPropertyChanged
    {
        public static CalendarEntities db = new CalendarEntities();
        private ObservableCollection<IDialogViewModel> _Dialogs = new ObservableCollection<IDialogViewModel>();
        public System.Collections.ObjectModel.ObservableCollection<IDialogViewModel> Dialogs { get { return _Dialogs; } }


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

        //List<DateTime>
        private List<DateTime> _listaFechas;


        public List<DateTime> ListaFechas
        {
            get { return _listaFechas; }
            set
            {
                _listaFechas = value;
                NotifyPropertyChanged();
            }
        }
        private DateTime _dateSelect;
        public DateTime DateSelect
        {

            get { return _dateSelect; }
            set
            {
                _dateSelect = value;
                loadDGEventos(_dateSelect);
                NotifyPropertyChanged();
            }
        }

        public void loadDGFechas()
        {
            ListaFechas = db.vw_Listar_Fecha.Where(x => x.idEntidad_User == UserLogin.userLog.Entidad_idEntidad).Select(s => s.fecha).ToList();
            
        }
        public void loadDGEventos(DateTime fec)
        {
            
            ListaEventos = db.vw_Listar_Eventos.Where(x => x.fecha == fec &&  x.idEntidad_User == UserLogin.userLog.Entidad_idEntidad).ToList(); ;
            
        }
        private List<vw_Listar_Eventos> _listaEventos;

        public List<vw_Listar_Eventos> ListaEventos
        {
            get { return _listaEventos; }
            set
            {
                _listaEventos = value;
                NotifyPropertyChanged();
            }
        }
        private vw_Listar_Eventos _eventSelect;
        public vw_Listar_Eventos EventSelect
        {

            get { return _eventSelect; }
            set
            {
                _eventSelect = value;
                NotifyPropertyChanged();
            }
        }
        private DateTime _dateSelecToCal = new DateTime();
        public DateTime DateSelecToCal
        {

            get { return _dateSelecToCal; }
            set
            {
                _dateSelecToCal = value;
            }
        }

        public ShowEventViewModel()
        {
            loadDGFechas();
        }



        public ICommand GoToModEvent
        {
            get { return new RelayCommand(newEventView); }
        }

        public void newEventView()
        {
            //List<string> asdf = loadCalendar();
            Evento EventoToAdd = db.Eventoes.Where(w => w.idEvento == EventSelect.idEv).FirstOrDefault(); 
            //Boolean contAddEvent= true;
            this.Dialogs.Add(new NewEventViewModel()
            {

                //cargar combobox de tipo de evento.
                NewEvento = EventoToAdd,
                TexEve ="Modificar", 

                OnAdd = (sender) =>
                {
                    try
                    {
                        EventoToAdd.TipoEvento = db.TipoEventoes.Where(w => w.idTipoEvento.Equals(EventoToAdd.TipoEvento_idTipoEvento)).FirstOrDefault();
                        EventoToAdd.idEvento = db.TipoEventoes.Where(w => w.idTipoEvento.Equals(EventoToAdd.TipoEvento_idTipoEvento)).Select(s => s.idTipoEvento).FirstOrDefault();
                        EventoToAdd.Usuario_idUsuario = EventoToAdd.Usuario.idUsuario;
                        EventoToAdd.Usuario_Entidad_idEntidad = EventoToAdd.Usuario.Entidad_idEntidad;

                        if (EventoToAdd.nombre != "" && EventoToAdd.localizacion != "")
                        {
                            db.Eventoes.Add(EventoToAdd);
                            db.SaveChanges();
                            sender.Close();

                        }
                    }
                    catch (Exception e)
                    {
                        //contAddEvent = false;
                       // showMessageError(Properties.Resources.errorAddEvent, Properties.Resources.errorAddEventMessage);
                    }
                }

            });
        }


    }
}
