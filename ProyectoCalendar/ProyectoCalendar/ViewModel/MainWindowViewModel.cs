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
using System.Windows;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Threading;

namespace ProyectoCalendar.ViewModel
{
    class MainWindowViewModel : INotifyPropertyChanged
    {

        Usuario userLoginApp = new Usuario();

        private ObservableCollection<IDialogViewModel> _Dialogs = new ObservableCollection<IDialogViewModel>();
        CalendarEntities db = new CalendarEntities();

        /*private Usuario _usrToLogin;
        public Usuario UsrToLogin
        {
            get { return (_usrToLogin); }
            set { _usrToLogin = value; NotifyPropertyChanged(); }
        }*/
        private string _mail;

        public string Mail
        {
            get { return (_mail); }
            set { _mail = value; NotifyPropertyChanged(); }
        }

        private string _password;

        public string Password
        {
            get { return (_password); }
            set { _password = value; NotifyPropertyChanged(); }
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
                            if (usu_aux.contraseña != "" && usu_aux.email != ""&& usu_aux.nombre != "" ) {
                                usu_aux.tipo = 1;
                                usu_aux.contraseña = GetMd5Hash(usu_aux.contraseña);
                                db.Usuarios.Add(usu_aux);
                                db.SaveChanges();
                                showMessageError(Properties.Resources.addUserCorrectTitle, Properties.Resources.addUserCorrectMessage);
                                sender.Close();
                            }else {
                                //Error al hacer el add BBDD
                                showMessageErrorHere(Properties.Resources.errorAddUserTitle, Properties.Resources.errorAddUserMessage);
                            }


                            //Creado Correctamente                            
                            

                        }
                        catch (Exception e)
                        {
                            //Error al hacer el add BBDD
                            showMessageErrorHere(Properties.Resources.errorAddUserTitle, Properties.Resources.errorAddUserMessage);
                        }
                    }
                    else
                    {
                        //mail existe
                        showMessageErrorHere(Properties.Resources.errorAddUserTitle, Properties.Resources.errorAddUserMailMassage);
                        mensToEnv = "NO OK!!";

                    }
                    //MostrarMensaje

                    
                }

            });
        }
        public void CalendarioView()
        {
            try
            {


                Usuario usEmExist = db.Usuarios.Where(w => w.email.Equals(Mail)).FirstOrDefault();

                if (usEmExist != null)
                {
                    if (VerifyMd5Hash(Password, usEmExist.contraseña))
                    {
                        userLoginApp = usEmExist;
                        this.Dialogs.Add(new CalendarioViewModel()
                        {
                            UserCalApp = userLoginApp
                            //  Title = "Esto es una mierda"
                        });
                    }
                    else
                    {
                        showMessageError(Properties.Resources.errorLoginTitle, Properties.Resources.errorLoginMessage);
                        //Mensaje Password incorrectaUsrToLogin
                    }
                }
                else
                {
                    showMessageError(Properties.Resources.errorLoginTitle, Properties.Resources.errorLoginMessage);
                    //Mensaje correo erroneo
                }
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
        // TODO: Mover en una clase aparte IVAN
        public async void showMessageError(String titulo, String error)
        {
            var metroWindow = (Application.Current.MainWindow as MetroWindow);
            metroWindow.MetroDialogOptions.ColorScheme = MetroDialogColorScheme.Theme;
            await metroWindow.ShowMessageAsync(titulo, error, MessageDialogStyle.Affirmative, metroWindow.MetroDialogOptions);
        }
        public async void showMessageErrorHere(String titulo, String error)
        {
            var metroWindow = (Application.Current.Windows.OfType<Window>()
                                     .SingleOrDefault(x => x.IsActive) as MetroWindow);

            metroWindow.MetroDialogOptions.ColorScheme = MetroDialogColorScheme.Theme;
            await metroWindow.ShowMessageAsync(titulo, error, MessageDialogStyle.Affirmative, metroWindow.MetroDialogOptions);
        }

    }
}
