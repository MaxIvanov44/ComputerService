   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   '   K GComputer Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Computer_ServiceComputer_Service 5   (   !   Computer_Service.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   '   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   '   0localclr-namespace:Computer_Service     5   (     � Title$%  Окно авторизации��5   	   $	��197��6"   $��343.782��6/    � 
ResizeMode$ CanResizeWithGrip=�6?   ��5      �� 5
   
    �� Color$ #647382��6   .��5      �  � ColumnDefinitions 5   
   �� 5      .+�5   
   �� -   5         ��Name$ username��5   E   *   $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Введите логин��6   $��Right=�6W   $��40��6s   $��	0,10,10,0q�6    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��317��6�   $��24(�6�   $��1��6�   �� 5   
   -   5         ��Name$ login1��5      $��
Войти��6"   $
��Left=�62   $��
215,0,0,10q�6M   $	��111��6a   $��24(�6�   $��3��6�    J� RenderTransformOrigin$ 0.194,0.583&�6�   $��50��6�   $��Bottom=�6�   G� 5   
   -   5        	 G�Name$	 password��5   H   $! Введите пароль��6   $��Right=�6Z   $��	0,55,10,0q�6v   $	��Top=�6�   $��40��6�   $	��317��6�   $��24(�6�   $��2��6�   5      5      