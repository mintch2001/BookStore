   M S B A M L   `   `   `  ����E  ABooksStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:BooksStore
BooksStore  5   	   "    BooksStore.CustomersEditPage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:BooksStore     5   	     � WindowStartupLocation$  CenterScreen=�5       � WindowStyle$ SingleBorderWindow=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � Icon$ /Image/LogoIcon.png��5   	    � Title$ CompileHeart��5      $	��720��6   $	��500��6'   .��5      �  � RowDefinitions 5   
   �� 5      $	��120 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $��80 �6   �� 5      $��80 �6   .+�5   
   �� $��1��6   $��Center=�6"   $��Center=�6=   $��
120,0,0,45q�6Z   $����*โปรดกรอก Email ของผู้ที่ลงทะเบียนแล้วที่ช่องนี้��6n   
���  ��6�   �� 5   
   $��1��6   $��Email��6!   $��Center=�6.   $��Center=�6I   $��
0,0,180,45q�6f   $��18(�6z   ���	#FFE89505$��70��6�   $��25��6�   
������� �� TextAlignment$ Center=�6�   $
��Bold"�6�   �� 5   
   $��1��6   $
��Name��6!   $��Bottom=�6-   $��Center=�6H   $��	0,0,170,0q�6e   $��18(�6x   ���	#FFE89505$��80��6�   $��25��6�   
�������$ Center=�6�   $
��Bold"�6�   �� 5   
   $��2��6   $��Surname��6!   $��Center=�60   $��Center=�6K   $��
0,30,150,0q�6h   $��18(�6|   ���	#FFE89505$	��100��6�   $��25��6�   
�������$ Center=�6�   $
��Bold"�6�   �� 5   
   $��3��6   $��ID Card��6!   $��Center=�60   $��Center=�6K   $��
0,0,170,45q�6h   $��18(�6|   ���	#FFE89505$��80��6�   $��25��6�   
�������$ Center=�6�   $
��Bold"�6�   �� 5   
   $��3��6   $��Address��6!   $��Bottom=�60   $��Center=�6K   $��	0,0,170,0q�6h   $��18(�6{   ���	#FFE89505$��80��6�   $��25��6�   
�������$ Center=�6�   $
��Bold"�6�   �� 5   
   $��0��6   $*��$จัดการข้อมูล��6!   $��Center=�65   $��Center=�6P   $��60(�6m   ���	#FF5353536{   �� 5   
   -   5         ��Name$ txtEmail��5      $��1��6$   $��Center=�61   $��Center=�6L   $	��250��6i   $��25��6u   $
��Bold"�6�   $��15(�6�   �� 5    
   -   5        $ txtName��5       $��2��6#   $	��Top=�60   $��Center=�6H   $	��250��6e   $��25��6q   $��15(�6}   $
��Bold"�6�   ${�False��6�   �� 5!   
   -   5        $ 
txtSurname��5!      $��2��6&   $��Bottom=�63   $��Center=�6N   $	��250��6k   $��25��6w   $��15(�6�   $
��Bold"�6�   ${�False��6�   �� 5"   
   -   5        $ 	txtIDCard��5"      $��3��6%   $��Center=�62   $��Center=�6M   $	��250��6j   $��25��6v   $��15(�6�   $
��Bold"�6�   ${�False��6�   �� 5#   
   -   5        $ 
txtAddress��5#      $��4��6&   $	��Top=�63   $��Center=�6K   $	��250��6h   $��25��6t   $��15(�6�   $
��Bold"�6�   ${�False��6�   �� 5$   
   -   5         ��Name$ SearchDataButton��5$      $��4��6   $'��!ค้นหาข้อมูล��68   $��Center=�6N   $��Bottom=�6k   $	��120��6�   $��40��6�   $��18(�6�   $
��Bold"�6�   
����������	#FF991EFF��6�   Z� 6�   �� 5%   
   -   5        $ 
SaveButton��5%      $��5��6   $��บันทึก��62   $��Center=�6C   $��Center=�6`   $	��120��6{   $��40��6�   $��18(�6�   $
��Bold"�6�   
����������	#FF1EADFF��6�   Z� 6�   5&      5'      