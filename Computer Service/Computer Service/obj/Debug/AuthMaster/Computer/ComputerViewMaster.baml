   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   '   K GComputer Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Computer_ServiceComputer_Service 5   	   )   #Computer_Service.ComputerViewMaster   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   '   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   '   0localclr-namespace:Computer_Service     5   	     � Title$  ComputerViewMaster��5   	   $��455.294��6$   $��718.412��65   ��5      �� 5	   
    �� Color$ #647382��6   .��5      �  � RowDefinitions 5   
   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ viewdgr��5   .   $��Stretch=�6?   $��Stretch=�6]   $��10,10,10,77q�6y   $
��Auto��6�   �� 5   
   -   5         ��Name$ 	btncreate��5      $��Создать��6%   $
��Left=�67   $��
10,387,0,0q�6R   $	��Top=�6f   $��87��6~   $��14(�6�   �� 5   
   -   5        $ 	btnupdate��5      $��Изменить��6$   $
��Left=�67   $��413,387,0,0q�6R   $	��Top=�6g   $��97��6   $��14(�6�   �� 5   
   -   5        $ 	btndelete��5      $��Удалить��6$   $
��Left=�66   $��515,385,0,0q�6Q   $	��Top=�6f   $��93��6~   $��14(�6�   �� 5   
   -   5        $
 back��5      $��
Назад��6   $
��Left=�6/   $��613,385,0,0q�6J   $	��Top=�6_   $��75��6w   $��14(�6�   �� 5   
   -   5         ��Name$
 sort��5   X   *   $MahApps.Metro.Controls.TextBoxHelper   	Watermark$C =Фильтр по названию комплектующих��6   $
��Left=�6f   $��31��6�   $��102,387,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��268��6�   $��14(�6�   5      5      