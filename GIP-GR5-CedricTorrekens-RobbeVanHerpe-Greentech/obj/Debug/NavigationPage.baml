   M S B A M L   `   `   `  ����j  fGIP-GR5-CedricTorrekens-RobbeVanHerpe-Greentech, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullq=clr-namespace:GIP_GR5_CedricTorrekens_RobbeVanHerpe_Greentech/GIP_GR5_CedricTorrekens_RobbeVanHerpe_Greentech  5   	   D    >GIP_GR5_CedricTorrekens_RobbeVanHerpe_Greentech.NavigationPage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QScottPlot.WPF, Version=4.1.35.0, Culture=neutral, PublicKeyToken=e53b06131e34a3aaW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Olocal=clr-namespace:GIP_GR5_CedricTorrekens_RobbeVanHerpe_Greentech     5   	     � Title$  	GreenTech��5   	   $	��710��6   $
��1011��6(    � WindowState$ 	Maximized=�65    � Icon$ logoEcoRoute-Small.png��6M   $
��1011��6k   $	��710��6{   .��5      �  � 	Resources 5   
      MyButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Padding��%�  &	        �� 5      " ��6*   .�5      ��  � ��
 �����6/   �� 5       � ��$ SemiBold"�6/   �� 5       � ��$ 8,4,8,4q�6+   �� 5       � ��$ 6q�6,   �� 5       � ��$ 1q�64   �� 5       � �� 5       �� 5!      " ��6*   .R�5"      �� #��z��6%   #��z��5#      #��z��5$      #��z��5%      # z��5&      ._�5'   "   �� $��Center=�63   $��Center=�6P   5(      5)      5+      5,      5-      	 � ColumnDefinitions	 5/   
   �� 50      $��100px �6   �� 51      .+�54   
   �� ���	#FFC4C4C4.+�55      �� $
��70px��6   $��logoEcoRoute-Small.png��6"   $��	0,20,0,10q�6B   �� 57      -   5        
 ��Name$
 btnHome��57      #���   6&   $��55��6e    �� BitmapScalingMode$ HighQuality=�6q    �� EdgeMode$ Aliased=�6�    � Cursor$
 Hand��6�   $
��8,10q�6�   ��6N   Z� ��58      �� 59       �� ImageSource$ Icons/home.png��6!    j� Stretch$ Uniform=�6>   5;      �� 5=      -   5        $
 btnMap��5=      #���   6%   $��55��6d   $ HighQuality=�6p   $ Aliased=�6�   $
 Hand��6�   $
��8,10q�6�   ��6M   Z� ��5>      �� 5?      $ Icons/placeholder.png��6!   $ Uniform=�6E   5A      �� 5C      -   5        #���   5C      $��55��6T   $ HighQuality=�6`   $ Aliased=�6�   $
 Hand��6�   $
��8,10q�6�   ��6=   Z� ��5D      �� 5E      $ Icons/search.png��6!   $ Uniform=�6@   5G      �� 5I      -   5        #���   5I      $��55��6T   $ HighQuality=�6`   $ Aliased=�6�   $
 Hand��6�   $
��8,10q�6�   ��6=   Z� ��5J      �� 5K      $ Icons/database.png��6!   $ Uniform=�6B   5M      5N      �� 5P   
   ���	#FFC4C4C4$��Bottom=�6,   .+�5Q      �� -   5        #���   5Q      $��55��6T   $ HighQuality=�6`   $ Aliased=�6�   $
 Hand��6�   $
��8,10q�6�   ��6=   Z� ��5R      �� 5S      $ Icons/user.png��6!   $ Uniform=�6>   5U      �� 5W      -   5        #���   5W      $��55��6T   $ HighQuality=�6`   $ Aliased=�6�   $
 Hand��6�   $
��8,10q�6�   ��6=   Z� ��5X      �� 5Y      $ Icons/settings.png��6!   $ Uniform=�6B   5[      �� 5]      -   5        #���   5]      $��55��6T   $ HighQuality=�6`   $ Aliased=�6�   $
 Hand��6�   $
��8,10q�6�   ��6=   Z� ��5^      �� 5_      $ Icons/exit.png��6!   $ Uniform=�6>   5a      5b       � 5e   
   -   5          �Name$
 Main��5e      $��1��6   $��10��6.     � NavigationUIVisibility$ Hidden=�6@   5g      5h      