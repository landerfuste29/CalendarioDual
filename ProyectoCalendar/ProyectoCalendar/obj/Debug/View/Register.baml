   M S B A M L   `   `   `  ����K  GProyectoCalendar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ProyectoCalendar.ViewProyectoCalendar.View  5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	   $    ProyectoCalendar.View.Register   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:ProyectoCalendar.View     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5
   
   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	   ���	#FF464444  � Title$  Register��5	   	   $��263.767��6   $��349.907��6+    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � $��0,0,2,0q�6    � ColumnDefinitions 5   
   �� 5      .+�5   
   �� -   5         ��Name$ lblTitle��5      
�������$��Registro de nuevo usaurio��65   $
��Left=�6Y   $��	10,10,0,0q�6t   $	��Top=�6�   $	��323��6�   $��24(�6�   $��
ExtraBlack"�6�   �� 5   
   -   5        $ lblName��5      
�������$��Nombre:��64   $
��Left=�6F   $��	16,58,0,0q�6a   $	��Top=�6t   $��58��6�   �� 5   
   -   5        $ 	lblPasswd��5      
�������$��Contrasenya:��66   $
��Left=�6M   $��	16,89,0,0q�6h   $	��Top=�6{   $��81��6�   �� 5   
   -   5        $ lblEmail��5      
�������$��Correo electrónico:��65   $
��Left=�6S   $��
16,120,0,0q�6n   $	��Top=�6�   �� 5   
   -   5        $ lblEnt��5      
�������$��Entidad:��63   $
��Left=�6F   $��
16,151,0,0q�6a   $	��Top=�6u   �� 5   
   -   5         ��Name$ tbName��5      *  $MahApps.Metro.Controls.TextBoxHelper   ClearTextButton . $
��Left=�6P   $��23��6k   $��
142,62,0,0q�6w    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��163��6�   ��6�   �� *UsrToRegist.nombre+{�6�   �� *TextEnabled+�� 5   
   -   5        $ tbPasswd��5       . $
��Left=�6R   $��23��6m   $��
142,92,0,0q�6y   $
 Wrap=�6�   $	��Top=�6�   $	��163��6�   ��6�   �� *UsrToRegist.contraseña+{�6�   �� *TextEnabled+�� 5   
   -   5        $ tbEmail��5       . $
��Left=�6Q   $��23��6l   $��142,124,0,0q�6x   $
 Wrap=�6�   $	��Top=�6�   $	��163��6�   ��6�   �� *UsrToRegist.email+{�6�   �� *TextEnabled+�� 5   
   -	   5        $ tbEnt��5       . $
��Left=�6O   $��23��6j   $��142,155,0,0q�6v   $
 Wrap=�6�   $	��Top=�6�   $	��163��6�   ��6�   �� *EntidadToAdd.nombre+{�6�   �� *TextEnabled+�� 5   
   -
   5         ��Name$ btnCanc��5      $��
ExtraBlack"�6"   
�������$��14(�6M   ���#33a133$��Cancelar��6p   $
��Left=�6�   $��221,195,0,0q�6�   $	��Top=�6�   $��84��6�   �� 5   
   -   5        $ btnCrea��5      $��
ExtraBlack"�6"   
�������$��14(�6M   ���#33a133$��Crear��6p   $
��Left=�6�   $��123,195,0,0q�6�   $	��Top=�6�   $��84��6�   ��6�   �� *AddConCommand+5       5!      