   M S B A M L   `   `   `  ����  
SourceCode    SourceCode.NhanVien   5      V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      � -   5          �Name$  
UCNhanVien��5      
����ح� � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��0��6   $��5q�6+   .��5      � .+�5      �� $��5 5 15 5q�62   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Cân nặng��6D    %  !MaterialDesignFloatingHintTextBox#��[  6n   ��6   �� *WEIGHT+6n   �� 5      $��5 5 15 5q�60   $ Loại��6B   #��[  6h   ��6   �� *TYPE+6h   �� 5      $��5 5 15 5q�65   $ Tiền thức ăn��6G   #��[  6u   ��6   �� *	FOODPRICE+6u   �� 5      $��5 5 15 5q�66   $ Chuồng��6H   #��[  6p   ��6   �� *
IDDOGHOUSE+6p   �� 5      $��5 5 15 5q�62   $ 	Đường��6D   #��[  6k   ��6   �� *STREET+6k   �� 5      $��5 5 15 5q�60   $ 	Phường��6B   #��[  6j   ��6   �� *WARD+6j   �� 5      $��5 5 15 5q�64   $ Quận��6F   #��[  6l   ��6   �� *
DISTRICT+6l   (  "System.Windows.Controls.DatePicker  5      $��Center=�6   $	��100��6W   $��	5 5 15 -7q�6c   $ Ngày vào��6v    ( $MaterialDesignFloatingHintDatePicker#��[ 6�      SelectedDate 68   �� *DAYIN+6�   )  #MaterialDesignThemes.Wpf.TimePicker  5      $��Center=�6,   $	��100��6e   $��	5 5 15 -7q�6q   $ Giờ bắt��6�    ( $MaterialDesignFloatingHintTimePicker#��[ 6�      SelectedTime 6G   �� *TIME+6�   5      5        5   
   $��1��6   $��5q�6+   .��5       � .+�5!      �� $��	15 5 15 5q�6.   $ Mã cần tìm��6A   #��[  6m   ��6   �� *ID+6m   5"      5#        5$   
   $��2��6   $��5q�6+   .��5%      � .+�5&      �� $��Thêm��68   $��
150 5 15 5q�6G   $	��120��6[   ��6   �� *
AddCommand+6i   �� 5'      $��Cập nhật��69   $��5 5 15 5q�6L   $	��120��6^   ��6   �� *EditCommand+6l   �� 5(      $
��Xóa��6;   $��5 5 15 5q�6I   $	��120��6[   ��6   �� *DeleteCommand+6i   5)      5*        5+   
   $��3��6   $��5q�6+   .��5,      �� $
��Auto=�6   $
��Auto=�6>   .��5-      �� ��6   �� *List+ �� SelectedItem 68   �� *SelectedItem+ �� Mode$ OneWayToSource=� �� View 5.      �� 5/      .P�50      �� $��ID��6-    �� DisplayMemberBinding 69   �� *ID+6_   �� 51      $��Chuồng��6-    6=   �� *
IDDOGHOUSE+6k   �� 52      $��Cân nặng��6-    6?   �� *WEIGHT+6i   �� 53      $��Loại��6-    6;   �� *TYPE+6c   �� 54      $��
Ngày vào��6-    6?   �� *DAYIN+6h   �� 55      $��Giờ bắt��6-    6>   �� *TIME+6f   �� 56      $��	Đường��6-    6<   �� *STREET+6f   �� 57      $��	Phường��6-    6=   �� *WARD+6e   �� 58      $��Quận��6-    6;   �� *
DISTRICT+6g   �� 59      $��Giá thức ăn��6-    6B   �� *	FOODPRICE+6o   5:      5<      5=      5>      5?      5@      