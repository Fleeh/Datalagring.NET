   M S B A M L   `   `   `  ����H  DErrandHandler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ErrandHandler.ViewsErrandHandler.Views  5      %    ErrandHandler.Views.NewUserView   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:ErrandHandler.Views     5      .��5	      � $��-31,0,0,-186q�6     � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $
��182* �6   �� 5      $	��31* �6   .+�5   
   �� $��    New Customer��6   $��18(�6,   $
��Left=�6:   $��Center=�6U   �� 5   
   $��1��6   $��20,10,20,10q�6"   $��2��67   .+�5      �� $��
First Name��6   �� 5      -   5         ��Name$ tbFirstName��5      $��3q�6+   $��0 3 0 5q�67   �� 5      $��	Last Name��6   �� 5      -   5        $ 
tbLastName��5      $��3q�6*   $��0 3 0 5q�66   �� 5      $��Email��6   �� 5      -   5        $ tbEmail��5      $��3q�6'   $��0 3 0 5q�63   �� 5      $��Number��6   �� 5      -   5        $ tbNumber��5      $��3q�6(   $��0 3 0 5q�64   �� 5      $��Adress��6   �� 5      -   5        $ tbAdress��5      $��3q�6(   $��0 3 0 5q�64   �� 5      $��Zipcode��6   �� 5      -   5        $ 	tbZipcode��5      $��3q�6)   $��0 3 0 5q�65   �� 5      $
��City��6   �� 5      -   5        $ tbCity��5      $��3q�6&   $��0 3 0 5q�62   �� 5       $��Country��6   �� 5!      -   5        $ 	tbCountry��5!      $��3q�6)   $��0 3 0 5q�65   �� 5"      -	   5         ��Name$ btnAdd��5"      $��14(�6%   $��Create User��63   $
��0 10q�6I   6X   �� 5#      -
   5         ��Name$ lbError��5#      
���  ��$��14(�6:   $��20q�6H   $��Center=�6T   5&      5'      5(      