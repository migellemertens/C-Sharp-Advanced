   M S B A M L   `   `   `  ����O  KBlad Steen Schaar UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Blad_Steen_Schaar_UIBlad_Steen_Schaar_UI  5   	   %    Blad_Steen_Schaar_UI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Blad_Steen_Schaar_UI     5   	     � Title$  
MainWindow��5   	   $	��710��6   $
��1100��6)    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ CanResizeWithGrip=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency . ���#181735$��Fonts/#Dosis)�5   	    � 	Resources 5         closeButton �� 
TargetType �� Property �� Value	 �� 
TargetType
 �� Triggers P� Property P� Value  windowButton  topMenuItem m� IsSubmenuOpen � AllowsTransparency K� IsItemsHost �� Triggers  subMenuItem ]�Name �� 
TargetName  removeHighlight��%�	  &	        &	 �    'o� l    &	 [    &	      &	 �    �� 5   
   " ��6$   .�5      ��  � ��$ Fonts/#Dosis)�67   �� 5       � �� �#c80e0e6+   �� 5       � ��
 �����6+   �� 5       � �� 5      �� 5      "	 ��6&   .R�5      �� #��z��6!   ._�5      �� $��Center=�6/   $��Center=�6J   5      
 5      P� 5       �@J�IsMouseOver . . �5   "   ��  � �� �#9009096?   5       5"      5$      5%      �� 5(   
   " ��6%   .�5)      ��  � ��$ Fonts/#Dosis)�67   �� 5*       � �� �#0303226+   �� 5+       � ��
 �����6+   �� 5,       � �� 5-      �� 5.      "	 ��6&   .R�5/      �� #��z��6!   ._�50      �� $��Center=�6/   $��Center=�6J   51      
 52      P� 53       �@J�IsMouseOver . . �54   "   ��  � �� �#2828436?   55      57      59      5:      �� 5?   
   " o�6   .�5@      ��  � �� �#0F0F2D6+   �� 5A       � ��
 �����6+   �� 5B       � ��$ Fonts/#Dosis)�67   �� 5C       � ��$ 40��6'   �� 5D       � ��$ Stretch=�64   5E      �� 5I   
   "	 m�6.   .R�5J      �� $��18(�6   $��40��61   .+�5K      �� #��z��6   $��5,5,30,0q�6;   
�������6M   � 5N      #��z 6    . |�.  .��5O      �� $��1q�6   ���#0F0F2D���#0F0F2D._�5P      ��  . 6%   5Q      5R      ��5T      �� 5U      " ��6    5V      P� 5W       �@J�IsMouseOver . . �5X   "   ��  � �� �#0c87e56?   5Y      5[      5]      5^      �� 5a   
   "	 m�6.   .R�5c      ]� $ panel��60   $��18(�6   .+�5d      �� #��z��6   
�������$��0,5,5,5q�6N   � 5f      #��z 6    . |�.  $��Right=�6m   .��5g      �� $��1q�6   ���#0c87e5���#0c87e5._�5h      ��  . 6%   5i      5j      5k      
 5l      P� 5m       �@m�IsHighlighted . . �5n      �� $ panel��63    � �� �#0c87e56F   5o      5q      �� 5t   
   " ��6(   .�5u      ��  �@�OverridesDefaultStyle . 66   �� 5v       �@�Cursor$
 Hand��6'   �� 5w       � �� 5x      �� 5y      "	 ��6&   .R�5z      �� $��border��6!   #��z��6/   #��z��6c   #��z��6�   ._�5{      �� $��Center=�6/   $��Center=�6L   5|      
 5}      P� 5~       �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$ 1Q�6<   5�      5�      5�      5�      5�      .��5�      �  � RowDefinitions 5�   
   �� 5�      $��25 �6   �� 5�      $��40 �6   �� 5�      $	��80* �6   �� 5�      $	��20* �6   �� 5�      $��40 �6    � ColumnDefinitions 5�   
   �� 5�      $	��13* �6   �� 5�      $��20 �6   �� 5�      $	��68* �6   �� 5�      $	��20* �6   .+�5�   
   � -   5        ���#030322$��4��5�   $    5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      .+�5�      �� -   5         ��Name$ 
BtnSluiten��5�   :   #��[  6   $��X��6N   $��12(�6[   $��Medium"�6i   $��13��6}   6�   �� 5�      -   5        $ BtnMaximize��5�   ;   #��[ 6   $	��□��6P   $��20(�6b   $��Medium"�6p   $��12��6�   6�   �� 5�      -   5        $ BtnMinimize��5�   ;   #��[ 6   $��-��6P   $��14(�6\   $��Medium"�6j   $��11��6~   6�   5�      � 5�   
   $��4��6   $��1��6#   .+�5�      o� .@�5�      m� #��[ 6   $��Bestand��6C   .@�5�      m� #��[ 6   $��Sluiten��6G   5�      m� 5�      #��[ 6   $
��Help��6C   .@�5�      m� #��[ 6   $��Regels��6G   5�      5�      5�      �� 5�   
   $��2��6   $��1��6"   $��10q�67   .+�5�      �� -   5        $ btnBlad��5�      #��[ 6&   
������ 
������ $��0,0,0,20q�6�   .��5�      �� -   5         ��Name$ imgButtonBlad��5�      $��img/blad.png��6/    �� BitmapScalingMode$
 Fant=�6E   5�      �� 5�      -   5        $ btnSteen��5�      #��[ 6'   
������ 
������ $��0,0,0,20q�6�   .��5�      �� -   5        $ imgButtonSteen��5�      $��img/steen.png��60   $
 Fant=�6G   5�      �� 5�      -	   5        $ 	btnSchaar��5�      #��[ 6(   
������ 
������ .��5�      �� -
   5        $ imgButtonSchaar��5�      $��img/schaar.png��61   $
 Fant=�6I   5�      5�      �� 5�   
   $��4��6   $��4��6!   ���#0F0F2D
�������$��Stretch=�6]   .@�5�      �� $��Ready��6   
�������$��10,0,5,0q�6?   �� 5�      $��5,0,5,0q�6   .��5�      �� $��img/logo.png��6   5�      �� 5�      $��5,0,0,0q�6   .��5�      �� $��Migelle Mertens��6   
�������62   5�      �� 5�      $��Right=�6   .��5�      �� $ ��Hier komt de tijd te staan��6   
�������6=   5�      5�      � 5�   
   $��2��6   $��2��6    5�      �� 5�      $	��50* �6#   �� 5�      $	��50* �6#   .+�5     �� $��0��6   $��img/klok.png��6$   $��30q�6:   �� 5     $��1��6   $��img/klok.png��6$   $��30q�6:   5     (� 5  
   $��3��6   $��0��6   .��5     �� $��10��6   
�������$��Center=�64   $��Center=�6O   $	��100(�6l   5     � 5
  
   $��3��6   $��2��6    5     �� 5     $	��50* �6#   �� 5     $	��50* �6#   .+�5     (� $��0��6   .��5     �� $��10��6   
�������$��Center=�68   $��Center=�6S   $	��100(�6p   5     (� 5     $��1��6   .��5     �� $��10��6   
�������$��Center=�68   $��Center=�6S   $	��100(�6p   5     5     5     5     