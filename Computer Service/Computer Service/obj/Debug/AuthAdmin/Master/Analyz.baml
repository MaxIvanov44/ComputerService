   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   '   K GComputer Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Computer_ServiceComputer_Service 5   	   U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5   	      Computer_Service.Analyz   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   '   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   '   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Computer_Service     5   	   Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5   	     � Title$)  #Заработок мастеров��5	   	   $	��682��6$   $
��1314��61   ��5
      �� 5   
    �� Color$ #647382��6   .��5      �  � ColumnDefinitions 5   
   �� 5      .+�5   
     LiveCharts.Wpf.PieChart  -   5          Name$ 
myPieChart��5      &   LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$ Bottom=�6+      	Hoverable .  $
��Left=�6�   $	��670��6�   $	��651��6�   $	��Top=�6�   $��20(�6�      DataTooltip 6s   Z� ��5      �� 5      $ Black��6"    �� Opacity$	 0.7Q�60   5      #  LiveCharts.Wpf.CartesianChart  5   
   $ Bottom=�6B   $��	670,0,0,0q�6Z   $��20(�6m      Series 6   �� *SeriesCollection+	   AxisX	 5        LiveCharts.Wpf.Axis  
   Labels
 6   �� *Labels+68   ��5      �� 5       $ Black��6"   $	 0.7Q�60   5"      �� 5%   
   -   5        $
��Back��5%      $
��36px(�6    $
��Left=�60   $	��Top=�6K   $	��136��6c   $��71��6�   5&      5'      