   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   '   K GComputer Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Computer_ServiceComputer_Service 5   	   "   Computer_Service.ManagerView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   '   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   '   0localclr-namespace:Computer_Service     5   	     � Title$+  %Просмотр менеджеров��5   	   $	��450��6%   $	��999��62   ��5      �� 5	   
    �� Color$ #647382��6   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��976* �6   �� 5      $	��15* �6    � RowDefinitions 5   
   �� 5      $
��161* �6   �� 5      $
��258* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ viewdgr��5   -   $��Stretch=�6>   $��Stretch=�6\   $	��302��6x   $��10,10,10,107q�6�   $
��Auto��6�   $��2��6�   $��2��6�   �� 5   
   -   5         ��Name$ 	btncreate��5      $��Создать��6%   $
��Left=�67   $��
10,221,0,0q�6R   $��1��6f   $	��Top=�6s   $��75��6�   6�   �� 5   
   -   5        $ 	btnupdate��5      $��Изменить��6$   $
��Left=�67   $��712,221,0,0q�6R   $��1��6g   $	��Top=�6t   $��75��6�   6�   �� 5   
   -   5        $ 	btndelete��5      $��Удалить��6$   $
��Left=�66   $��792,221,0,0q�6Q   $��1��6f   $	��Top=�6s   $��75��6�   6�   �� 5   
   -   5        $
 back��5      $��
Назад��6   $
��Left=�6/   $��906,221,0,0q�6J   $��1��6_   $	��Top=�6l   $��75��6�   $��2��6�   5      5      