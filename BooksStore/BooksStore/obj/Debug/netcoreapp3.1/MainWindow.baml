   M S B A M L   `   `   `  ����E  ABooksStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:BooksStore
BooksStore  5   	       BooksStore.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:BooksStore     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$ SingleBorderWindow=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � Icon$ /Image/LogoIcon.png��5   	    � Title$ CompileHeart��5      $	��720��6   $
��1280��6'   .��5      � .+�5   
   �  � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $	��405 �6#   �� 5      $��* �6#    � RowDefinitions 5      �� 5      $	��120 �6    �� 5      $	��200 �6    �� 5      $	��120 �6    �� 5      $	��100 �6    �� 5      $��* �6    .+�5      �� $��1��6   $��1��6!   $!��Image/LogoCompileheart1.png��61   $��Center=�6V   $��Center=�6q   $	��400��6�   �� 5      $��2��6   $��1��6%   $��Email��65   $��Center=�6B   $	��Top=�6_   $��80��6w   $��25��6�   $��	0,0,310,0q�6�   ���	#FFE89505
������� �� TextAlignment$ Center=�6�   $
��Bold"�6�   $��15(�6�   �� 5      $��2��6   $��1��6%   $��Password��65   $
��Left=�6E   $��Center=�6`   $��80��6{   $��25��6�   $��6,0,0,0q�6�   ���	#FFE89505
�������$ Center=�6�   $
��Bold"�6�   $��15(�6�   �� 5      -   5         ��Name$ txtEmail��5      $��2��6(   $��1��65   $	��320��6E   $��25��6Q   $��Right=�6]   $	��Top=�6y   $��15(�6�   $
��Bold"�6�   G� 5      -   5        	 G�Name$	 txtPassword��5      $��2��6/   $��1��6<   $	��320��6L   $��25��6X   $��Right=�6d   $��Center=�6�   $
��Bold"�6�   $��15(�6�   �� 5       -   5        
 ��Name$
 LoginButton��5       $��3��6*   $��1��67   $	��100��6G   $
��Left=�6S   $��	78,0,0,60q�6n   $'��!เข้าสู่ระบบ��6�   ���	#FFE89505
�������$��15(�6�   $
��Bold"�6�   $��Segoe UI)�6�   ��6�   Z� 6  �� 5!      -   5        $
 RegisterButton��5!      $��3��6-   $��1��6:   $	��100��6J   $��40��6V   $��Center=�6b   $	��Top=�6   $��	150,0,0,0q�6�   $'��!สมัครสมาชิก��6�   
����������	#FF1EADFF$
��Bold"�6  $��15(�6  ��6�   Z� 6!  �� 5"      -   5        $
 
ClearLogin��5"      $��4��6)   $��2��66   $	��100��6F   $��40��6R   $��Right=�6^   $��Bottom=�6z   $��0,0,0,0q�6�   $��
LoginClear��6�   
����������	#FFFF1E1E$
��Bold"�6�   $��15(�6  ��6�   Z� 6  �� 5#      -   5        $
 ClearCustomer��5#      $��4��6,   $��2��69   $	��100��6I   $��40��6U   $��Right=�6a   $��Bottom=�6}   $��	0,0,100,0q�6�   $��CTMClear��6�   
����������	#FFFF8000$
��Bold"�6�   $��15(�6  ��6�   Z� 6  �� 5$      -   5        $
 	ClearBook��5$      $��4��6(   $��2��65   $	��100��6E   $��40��6Q   $��Right=�6]   $��Bottom=�6y   $��	0,0,200,0q�6�   $��	BookClear��6�   
����������	#FF003AFF$
��Bold"�6�   $��15(�6  ��6�   Z� 6  5%      5&      5'      