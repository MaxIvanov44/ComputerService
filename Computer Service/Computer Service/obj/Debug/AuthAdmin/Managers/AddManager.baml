   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   '   K GComputer Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Computer_ServiceComputer_Service 5   	   !   Computer_Service.AddManager   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   '   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   '   0localclr-namespace:Computer_Service     5   	     � Title$-  'Добавление менеджера��5   	   $��622.833��6&   $	��520��67   ��5      �� 5	   
    �� Color$ #647382��6   .��5      � .+�5   
   �� $��
Логин��6   $
��Left=�6    $��	10,10,0,0q�6;   $	��Top=�6N   $��20(�6f   �� 5   
   $��Пароль��6   $
��Left=�6!   $��	10,52,0,0q�6<   $	��Top=�6O   $��20(�6g   �� 5   
   $��Имя��6   $
��Left=�6   $��	10,94,0,0q�69   $	��Top=�6L   $��20(�6d   �� 5   
   $��Фамилия��6   $
��Left=�6"   $��
10,136,0,0q�6=   $	��Top=�6Q   $��20(�6i   �� 5   
   $��Отчество��6   $
��Left=�6#   $��
10,178,0,0q�6>   $	��Top=�6R   $��20(�6j   �� 5   
   $��
Адрес��6   $
��Left=�6    $��
10,220,0,0q�6;   $	��Top=�6O   $��20(�6g   �� 5   
   $��Телефон��6   $
��Left=�6"   $��
10,289,0,0q�6=   $	��Top=�6Q   $��20(�6i   �� 5   
   -   5         ��Name$ login��5      $
��Left=�6"   $��37��6=   $��	94,10,0,0q�6I    �� TextWrapping$
 Wrap=�6\   $	��Top=�6q   $	��410��6�   $��20(�6�   �� 5   
   -   5        $ password��5      $
��Left=�6%   $��38��6@   $��	94,54,0,0q�6L   $
 Wrap=�6_   $	��Top=�6t   $	��410��6�   $��20(�6�   �� 5   
   -   5        $
 name��5      $
��Left=�6!   $��39��6<   $��	64,97,0,0q�6H   $
 Wrap=�6[   $	��Top=�6p   $	��440��6�   $��20(�6�   �� 5   
   -   5        $ family��5      $
��Left=�6#   $��39��6>   $��108,141,0,0q�6J   $
 Wrap=�6_   $	��Top=�6t   $	��396��6�   $��20(�6�   �� 5   
   -   5        $ 
patronymic��5      $
��Left=�6'   $��38��6B   $��108,185,0,0q�6N   $
 Wrap=�6c   $	��Top=�6x   $	��396��6�   $��20(�6�   �� 5   
   -   5        $ address��5      $
��Left=�6$   $��56��6?   $��
80,228,0,0q�6K   $
 Wrap=�6_   $	��Top=�6t   $	��424��6�   $��20(�6�   �� 5   
   -   5        $ phone��5      $
��Left=�6"   $��37��6=   $��138,289,0,0q�6I   $
 Wrap=�6^   $	��Top=�6s   $	��366��6�   $��20(�6�   �� 5   
   -   5        $��Добавить��5      $
��Left=�6$   $��	8,531,0,0q�6?   $	��Top=�6R   $	��139��6j   $��20(�6�   $��51��6�   �� 5   
   $��+7��6   $
��Left=�6   $��
99,289,0,0q�68   $	��Top=�6L   $��20(�6d   �� 5   
   $��E-mail��6   $
��Left=�6!   $��
10,331,0,0q�6<   $	��Top=�6P   $��20(�6h   �� 5   
   -	   5        $ email��5      $
��Left=�6"   $��37��6=   $��
81,331,0,0q�6I   $
 Wrap=�6]   $	��Top=�6r   $	��423��6�   $��20(�6�   �� 5   
   -
   5        $��
Назад��5      $
��Left=�6!   $��384,531,0,10q�6<   $	��118��6R   $��18(�6u   �� 5   
   $!��Серия паспорта��6   $
��Left=�6)   $��	9,373,0,0q�6D   $	��Top=�6W   $��20(�6o   �� 5    
   -   5        $ serial��5       $
��Left=�6#   $��37��6>   $��176,373,0,0q�6J   $
 Wrap=�6_   $	��Top=�6t   $	��327��6�   $��20(�6�   �� 5!   
   $!��Номер паспорта��6   $
��Left=�6)   $��	9,415,0,0q�6D   $	��Top=�6W   $��20(�6o   �� 5"   
   -   5        $ number��5"      $
��Left=�6#   $��37��6>   $��176,415,0,0q�6J   $
 Wrap=�6_   $	��Top=�6t   $	��327��6�   $��20(�6�   5#      5$      