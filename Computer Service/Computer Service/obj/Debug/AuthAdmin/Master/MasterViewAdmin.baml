   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   '   K GComputer Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Computer_ServiceComputer_Service 5   	   &    Computer_Service.MasterViewAdmin   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   '   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   '   0localclr-namespace:Computer_Service     5   	     � Title$'  !Просмотр мастеров��5   	   $	��450��6#   $	��999��60   ��5      �� 5
   
    �� Color$ #647382��6   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��976* �6   �� 5      $	��15* �6    � RowDefinitions 5   
   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ viewdgr��5   +   $��Stretch=�6<   $��Stretch=�6Z   $	��302��6v   $��10,10,10,107q�6�   $
��Auto��6�   $��2��6�   �� 5   
   -   5         ��Name$ 	btncreate��5      $��Создать��6%   $
��Left=�67   $��
10,382,0,0q�6R   $	��Top=�6f   $��75��6~   6�   �� 5   
   -   5        $ 	btnupdate��5      $��Изменить��6$   $
��Left=�67   $��712,382,0,0q�6R   $	��Top=�6g   $��75��6   6�   �� 5   
   -   5        $ 	btndelete��5      $��Удалить��6$   $
��Left=�66   $��792,382,0,0q�6Q   $	��Top=�6f   $��75��6~   6�   �� 5   
   -   5        $
 back��5      $��
Назад��6   $
��Left=�6/   $��906,382,0,0q�6J   $	��Top=�6_   $��75��6w   $��2��6�   5      5      