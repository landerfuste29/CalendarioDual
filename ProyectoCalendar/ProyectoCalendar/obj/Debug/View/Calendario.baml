   M S B A M L   `   `   `  ����F  BMvvmDialogs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullR8clr-namespace:MvvmDialogs.Behaviors;assembly=MvvmDialogsMvvmDialogs.Behaviors  5   	   K GProyectoCalendar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ProyectoCalendar.ViewProyectoCalendar.View 5	   	   =#clr-namespace:ProyectoCalendar.ViewProyectoCalendar.View 5   	   G(clr-namespace:ProyectoCalendar.ViewModelProyectoCalendar.ViewModel 5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	   &    ProyectoCalendar.View.Calendario   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Idlgs8clr-namespace:MvvmDialogs.Behaviors;assembly=MvvmDialogs     5   	   5local#clr-namespace:ProyectoCalendar.View     5	   	   4View#clr-namespace:ProyectoCalendar.View     5   	   >	ViewModel(clr-namespace:ProyectoCalendar.ViewModel     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	   ���	#FF464444  � Title$  
Calendario��5   	   $	��454��6   $	��706��6)    � UseLayoutRounding .   � WindowStartupLocation$ CenterScreen=�5   	   *   $MvvmDialogs.Behaviors.DialogBehavior   DialogViewModels 5   	   �� *	Dialogs+ � DataContext 5      4 .ProyectoCalendar.ViewModel.CalendarioViewModel  5   
    � 	Resources 5         StyleCalanderDayButton �� 
TargetType:  4System.Windows.Controls.Primitives.CalendarDayButton �� Property �� Value  StyleCalanderButton7  1System.Windows.Controls.Primitives.CalendarButton  StyleCalendar&   System.Windows.Controls.Calendar	 �� 
TargetType5  /System.Windows.Controls.Primitives.CalendarItem
  Name �� EndPoint �� 
StartPoint � Color � Offset��%X  &	        &	 v     &	 8    7   7  �� 5   
   "  6/   .�5      ��  � ��$ 40��6'   64   �� 5       � ��$ 40��6&   63   5      �� 5   
   "  6,   .�5      ��  � ��$ 60��6'   64   �� 5       � ��$ 60��6&   63   �� 5       � ��$ Normal"�6+   �� 5        � ��$ 18(�6)   5!      �� 5"   
   "  6&   .�5#      ��  � �� 5$      �� 5%      "	  6&   .R�5&      (� $	��400��6"   $	��400��6/   .��5'        $
 PART_CalendarItem��6+   #��z��5(   !   #��z��5)   !   #��z��5*   !   $��Expanded&�6U   5+      5,      5-      5/      �� 50       �@ CalendarDayButtonStyle8   6j   �� 51       �@ CalendarButtonStyle8  6d   �� 52       � ��
 �����6+   �� 53       � �� 54      �� 55      $ 0.5,1&�6*   $ 0.5,0&�6;   .��56      � $ #3c643c��6'   $ 0Q�67   � 57      $ #427742��6'   $ 0Q�67   � 58      $ #509a50��6'   $	 0.2Q�67   � 59      $ #ffffff��6'   $ 2Q�67   5:      5<      �� 5=       � ��$ 0q�60   5>      5?      .��5@      �  � ColumnDefinitions 5A   
   �� 5B      .+�5D   
   �� -   5         ��Name$ btnAddEvent��5D      $��
ExtraBlack"�6'   
�������$��14(�6R   ���#33a133$��Crear Evento��6u   $
��Left=�6�   $��	26,43,0,0q�6�   $	��Top=�6�   $	��149��6�   $��44��6�   ��6�   �� *GoToAddEvent+6�     5E   
   -   5          Name$ calend��5E      #��[ 6$   $
��Left=�6K   $��
293,10,0,0q�6f   $	��Top=�6z   $	��400��5F   8   $	��400��6E      SelectedDate 6   �� *
DateSelect+6E   �� 5G   
   -   5        $ btn_MostEvento��5G      $��
ExtraBlack"�6*   
�������$��14(�6U   ���#33a133$��Mostrar Eventos��6x   $
��Left=�6�   $��
26,109,0,0q�6�   $	��Top=�6�   $	��149��6�    J� RenderTransformOrigin$ 
0.04,0.625&�6�   $��44��6*  ��6  �� *GoToShowEvent+6*  5H      5J      