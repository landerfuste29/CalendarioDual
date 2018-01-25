using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ProyectoCalendar.ViewModel
{
    public class RedLetterDayConverter : IValueConverter
    {
        static Dictionary<DateTime, string> dict = new Dictionary<DateTime, string>(); static RedLetterDayConverter() { dict.Add(new DateTime(2018, 1, 1), "St. Patrick's Day"); dict.Add(new DateTime(2018, 1, 3), "First day of spring"); dict.Add(new DateTime(2018, 1, 15), "April Fools"); }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
