   M S B A M L   `   `   `  ����K  GProyectoCalendar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ProyectoCalendar.ViewProyectoCalendar.View  5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	   $    ProyectoCalendar.View.NewEvent   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:ProyectoCalendar.View     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   
   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	   ���	#FF464444  � Title$  NewEvent��5
   	   $	��312��6   $��425.5��6'    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � $��0,0,2,0q�6    � ColumnDefinitions 5   
   �� 5      �� 5      $��0* �6   .+�5   
   �� -   5         ��Name$ lblTitle��5      
�������$��Registro de nuevo Evento��65   $
��Left=�6X   $��	10,10,0,0q�6s   $	��Top=�6�   $	��323��6�   $��24(�6�   $��
ExtraBlack"�6�   $��42��6�   �� 5   
   -   5        $ lblName��5      
�������$��Nombre:��64   $
��Left=�6F   $��	18,61,0,0q�6a   $	��Top=�6t   $��58��6�   $��26��6�   �� 5   
   -   5        $ lblLocal��5      
�������$��Localización:��65   $
��Left=�6M   $��	18,91,0,0q�6h   $	��Top=�6{   $��81��6�   $��26��6�   �� 5   
   -   5        $ lblType��5      
�������$��Tipo:��64   $
��Left=�6D   $��
18,121,0,0q�6_   $	��Top=�6s   $��26��6�   $��36��6�   �� 5   
   -   5        $ lblDesc��5      
�������$��Descripción:��64   $
��Left=�6K   $��
18,211,0,0q�6f   $	��Top=�6z   $��26��6�   $��74��6�   �� 5   
   -   5         ��Name$ tbName��5      *  $MahApps.Metro.Controls.TextBoxHelper   ClearTextButton . $
��Left=�6P   $��26��6k   $��
144,61,0,0q�6w    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��252��6�   ��6�   �� *NewEvento.nombre+6�   �� 5   
   -   5        $ tbLocal��5       . $
��Left=�6Q   $��26��6l   $��
144,91,0,0q�6x   $
 Wrap=�6�   $	��Top=�6�   $	��252��6�   ��6�   �� *NewEvento.localizacion+6�   �� 5   
   -   5        $ tbEnt��5       . $
��Left=�6P   $��26��6k   $��144,211,0,0q�6w   $
 Wrap=�6�   $	��Top=�6�   $	��252��6�   ��6�   �� *NewEvento.descripcion+6�   �� 5   
   -	   5         ��Name$ btnCanc��5      $��
ExtraBlack"�6"   
�������$��14(�6M   ���#33a133$��Cancelar��6p   $
��Left=�6�   $��309,245,0,0q�6�   $	��Top=�6�   $��87��6�   $��29��6�   ��6�   �� *CancelCommand+�� 5   
   -
   5        $ btnCrea��5      $��
ExtraBlack"�6"   
�������$��14(�6M   ���#33a133$
��Left=�6�   $��207,245,0,0q�6�   $	��Top=�6�   $��87��6�   $��29��6   � UseLayoutRounding .  ��6p   �� *TexEve+��6�   �� *AddEventCommand+6  �� 5   
   -   5        $ lblDate��5      
�������$��Fecha:��64   $
��Left=�6E   $��
18,151,0,0q�6`   $	��Top=�6t   $��26��6�   $��43��6�   (  "System.Windows.Controls.DatePicker  5    
   $
��Left=�6   $��144,151,0,0q�60   $	��Top=�6E   $��26��6�   $	��100��6�   	   DisplayDate	 6]   �� *NewEvento.fecha+
   SelectedDate
 6�   �� *
ChosenDate+6�   �� 5!   
   -   5        $ lblDate_Copy��5!      
�������$��Nº Assis Max.:��69   $
��Left=�6R   $��
18,181,0,0q�6m   $	��Top=�6�   $��26��6�   $��84��6�   �� 5"   
   -   5        $ tbMaxAss��5"       . $
��Left=�6R   $��26��6m   $��144,181,0,0q�6y   $
 Wrap=�6�   $	��Top=�6�   $��60��6�   ��6�   �� *NewEvento.asistenciaMaxima+6�   �� 5#   
   -   5         ��Name$ comboBox��5#      $
��Left=�6&   $��144,121,0,0q�6A   $	��Top=�6V   $	��102��6n    �� DisplayMemberPath$ Nombre��6�    �� 
IsReadOnly . $��26��6�   ��6z   �� *
TipEventos+ �� SelectedItem 6�   �� *SelectedEvento+6�   �� 5$   
   -   5        $ 	cbox_Hora��5$      $��256,150,112,0q�6&   $	��Top=�6=    . $��26��6�   ��6U   �� *
CboxHora+ 6v   �� *SelectedCboxHora+6�   �� 5%   
   -   5        $ cbox_Min��5%      $
��Left=�6%   $��326,151,0,0q�6@   $	��Top=�6U   $��50��6m    . $��26��6�   ��6x   �� *	CboxMin+ 6�   �� *SelectedCboxMin+6�   �� 5&   
   -   5        $ label��5&      
�������$��H��62   $
��Left=�6>   $��309,150,0,0q�6Y   $	��Top=�6n   $��20��6�   $��26��6�   �� 5'   
   -   5        $ label1��5'      
�������$��M��63   $
��Left=�6?   $��375,150,0,0q�6Z   $	��Top=�6o   $��26��6�   $��21��6�   5*      5+      