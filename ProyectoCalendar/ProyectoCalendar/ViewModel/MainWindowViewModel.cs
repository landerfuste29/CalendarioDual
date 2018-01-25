using GalaSoft.MvvmLight.Command;
using MvvmDialogs.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoCalendar.Model;
using System.Windows.Input;

namespace ProyectoCalendar.ViewModel
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<IDialogViewModel> _Dialogs = new ObservableCollection<IDialogViewModel>();
        CalendarEntities db = new CalendarEntities();

        public event PropertyChangedEventHandler PropertyChanged;
        public System.Collections.ObjectModel.ObservableCollection<IDialogViewModel> Dialogs { get { return _Dialogs; } }
        public void registreView()
        {
            Usuario usu_aux = new Usuario();
            Entidad ent_aux = new Entidad();
            String mensToEnv;
            this.Dialogs.Add(new RegisterViewModel()
            {
                //  Title = "Esto es una mierda"
                EntidadToAdd = ent_aux,
                UsrToRegist = usu_aux,

                TextEnabled = true,
                OnAdd = (sender) =>
                {
                    Usuario usEmExist = db.Usuarios.Where(w => w.email.Equals(usu_aux.email)).FirstOrDefault();
                    Entidad entExist = db.Entidads.Where(w => w.nombre.Equals(ent_aux.nombre)).FirstOrDefault();

                    if (usEmExist == null)
                    {
                        mensToEnv = "Todo OK";

                        try
                        {
                            if (entExist == null) {
                                db.Entidads.Add(ent_aux);
                                usu_aux.Entidad_idEntidad = ent_aux.idEntidad;
                            }
                            else
                            {
                                usu_aux.Entidad_idEntidad = entExist.idEntidad;
                            }

                            db.Usuarios.Add(usu_aux);
                            db.SaveChanges();
                        }
                        catch (Exception e)
                        {
                        }
                    }
                    else
                    {
                        mensToEnv = "NO OK!!";

                    }
                    //MostrarMensaje
                    sender.Close();
                }

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
