using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;

namespace ProyectoCalendar.View
{
    /// <summary>
    /// Interaction logic for Calendario.xaml
    /// </summary>
    public partial class Calendario : MetroWindow
    {
        public Calendario()
        {
            InitializeComponent();
        }

        private void calend_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
