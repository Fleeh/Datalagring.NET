   M S B A M L   `   `   `  ����H  DErrandHandler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ErrandHandler.ViewsErrandHandler.Views  5      $    ErrandHandler.Views.ErrandView   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:ErrandHandler.Views     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   .+�5      �  � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� $��0��6   $��Errands��6,   $��18(�6;   $
��Left=�6I   $��7q�6d   $��Center=�6o   5      � 5      $��7q�6    5      �� 5      $
��0.1* �6'   �� 5      $��0.5 * �6'   �� 5      $
��0.5* �6'   �� 5      $
��1.5* �6'   �� 5      $
��0.5* �6'   �� 5       $
��0.5* �6'   �� 5!      $
��0.3* �6'   .+�5%      �� $��0��6   $��#��6,   �� 5&      $��1��6   $��Customer Email��6,   �� 5'      $��2��6   $��Errand Title��6,   �� 5(      $��3��6   $��Errand Description��6,   �� 5)      $��4��6   $��Creation Date��6,   �� 5*      $��5��6   $��Last Modified Date��6,   �� 5+      $��6��6   $��Status��6,   5.      5/      �� 52   
   -   5         ��Name$ lvErrand��52       � DataContext$ Wpf.Models.Errand��6%   $��1��6E   
������ $��Stretch=�6k   $��Stretch=�6�   ��53      �� 54      .R�55      �  56      �� 57      $
��0.1* �6/   �� 58      $
��0.5* �6/   �� 59      $
��0.5* �6/   �� 5:      $
��1.5* �6/   �� 5;      $
��0.5* �6/   �� 5<      $
��0.5* �6/   �� 5=      $
��0.3* �6/   .+�5B      �� $��0��6$   ��64   �� *Id+�� 5C      $��1��6$   ��64   �� *DisplayCustomer+�� 5D      $��2��6$   ��64   �� *ErrandTitle+�� 5E      $��3��6$   ��64   �� *ErrandDescription+�� 5F      $��4��6$   ��64   �� *CreationDate+�� 5G      $��5��6$   ��64   �� *LastModifiedDate+�� 5H       ��Name$ cbRole��6#   $��6��63   $��0 3 0 5q�6C    �� Text 6T   �� *cbRole+5K      5L      5N      5O      5P      