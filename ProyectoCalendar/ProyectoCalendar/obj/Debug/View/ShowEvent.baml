   M S B A M L   `   `   `  ����K  GProyectoCalendar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ProyectoCalendar.ViewProyectoCalendar.View  5   	   F BMvvmDialogs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullR8clr-namespace:MvvmDialogs.Behaviors;assembly=MvvmDialogsMvvmDialogs.Behaviors 5
   	   =#clr-namespace:ProyectoCalendar.ViewProyectoCalendar.View  5   	   G(clr-namespace:ProyectoCalendar.ViewModelProyectoCalendar.ViewModel  5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	   %    ProyectoCalendar.View.ShowEvent   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:ProyectoCalendar.View     5   	   Idlgs8clr-namespace:MvvmDialogs.Behaviors;assembly=MvvmDialogs     5
   	   4View#clr-namespace:ProyectoCalendar.View     5   	   >	ViewModel(clr-namespace:ProyectoCalendar.ViewModel     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	   ���	#FF464444  � Title$  	ShowEvent��5   	   $	��454��6   $	��706��6(    � WindowStartupLocation$ CenterScreen=�5   	   *  $MvvmDialogs.Behaviors.DialogBehavior   DialogViewModels 5   	   �� *	Dialogs+ � DataContext 5      3  -ProyectoCalendar.ViewModel.ShowEventViewModel  5   
   .��5      � .+�5   
   �� -   5         ��Name$ btnModificar��5      $��
ExtraBlack"�6'   
�������$��14(�6R   ���#33a133$��	Modificar��6u   $
��Left=�6�   $��	10,50,0,0q�6�   $	��Top=�6�   $	��136��6�   $��58��6�   ��6�   �� *GoToModEvent+6�   �� 5   
   -   5        $ 	btnBorrar��5      $��
ExtraBlack"�6$   
�������$��14(�6O   ���#33a133$��Borrar��6r   $
��Left=�6�   $��
10,150,0,0q�6�   $	��Top=�6�   $	��136��6�   $��58��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5      $
��Left=�6%   $��
163,10,0,0q�6@   $	��Top=�6T   $	��403��6l   $	��260��6y      
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�      AutoGenerateColumns .  ���	#FF7A7373	   SelectionMode$	 Single=�5   r   ��6   �� *ListaFechas+
 �� SelectedItem
 67   �� *
DateSelect+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Fecha��6a   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Date+   ClipboardContentBinding 6>   Z� 6a   5        5   
   -   5        $ 
dgvEventos��5      $
��Left=�6'   $��
428,10,0,0q�6B   $	��Top=�6V   $	��403��6n    . $	��260��6�   $ * 6�    .  ���	#FF7A7373$	 Single=�5    t   ��6   �� *ListaEventos+
 68   �� *EventSelect+ 5!        5"      $ Nombre��6c    6%   �� *Nombre+ 6@   Z� 6c     5#      $
 Tipo��6f    6%   �� *	Categoria+ 6C   Z� 6f     5$      $ Descripcion��6h    6%   �� *Descripcion+ 6E   Z� 6h   5&      �� 5'   
   -   5        $ 	btnExport��5'      ���#33a133$��
ExtraBlack"�6:   
�������$��14(�6e   $��Exportar a CSV��6s   $
��Left=�6�   $��
10,250,0,0q�6�   $	��Top=�6�   $	��136��6�   $��58��6�   5)      5*      