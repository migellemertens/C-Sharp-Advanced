   M S B A M L   `   `   `  ����C  ?Login UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Login_UILogin_UI  5   	       Login_UI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Login_UI     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��380��6)    � AllowsTransparency . 
������  � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��2��6'   ��5      �� 5      .��5      �  � Color$ #7be9f6��6'    � Offset$	 0.0Q�67   � 5      $ #f083da��6'   $ 1Q�67   5      5      �� 5      $��Center=�6   .+�5      �� $��img/logo.png��6   $��80��6.   �� 5      $��Login Window��6   $��Light"�60   $��	helvetica)�6C   $��22(�6Z   
�������$��Center=�6{   5       �� 5"      $��1��6   .+�5#      �� 	 �� Orientation$	 
Horizontal=�6   .+�5$      �� $��	helvetica)�6   $��Light"�65   $��Username��6H   $��20(�6X   $��Center=�6f   
�������
������ $��0q�6�   $	��235��6�   $
��Left=�6�   
 J� Opacity$	
 0.5Q�6�   $��25��6�   $��63,0,0,0q�6  �� 5%      $��img/user.png��6   $��20��62   5&      �� 5'      $	��250��6   $��2��6%   
�������$	
 0.5Q�6C   5(      �� 5*      $��1��6   .+�5+      �� $	 
Horizontal=�6   .+�5,      �� $��	helvetica)�6   $��Light"�65   $��Username��6H   $��20(�6X   $��Center=�6f   
�������
������ $��0q�6�   $	��235��6�   $
��Left=�6�   $	
 0.5Q�6�   $��25��6�   $��63,0,0,0q�6  �� 5-      $��img/user.png��6   $��20��62   5.      �� 5/      $	��250��6   $��2��6%   
�������$	
 0.5Q�6C   �� 51      $	 
Horizontal=�6   $��0,20,0,0q�66   .+�52      G� $��	helvetica)�6"   $��Light"�69    G� Password$ Password��6L   $��20(�6`   $��Center=�6n   
�������
������ $��0q�6�   $	��235��6�   $
��Left=�6�   $	
 0.5Q�6�   $��25��6  $��63,0,0,0q�6  �� 53      $��img/key.png��6   $��20��61   54      �� 55      $	��250��6   $��2��6%   
�������$	
 0.5Q�6C   �� 56      $	 
Horizontal=�6   $��0,50,0,0q�66   .+�57      �� $	��100��6   $��40��6)   $��LOGIN��65   $��60,0,0,0q�6E   �� 58      $	��100��6   $��40��6)   $��REGISTER��65   $��60,0,0,0q�6H   59      5:      5>      5?      5@      