   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   '   K GComputer Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Computer_ServiceComputer_Service 5   	   #   Computer_Service.ComputerView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   '   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   '   0localclr-namespace:Computer_Service     5   	     � Title$  ComputerView��5   	   $	��450��6   $	��999��6+   ��5      �� 5	   
    �� Color$ #647382��6   .��5      �  � RowDefinitions 5   
   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ viewdgr��5   Y   $��Stretch=�6j   $��Stretch=�6�   $	��302��6�   $��10,10,10,107q�6�   $
��Auto��6�   �� 5   
   -   5         ��Name$ 	btncreate��5      $��Создать��6%   $
��Left=�67   $��
10,382,0,0q�6R   $	��Top=�6f   $��75��6~   6�   �� 5   
   -   5        $ 	btnupdate��5      $��Изменить��6$   $
��Left=�67   $��530,382,0,0q�6R   $	��Top=�6g   $��75��6   6�   �� 5   
   -   5        $ 	btndelete��5      $��Удалить��6$   $
��Left=�66   $��610,382,0,0q�6Q   $	��Top=�6f   $��75��6~   6�   �� 5   
   -   5        $
 back��5      $��На главную��6   $
��Left=�64   $��885,382,0,0q�6O   $	��Top=�6d   $��96��6|   6�   �� 5   
   -   5        $ 	back_Copy��5      $ ��назад к заказу��6$   $
��Left=�6=   $��735,382,0,0q�6X   $	��Top=�6m   $	��120��6�   6�   5      5      