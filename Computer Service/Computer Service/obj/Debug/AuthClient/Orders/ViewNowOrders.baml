   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   '   K GComputer Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Computer_ServiceComputer_Service 5   	   $   Computer_Service.ViewNowOrders   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   '   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   '   0localclr-namespace:Computer_Service     5   	     � Title$%  Просмотр заказов��5   	   $��366.967��6"   $	��999��63   ��5      �� 5	   
    �� Color$ #647382��6   .��5      �  � RowDefinitions 5   
   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ viewdgr��5   *      CanUserAddRows .  $��Stretch=�6;   $��Stretch=�6Y   $
��Auto��6u   $��10,10,10,58q�6�   $
��Auto��6�   6�   �� 5   
   -   5         ��Name$ 	btnupdate��5      $��Просмотр��6$   $
��Left=�67   $��	10,0,0,10q�6R   $��Bottom=�6e   $	��121��6�   $��42��6�   $��16(�6�   �� 5   
   -   5        $
 back��5      $��
Назад��6   $
��Left=�6/   $��
892,0,0,10q�6J   $��Bottom=�6^   $��89��6y   $��42��6�   $��16(�6�    J� RenderTransformOrigin$ 
0.18,0.429&�6�   	� 5   
   -   5         	�Name$	 new��5      $��
Новый��6#   $
��Left=�63   $��
141,0,0,10q�6N   $��Bottom=�6b   $��16(�6}   $��88��6�   6�   	� 5   
   -   5        $ 	inprocess��5      $��В процессе��6*   $
��Left=�6?   $��
234,0,0,10q�6Z   $��Bottom=�6n   $��16(�6�   $	��130��6�   6�   	� 5   
   -   5        $ cancel��5      $��Отменён��6'   $
��Left=�69   $��
368,0,0,10q�6T   $��Bottom=�6h   $��16(�6�   $	��104��6�   6�   	� 5   
   -   5        $ ready��5      $��
Готов��6&   $
��Left=�66   $��
477,0,0,10q�6Q   $��Bottom=�6e   $��16(�6�   $��91��6�   6�   	� 5   
   -   5        $ complete��5      $��Завершен��6)   $
��Left=�6<   $��
573,0,0,10q�6W   $��Bottom=�6k   $��16(�6�   $	��112��6�   6�   	� 5   
   -	   5        $	 all��5      $��Все заказы��6$   $
��Left=�69   $��
690,0,0,10q�6T   $��Bottom=�6h   $��16(�6�   $	��110��6�   6�   �� 5   
   -
   5        $
��Left=�5      $��43��6,   $��840,283,0,0q�68   $	��Top=�6M   $��41��6e   $T��N/Computer Service;component/Resources/1043px-Microsoft_Excel_2013_logo.svg.png��6p   6�   5      5      