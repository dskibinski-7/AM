   M S B A M L   `   `   `  ����M  IDesktopDataGrabber, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:DesktopDataGrabber.ViewModelDesktopDataGrabber.ViewModel  5   	   "    DesktopDataGrabber.View.Leds   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   R NOxyPlot.Wpf, Version=2.0.0.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0 oxyhttp://oxyplot.org/wpf  5   	   3vm*clr-namespace:DesktopDataGrabber.ViewModel  5   	     � Title$  Aplikacja Skibki��5	   	   $	��450��6"   $	��900��6/    � DataContext 5
      ,   &DesktopDataGrabber.ViewModel.LedsModel  5   
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
��Auto �6    .+�5(      �� -   5        $��0��5(      $	��120��6"   $��5q�6.   .��6S   TEMPERATURE6`   �� 5)      -   5        $��1��5)      $	��120��6"   $��5q�6.   .��6K   RPY6P   �� 5*      -   5        $��2��5*      $	��120��6"   $��5q�6.   .��6Q   
TABLE INFO6]   5+      � 5.   
   $��1��6   $��1��6    5/      �� 50      $
��Auto �6    �� 51      $
��Auto �6    �� 52      $
��Auto �6    �� 53      $
��Auto �6    .+�55      �� $��0��6   $��15q�6#   ��6/   �� *	DiodaText+6L   �� 56      $��1��6   $��15q�6#   ��6/   �� *DiodaWiersz+6N   �� 57      $��2��6   $��15q�6#   ��6/   �� *DiodaKolumna+6O   �� 58      $��3��6   $��15q�6#   ��6/   �� *	Kolorek+6J   5:      � 5>   
   $��3��6   $��1��6    5?      �� 5@      $��* �6#   �� 5A      $��* �6#   .+�5C      �� $��0��5D      $��30��5E      $	��150��5F      $��
0,10,30,10q�5G      $��Center=�5H   4   ��6   �� *SetDiodsButton+.��6Q   USTAW DIODY5J      �� 5K      $��1��5L      $��30��5M      $	��150��5N      $��
0,10,30,10q�5O      $��Center=�5P   3   ��6   �� *SetTextButton+.��6P   USTAW TEKST5R      5T      5U      5V      