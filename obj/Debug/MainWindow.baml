   M S B A M L   `   `   `  ����?  ;ASM3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ASM3ASM3  5   	       ASM3.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:ASM3     5   	     � Title$  Beehive Management System��5   	   $	��450��6+   $	��800��68    � WindowStartupLocation$ CenterScreen=�6D   
�������.��5
      �  � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��60 �6   6*   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   �� $��Job Assignment��6   $��Center=�6*   $��Center=�6E   $��30(�6b   �� 5   
   $��1��6   $��Queen's Report��6$   $��Center=�6:   $��Center=�6U   $��30(�6r   �� 5   
   -   5        $��jobSelector��5      $��1��5      $��0��5      $��
10,10,10,0q�5      $
��auto��6'   $��40��5       �� Text$ 	Bee Types��5       $	��Top=�5"      .@�5#      �� .��6   Nectar Collector6,   �� 5$      .��6   Honey Manufacturer6.   �� 5%      .��6   
Egg Care6$   5&      �� 5(   
   -   5        $��	assignJob��5(      $��Assign this job to a bee��5)      $��1��5*      $��0��5+      $��Center=�5,      $��	10,0,10,0q�5-      $
��auto��6$   $��30��5.      ��50      �� 51       �� 
TargetType" ��6"   .R�52      �� #��z��6   #��z��53      #��z��54       �� CornerRadius$ 10��55      ._�56      �� $��Center=�6+   $��Center=�57   +   58      59      5;      �� 5=   
   -   5        $��queenReport��5?      $��1��5=      $��1��6   $��2��5>      $��2��6#   $��20(�5@      $	��330��5A      $	��375��6   5B      �� 5D   
   -   5        $��workNextShift��5D      $��Work the next shift��5E      $��2��5F      $��0��5G      $	��Top=�5H      $��
10,44,10,0q�5I      $
��auto��6%   $	��100��5J      ��5L      �� 5M      " ��6"   .R�5N      �� #��z��6   #��z��5O      #��z��5P      $ 15��5Q      ._�5R      �� $��Center=�6+   $��Center=�5S   +   5T      5U      5W      5X      5Y      