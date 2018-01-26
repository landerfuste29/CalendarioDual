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
using System.Security.Cryptography;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace ProyectoCalendar.ViewModel
{
    class MainWindowViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<IDialogViewModel> _Dialogs = new ObservableCollection<IDialogViewModel>();
        CalendarEntities db = new CalendarEntities();

        private Usuario _usrToLogin;
        public Usuario UsrToLogin
        {
            get { return (_usrToLogin); }
            set { _usrToLogin = value; NotifyPropertyChanged(); }
        }


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
                            if (entExist == null)
                            {
                                db.Entidads.Add(ent_aux);
                                usu_aux.Entidad_idEntidad = ent_aux.idEntidad;
                            }
                            else
                            {
                                usu_aux.Entidad_idEntidad = entExist.idEntidad;
                            }

                            usu_aux.contraseña = GetMd5Hash(usu_aux.contraseña);
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

            try {
                UsrToLogin = UsrToLogin;
            Usuario usEmExist = db.Usuarios.Where(w => w.email.Equals(UsrToLogin.email)).FirstOrDefault();

            if (usEmExist != null)
            {
                if (VerifyMd5Hash(UsrToLogin.contraseña, usEmExist.contraseña))
                {
                    this.Dialogs.Add(new CalendarioViewModel()
                    {
                        //  Title = "Esto es una mierda"
                    });
                }
                else
                {
                    //Mensaje Password incorrecta
                }
            }
            else
            {
                //Mensaje El correo no existe
            }
            }
            catch { }
        }


        private void LoadUserLogin(object sender, TextChangedEventArgs e)
        {
            try
            {
                var textBox = sender as TextBox;
                UsrToLogin.email = textBox.Text;
            }
            catch { }
        }

        public ICommand GoToRegister
        {
            get { return new RelayCommand(registreView); }
        }
        public ICommand GoToCalendario
        {

            get { return new RelayCommand(CalendarioView); }
        }

        static string GetMd5Hash(string input)
        {
            MD5 md5Hash = MD5.Create();

            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
        /*.................................................
        Metode per comprobar MD5
        ------------------------------------------*/
        static bool VerifyMd5Hash(string input, string hash)
        {
            /*
             input = Password Login
             hash = Password BBDD
             */

            MD5 md5Hash = MD5.Create();
            string hashOfInput = GetMd5Hash(input);

            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
