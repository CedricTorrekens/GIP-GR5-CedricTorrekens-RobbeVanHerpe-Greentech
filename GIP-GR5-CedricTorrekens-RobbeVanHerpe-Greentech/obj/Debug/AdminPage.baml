   M S B A M L   `   `   `  ����j  fGIP-GR5-CedricTorrekens-RobbeVanHerpe-Greentech, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullq=clr-namespace:GIP_GR5_CedricTorrekens_RobbeVanHerpe_Greentech/GIP_GR5_CedricTorrekens_RobbeVanHerpe_Greentech  5      X TXceed.Wpf.Toolkit, Version=4.2.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4P:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.ToolkitXceed.Wpf.Toolkit 5      ?    9GIP_GR5_CedricTorrekens_RobbeVanHerpe_Greentech.AdminPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QScottPlot.WPF, Version=4.1.35.0, Culture=neutral, PublicKeyToken=e53b06131e34a3aaW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Olocal=clr-namespace:GIP_GR5_CedricTorrekens_RobbeVanHerpe_Greentech     5      NwpfTool:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.Toolkit     5        N� Title$  	AdminPage��5
      .��5      � 
������� � 	Resources 5   
      MyButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Padding �� Triggers P� Property	 P� Value��%C  &	        �� 5      " ��6*   .�5      ��  � ��
 ���� 6/   �� 5       � ��$ SemiBold"�6/   �� 5       � ��$ 8,4,8,4q�6+   �� 5       � ��$ 6q�6,   �� 5        � ��$ 0q�64   �� 5!       � �� 5"      �� 5#      " ��6*   .R�5$      �� #��z��6%   #��z��5%      #��z��5&      #��z��5'      # z��5(      ._�5)   "   �� $��Center=�63   $��Center=�6P   5*      5+      5-       5.      P� 5/       �@J�IsMouseOver	 . . �50      ��  � �� �	#FF9C9C9C67   51      53      54      
 � ColumnDefinitions
 57   
   �� 58      �� 59       � RowDefinitions 5;   
   �� 5<      $��100px �6   �� 5=      .+�5@   
   �� $��0��6   $��2��6   $��Admin Dashboard��61   $��Center=�6K   $��
30,22,1,22q�6f   $��Open Sans SemiBold)�6z   $��34(�6�   $��56��6�   �� 5B   
   $��1��6   ���	#FFC4C4C4
������ $��0q�6O    �� CornerRadius$ 30,30,30,30��6c   $��15q�6~   ._�5C      �� $��0,10,0,0q�6   .+�5D      �� $��0��6   $��Modify Data��6%   $��Center=�6;   $��	30,0,1,22q�6V   $��Open Sans SemiBold)�6i   $��25(�6�   $��56��6�   � 5F      $��
35,0,30,30q�6   
 5G      �� 5H      $��250px��6+   �� 5I       5K      �� 5L      �� 5M      �� 5N      �� 5O      �� 5P      .+�5S      �� $��0��6   $��0��6)   $��Station ��69   $��	Open Sans)�6L   $��14(�6c   �� 5T      $��0��6   $��1��6,   $��Center=�6<   $��	Open Sans)�6W   $��14(�6n   $��300px��6|   $��350px��6�   $
��Left=�6�   �� 5V      $��1��6   $��0��6)   $��Date and time��69   $��	Open Sans)�6Q   $��14(�6h   &   Xceed.Wpf.Toolkit.DateTimePicker  5W      $��1��6-   $��1��6:   $��300px��6J   $��350px��6[   $��25��6l   $
��Left=�6x   �� 5Y      $��2��6   $��0��6)   $��	New value��69   $��	Open Sans)�6M   $��14(�6d   �� 5Z      $��2��6!   $��1��6.    �� Orientation$ 
Horizontal=�6>   .+�5[      �� $��200px��6"   $
��Left=�60   $��Center=�6K   $��	Open Sans)�6f   $��14(�6}   �� 5\      $��µm/m3��6    $��	Open Sans)�60   $��14(�6G   5]      �� 5`      $��3��6   $��0��6)   $��	Data Type��69   $��	Open Sans)�6M   $��14(�6d   �� 5a      $��3��6!   $��1��6.   .+�5b      	� $��PM 2.5��6&   $��	Open Sans)�67   $��14(�6N   $��0,8,0,0q�6\   	� 5c      $��PM 10��6&   $��	Open Sans)�66   $��14(�6M   $��0,4,0,0q�6[   	� 5d      $��Humidity��6&   $��	Open Sans)�69   $��14(�6P   $��0,4,0,0q�6^   	� 5e      $��Temperature��6&   $��	Open Sans)�6<   $��14(�6S   $��0,4,0,0q�6a   5f      �� 5h      $��4��6   $��Modify Data��6*   #���   6@   ���	#FF9C9C9C � Cursor$
 Hand��6   $��0,15,0,0q�6�   5j      5k      5l      �� 5n   
   $��1��6   $��1��6   ���	#FFC4C4C4
������ $��0q�6_   $ 30,30,30,30��6s   $��15q�6�   ._�5o      �� $��0,10,0,0q�6   .+�5p      �� $��0��6   $��Stations��6%   $��Center=�68   $��	30,0,1,22q�6S   $��Open Sans SemiBold)�6f   $��25(�6�   $��56��6�   �� 5r      $��1��6   $��
35,0,30,30q�6*   .+�5t      �� $ 
Horizontal=�6!   $��0,0,0,5q�6:   .+�5u      �� $��Icons/database.png��6    $
��55px��6<    �� BitmapScalingMode$ HighQuality=�6I   �� 5v      $��10,0,0,0q�6%   .+�5w      �� $��idStation: ��6$   $��	Open Sans)�6:   $��14(�6Q   �� 5x      $��Type of user: ��6$   $��	Open Sans)�6=   $��14(�6T   5y      5z      �� 5{      $ 
Horizontal=�6!   .+�5|      �� $��Icons/attention.png��6    $��30��6=   $��30��6I   $ HighQuality=�6T   $
��Left=�6�   �� 5}      $��Offline��6    $��10,0,0,0q�62   $��	Open Sans)�6D   $��14(�6[   5~      �� 5�      $ 
Horizontal=�6!   $��0,25,0,5q�6:   .+�5�      �� $��Icons/database.png��6    $
��55px��6<   $ HighQuality=�6I   �� 5�      $��10,0,0,0q�6%   .+�5�      �� $��idStation: ��6$   $��	Open Sans)�6:   $��14(�6Q   �� 5�      $��Type of user: ��6$   $��	Open Sans)�6=   $��14(�6T   5�      5�      �� 5�      $ 
Horizontal=�6!   .+�5�      �� $��Icons/approve.png��6    $��30��6;   $��30��6G   $ HighQuality=�6R   $
��Left=�6�   �� 5�      $��Online��6    $��10,0,0,0q�61   $��	Open Sans)�6C   $��14(�6Z   5�      �� 5�      $ 
Horizontal=�6!   $��0,25,0,5q�6:   .+�5�      �� $��Icons/database.png��6    $
��55px��6<   $ HighQuality=�6I   �� 5�      $��10,0,0,0q�6%   .+�5�      �� $��idStation: ��6$   $��	Open Sans)�6:   $��14(�6Q   �� 5�      $��Type of user: ��6$   $��	Open Sans)�6=   $��14(�6T   5�      5�      �� 5�      $ 
Horizontal=�6!   .+�5�      �� $��Icons/approve.png��6    $��30��6;   $��30��6G   $ HighQuality=�6R   $
��Left=�6�   �� 5�      $��Online��6    $��10,0,0,0q�61   $��	Open Sans)�6C   $��14(�6Z   5�      5�      5�      5�      5�      5�      