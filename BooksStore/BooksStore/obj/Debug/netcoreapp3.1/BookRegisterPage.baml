   M S B A M L   `   `   `  ����E  ABooksStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:BooksStore
BooksStore  5   	   !    BooksStore.BookRegisterPage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:BooksStore     5   	     � WindowStartupLocation$  CenterScreen=�5       � WindowStyle$ SingleBorderWindow=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � Icon$ /Image/LogoIcon.png��5   	    � Title$ Register��5      $	��720��6   $	��500��6#   .��5      �  � RowDefinitions 5   
   �� 5      $	��120 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $��80 �6   �� 5      $��80 �6   .+�5   
   �� $��1��6   $
��ISBN��6!   $��Center=�6-   $��Center=�6H   $��
0,0,180,45q�6e   $��18(�6y   ���	#FFE89505$��70��6�   $��25��6�   
������� �� TextAlignment$ Center=�6�   $
��Bold"�6�   �� 5   
   $��1��6   $��Title��6!   $��Bottom=�6.   $��Center=�6I   $��	0,0,170,0q�6f   $��18(�6y   ���	#FFE89505$��80��6�   $��25��6�   
�������$ Center=�6�   $
��Bold"�6�   4  .System.Windows.Automation.AutomationProperties   IsColumnHeader$
 True��6�   �� 5   
   $��2��6   $��Description��6!   $��Center=�64   $��Center=�6O   $��
0,30,150,0q�6l   $��18(�6�   ���	#FFE89505$	��100��6�   $��25��6�   
�������$ Center=�6�   $
��Bold"�6�   �� 5   
   $��3��6   $��Price��6!   $��Center=�6.   $��Center=�6I   $��
0,0,170,45q�6f   $��18(�6z   ���	#FFE89505$��80��6�   $��25��6�   
�������$ Center=�6�   $
��Bold"�6�   �� 5   
   $��0��6   $6��0ลงทะเบียนหนังสือ��6!   $��Center=�69   $��Center=�6T   $��60(�6q   ���	#FF5353536   �� 5   
   -   5         ��Name$ txtISBN��5      $��1��6#   $��Center=�60   $��Center=�6K   $	��250��6h   $��25��6t   $
��Bold"�6�   $��15(�6�   ${�False��6�   �� 5   
   -   5        $ txtTitle��5      $��2��6$   $	��Top=�61   $��Center=�6I   $	��250��6f   $��25��6r   $��15(�6~   $
��Bold"�6�   �� 5   
   -   5        $ txtDescription��5      $��2��6*   $��Bottom=�67   $��Center=�6R   $	��250��6o   $��25��6{   $��15(�6�   $
��Bold"�6�   �� 5   
   -   5        $ txtPrice��5      $��3��6$   $��Center=�61   $��Center=�6L   $	��250��6i   $��25��6u   $��15(�6�   $
��Bold"�6�   �� 5    
   -   5        	 ��Name$	 
SaveButton��5       $��4��6   $��บันทึก��62   $��Center=�6C   $��Center=�6`   $	��120��6{   $��40��6�   $��18(�6�   $
��Bold"�6�   
����������	#FF1EADFF��6�   Z� 6�   5!      5"      