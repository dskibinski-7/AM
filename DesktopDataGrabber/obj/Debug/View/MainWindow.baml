   M S B A M L   `   `   `  ����M  IDesktopDataGrabber, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:DesktopDataGrabber.ViewModelDesktopDataGrabber.ViewModel  5   	   (    "DesktopDataGrabber.View.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   R NOxyPlot.Wpf, Version=2.0.0.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0 oxyhttp://oxyplot.org/wpf  5   	   3vm*clr-namespace:DesktopDataGrabber.ViewModel  5   	     � Title$  Aplikacja Skibki��5	   	   $	��450��6"   $	��900��6/    � DataContext 5
      0   *DesktopDataGrabber.ViewModel.MainViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ MenuBtn��5      $��0��5      $��1��6   $��70��5      $
��Left=�6   $
��15,5q�63   .��6A   Menu5      � 5    
   -   5         �Name$
 Menu��5!      $��0��5       $��0��6   $��4��6,   
����� �$	��150��5"   %    5#      �� 5$      $
��Auto �6    �� 5%      $
��Auto �6    �� 5&      $
��Auto �6    .+�5(      �� -   5        $��0��5(      $	��120��6"   $��5q�6.   .��6S   TEMPERATURE6`   �� 5)      -   5        $��1��5)      $	��120��6"   $��5q�6.   .��6L   LEDs6R   �� 5*      -   5        $��2��5*      $	��120��6"   $��5q�6.   .��6Q   
TABLE INFO6]   5+        OxyPlot.Wpf.PlotView  5-   
   -   5          Name$ DataPlotView��5-      $��1��5.      $��1��6$   $��0,0,10,0q�5/         Model 50      �� *DataPlotModel+� 53   
   $��2��6   $��1��6    54      �� 55      $
��Auto �6#   �� 56      $��* �6#   �� 57      $
��Auto �6#   �� 58      $
��Auto �6#   �� 59      $
��Auto �6#   .+�5;      �� $��0��5<      $��
20,10,0,10q�5=      $��IP address: ��5>      $��Center=�6%   �� 5?      $��1��5@      $��	0,10,0,10q�5A      $	��110��5B      $
��Left=�5C      ��5D      �� *	IpAddress+�� 5E      $��2��5F      $��	0,10,0,10q�5G      $��Sample time: ��5H      $��Right=�5I      $��Center=�6-   �� 5J      $��3��5K      $��	0,10,0,10q�5L      $��50��5M      $
��Left=�5N      ��5O      �� *
SampleTime+�� 5P      $��4��5Q      $��
0,10,20,10q�5R      $	�� ms��5S      $��Right=�5T      $��Center=�6-   5U      � 5W   
   $��3��6   $��1��6    5X      �� 5Y      $��* �6#   �� 5Z      $
��Auto �6#   �� 5[      $
��Auto �6#   �� 5\      $��* �6#   .+�5^      �� $��0��5_      $��30��5`      $	��150��5a      $��
0,10,30,10q�5b      $��Right=�5c   1   ��6   �� *StartButton+.��6M   START5e      �� 5f      $��1��5g      $��30��5h      $	��150��5i      $��
0,10,15,10q�5j      ��5k      �� *
StopButton+.��60   STOP5m      �� 5n      $��2��5o      $��30��5p      $	��150��5q      $��
15,10,0,10q�5r      $
��Left=�5s   8   ��6   �� *UpdateConfigButton+.��6S   UPDATE CONFIG5u      �� 5v      $��3��5w      $��30��5x      $	��150��5y      $��
30,10,0,10q�5z      $
��Left=�5{   9   ��6   �� *DefaultConfigButton+.��6T   DEFAULT CONFIG5}      5~      5      5�      