   M S B A M L   `   `   `  ����F  BMvvmDialogs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullR8clr-namespace:MvvmDialogs.Behaviors;assembly=MvvmDialogsMvvmDialogs.Behaviors  5   	   K GProyectoCalendar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ProyectoCalendarProyectoCalendar 5	   	   =#clr-namespace:ProyectoCalendar.ViewProyectoCalendar.View 5   	   G(clr-namespace:ProyectoCalendar.ViewModelProyectoCalendar.ViewModel 5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	   !   ProyectoCalendar.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Idlgs8clr-namespace:MvvmDialogs.Behaviors;assembly=MvvmDialogs     5   	   0localclr-namespace:ProyectoCalendar     5	   	   4View#clr-namespace:ProyectoCalendar.View     5   	   >	ViewModel(clr-namespace:ProyectoCalendar.ViewModel     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	   ���	#FF464444  � Title$  
MainWindow��5   	   $��374.5��6   $	��446��6+    � WindowStartupLocation$ CenterScreen=�5   	   *   $MvvmDialogs.Behaviors.DialogBehavior   DialogViewModels 5   	   �� *	Dialogs+ � Icon 5   	   �� *&$Properties.Resources.patamon_ic_mvvm+ � DataContext 5      4 .ProyectoCalendar.ViewModel.MainWindowViewModel  5   
   .��5      � $��	33,0,18,0q�6   $	��342��6   $	��Top=�6+    � ColumnDefinitions 5   
   �� 5      .+�5   
   �� -   5         ��Name$ btnGoToRegist��5      ���#33a133$��Registrarse��6=   $��Right=�6S   $��
0,281,29,0q�6o   $	��150��6�   $��32��6�   $	��Top=�6�   $��
ExtraBlack"�6�   
���������6�   �� *GoToRegister+6�   �� 5   
   -   5         ��Name$ lblInfo��5      
�������$j��d Si no tienes una cuenta tienes que
"Registrar Usuario" haciendo "click" 
 en el boton Registrarse��64   $��Center=�6�   $��182,207,-23,0q�6�   $	��Top=�6�   $��62��6  $	��200��6  $��10(�6+  $��Black"�69  $��Italic$�6L  $��Center=�6_  $��Center=�6�  �� 5   
   -   5        $ btnLogIn��5      ���#33a133$��Iniciar Sesión��68   $
��Left=�6Q   $��
10,281,0,0q�6l   $	��Top=�6�   $	��150��6�   $��32��6�   $��
ExtraBlack"�6�   
�������$��14(�6�   ��6�   �� *GoToCalendario+6�   �� 5   
   -   5         ��Name$ chkSaveUser��5      
�������$��Recordar Usuario��6;   $
��Left=�6V   $��
10,236,0,0q�6q   $	��Top=�6�   $��Black"�6�   $��29��6�   $	��136��6�   �� 5   
   -   5        	 ��Name$	 tbUser��5      $
��Left=�6"   *  $MahApps.Metro.Controls.TextBoxHelper
   ClearTextButton
 . $��26��6k   $��
10,125,0,0q�6w    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��150��6�   ��6�   �� *Mail+6�   �� 5    
   -   5        $	 tbPasswd��5       $
��Left=�6$   
 . $��26��6m   $��
10,190,0,0q�6y   $
 Wrap=�6�   $	��Top=�6�   $	��150��6�   ��6�   �� *
Password+6�   �� 5!   
   -   5        $ lblUser��5!      
�������$��
Usuario:
��64   $
��Left=�6Q   $��	10,93,0,0q�6l   $	��Top=�6   $��32��6�   $��Black"�6�   $��58��6�    J� RenderTransformOrigin$ 0.788,0.672&�6�   �� 5"   
   -   5        $ 	lblPasswd��5"      
�������$��Contraseña:
��66   $
��Left=�6V   $��
10,161,0,0q�6q   $	��Top=�6�   $��24��6�   $��Black"�6�   $��80��6�   �� 5#   
   -	   5        $ lblTitle��5#      
�������$��Inicio de Sesión��65   $��Center=�6P   $��
0,10,125,0q�6m   $	��Top=�6�   $	��262��6�   $��36                (�6�   $
��Bold"�5$      $��62��6$   $��Impact)�60   �� 5%   
   -
   5         ��Name$ image��5%      $
��Left=�6   $	��157��6:   $��
212,72,0,0q�6G   $	��Top=�6[   $	��137��6s   $7��1/ProyectoCalendar;component/Resources/unnamed.png��6   5&      5'      