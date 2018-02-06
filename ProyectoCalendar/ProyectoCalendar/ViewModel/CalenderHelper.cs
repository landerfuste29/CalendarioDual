using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Shapes;

namespace ProyectoCalendar.ViewModel
{
    class CalenderHelper : DependencyObject
    {

        public static bool GetIsBlackOutDisabled(DependencyObject obj)
        {
            
            return (bool)obj.GetValue(IsBlackOutDisabledProperty);
        }

        public static void SetIsBlackOutDisabled(DependencyObject obj, bool value)
        {
            obj.SetValue(IsBlackOutDisabledProperty, value);
        }

        // Using a DependencyProperty as the backing store for IsBlackOutDisabled.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsBlackOutDisabledProperty =
            DependencyProperty.RegisterAttached("IsBlackOutDisabled", typeof(bool), typeof(CalenderHelper), new PropertyMetadata(false, OnIsBlackOutDisabledChanged));

        private static void OnIsBlackOutDisabledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
           CalendarDayButton dayButton = d as CalendarDayButton;
            if (dayButton.IsLoaded)
            {
                SetBlackout(dayButton, (bool)e.NewValue );

            }
            else
            {
                dayButton.Loaded += (s, ee) =>
                {
                    SetBlackout(dayButton, (bool)e.NewValue);
                };
            }
        }
        

        static void SetBlackout(CalendarDayButton dayButton, bool collapsed  )
        {

            ControlTemplate template = dayButton.Template;
            Path blackoutPath = template.FindName("Blackout", dayButton) as Path;
            if (collapsed)
                
                blackoutPath.Visibility = System.Windows.Visibility.Collapsed;
            else
                blackoutPath.Visibility = System.Windows.Visibility.Visible;
        }
    }
}
