   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   '   K GComputer Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Computer_ServiceComputer_Service 5   	   !   Computer_Service.MasterView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   '   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   '   0localclr-namespace:Computer_Service     5   	     � Title$  
MasterView��5   	   $	��450��6   $	��999��6)   ��5      �� 5	   
    �� Color$ #647382��6   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��976* �6   �� 5      $	��15* �6    � RowDefinitions 5   
   �� 5      $
��161* �6   �� 5      $
��258* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ viewdgr��5   Y   $��Stretch=�6j   $��Stretch=�6�   $	��302��6�   $��10,10,10,107q�6�   $
��Auto��6�   $��2��6�   $��2��6�   �� 5   
   -   5         ��Name$
 back��5      $��
Назад��6   $
��Left=�6/   $��906,221,0,0q�6J   $��1��6_   $	��Top=�6l   $��75��6�   $��2��6�   �� 5   
   -   5        $	 sel��5      $#��Выбрать мастера��6   $
��Left=�69   $��
10,221,0,0q�6T   $	��Top=�6h   $	��120��6�   $��1��6�   5      5      