   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   '   K GComputer Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Computer_ServiceComputer_Service 5   	   #   Computer_Service.OrderDetails   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   '   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   '   0localclr-namespace:Computer_Service     5   	     � Title$5  /Добавление комплектующих��5   	   $	��482��6*   $��1013.834��67   ��5      �� 5	   
    �� Color$ #647382��6   .��5      � -   5         � ColumnDefinitions 5   
   �� 5      .+�5   
   �� -   5        $&�� Добавить к заказу��5      $
��Left=�6-   $��245,395,0,0q�6H   $	��Top=�6]   $	��335��6u   $��24(�6�   $��46��6�   �� 5   
   -   5        $��
Назад��5      $
��Left=�6!   $��920,401,0,0q�6<   $	��Top=�6Q   $��76��6i   $��14(�6�   $��40��6�   �� 5   
   -   5         ��Name$	 pc1��5      $
��Left=�6!   $��40��6<   $��	10,43,0,0q�6H    �� TextWrapping$
 Wrap=�6[   $	��Top=�6p   $	��130��6�   $��24(�6�   �� 5   
   -   5        $	 pc2��5      $
��Left=�6!   $��40��6<   $��	10,88,0,0q�6H   $
 Wrap=�6[   $	��Top=�6p   $	��130��6�   $��24(�6�   �� 5   
   -   5        $	 pc3��5      $
��Left=�6!   $��40��6<   $��
10,133,0,0q�6H   $
 Wrap=�6\   $	��Top=�6q   $	��130��6�   $��24(�6�   �� 5   
   -   5        $	 pc4��5      $
��Left=�6!   $��40��6<   $��
10,178,0,0q�6H   $
 Wrap=�6\   $	��Top=�6q   $	��130��6�   $��24(�6�   �� 5   
   -   5        $	 pc5��5      $
��Left=�6!   $��40��6<   $��
10,223,0,0q�6H   $
 Wrap=�6\   $	��Top=�6q   $	��130��6�   $��24(�6�   &   System.Windows.Controls.DataGrid  5   
   -	   5          Name$ viewdgr��5      $
��Left=�6%   $	��380��6@   $��
245,10,0,0q�6M   $	��Top=�6a   $	��751��6y   �� 5   
   -
   5         ��Name$ addcompl��5   �   $��+деталь��6   $
��Left=�6#   $��
145,10,0,0q�6>   $	��Top=�6R   $��95��6j   $��16(�6�   $��35��6�   6�   �� 5   
   -   5        $'��!добавить/изменить��5      $
��Left=�6-   $��585,401,0,0q�6H   $	��Top=�6]   $	��235��6u   $��18(�6�   $��40��6�   5      5      