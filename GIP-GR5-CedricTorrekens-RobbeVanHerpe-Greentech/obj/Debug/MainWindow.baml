   M S B A M L   `   `   `  ����j  fGIP-GR5-CedricTorrekens-RobbeVanHerpe-Greentech, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullq=clr-namespace:GIP_GR5_CedricTorrekens_RobbeVanHerpe_Greentech/GIP_GR5_CedricTorrekens_RobbeVanHerpe_Greentech  5   	   @    :GIP_GR5_CedricTorrekens_RobbeVanHerpe_Greentech.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QScottPlot.WPF, Version=4.1.35.0, Culture=neutral, PublicKeyToken=e53b06131e34a3aaW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Olocal=clr-namespace:GIP_GR5_CedricTorrekens_RobbeVanHerpe_Greentech     5   	   -   5          �Name$  LogIn��5   	    � Title$ 	GreenTech��5   	   $	��800��6   $
��1400��6(    � Icon$ logoEcoRoute-Small.png��65    � WindowStartupLocation$ CenterScreen=�6S    � 
ResizeMode$ CanMinimize=�6x   .��5      �  � 	Resources 5   
      TextBoxBaseControlTemplate �� 
TargetType ��Name �� CornerRadius	 ��Name
 �� Triggers P� Property P� Value �� Value �� 
TargetName �� Property  PasswordBox  MyButtonStyle �� 
TargetType �� Padding��%�  &	        &	 �    &	 �    �� 5      " ��6A   .R�5      �� $ Bd��5      #��z��5      
���   �#��z��5      $ 10��6E   ._�5      �� $	 PART_ContentHost��6#   5      
 5      P� 5       � {� .  . �5       �� # � ��67   $ Bd��6y    � ���� 5!      # � ��67    � ��5"      P� 5#       � ��$
 Auto��6/   . �5$      ��  � ��$	 100��65   5%      P� 5&       � ��$
 Auto��60   . �5'      ��  � ��$ 30��66   5(      5*      �� 5+      " G�62   .R�5,      �� $ Bd��5-      #��z��5,      
���   �#��z��5.      $ 10��6E   ._�5/      �� $	 PART_ContentHost��6#   50      51      �� 53      " ��6*   .�54      ��  �@�OverridesDefaultStyle . 6:   �� 55       � ��$ 5q�6+   �� 56       � �� 57      �� 58      " ��6*   .R�59      �� $��border��6%   $��1q�5:      $	 4,2q�5;      
������ $ 3��5=      #��z��5>      ._�5?   "   �� $��Center=�63   $��Center=�6P   5@      
 5A      P� 5B   "    �@J�IsMouseOver . . �5C   &   �� $ border��6-    � ��
 ���� 6X   5D   #   5F      5H      5I      5J      ��5L   
   �� 5M       �� ImageSource$6 0eberhard-grossgasteiger-y2azHvupCVo-unsplash.jpg��6    j� Stretch$ UniformToFill=�6X   .+�5O   
   �� $��0,175,120,175q�6   ���	#FFE7E7E7$��Right=�6?   $	��329��6[   $ 41��6g    J� Opacity$
 0.85Q�6y   ._�5P      �� .+�5Q      �� $��logoEcoRoute.png��6   $��
50,15,50,0q�62   $	��130��6F   �� 5R      $��Email��6   $��	30,15,0,0q�6)   $��Open Sans SemiBold)�6<   $��14(�6\   �� 5S      -   5         ��Name$ txtEmail��5S      $��Center=�6,   $��30��6N   $��	30,5,30,0q�6Z   4  .System.Windows.Automation.AutomationProperties   HelpText$ Email��6�   $��	Open Sans)�6�   $��Center=�6�   $��14(�6�   #���   6�   ��6m   Z� 6�   �� 5U      $��Password��6   $��	30,15,0,0q�6,   $��Open Sans SemiBold)�6?   $��14(�6_   G� 5V      -   5         G�Name$ txtPassword��5V      $��Center=�63   $��30��6U   $��	Open Sans)�6a   $��Center=�6x   $��14(�6�   $��	30,5,30,0q�6�   #���  6�   ��6�   Z� 6�   �� 5W      $��Forgot?��6   $��	35,3,35,0q�6+   $��Open Sans Condensed)�6>   $��14(�6_    �� TextAlignment$ Right=�6m   $��Italic$�6�    � Cursor$
 Hand��6�   �� 5Y      -   5         ��Name$ 	btnSignIn��5Y      $��Sign In��6,   $��	Open Sans)�6>   $��16(�6U   $��
30,20,30,0q�6c   ���	#FFCDCDCD
���   �$	 0.9Q�6�   
���   �$��35��6�   $
 Hand��6�    5Z      ��%_   '��       �� 5[      " ��6    .�5\      ��  �@��CornerRadius$ 10��6=   5]      5^      5_      �� 5`       �� Orientation$ 
Horizontal=�6   $��0,5,0,0q�66   .+�5a      �� $��Don't have an account?��6     J� RenderTransformOrigin$ 1.242,0.062&�6>   $��30,3,0,0q�6b   $��	Open Sans)�6t   �� 5b      -   5        $ 	btnSignUp��5b      $��Sign Up��60   $��Italic$�6B   $��	Open Sans)�6U   $��2,0,0,0q�6�   $��Center=�6�   #���  6�   $
 Hand��6�   ��6l   Z� ��6�   Z� 6�   5c      5e      5f      5h      5i      