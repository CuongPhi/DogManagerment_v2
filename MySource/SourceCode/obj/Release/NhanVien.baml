   M S B A M L   `   `   `  ����   
SourceCode    SourceCode.NhanVien   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .��� -     �Name$  
UCNhanVien��
����ح� � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+�#  MaterialDesignThemes.Wpf.Card  $��0��$��5q�.��� .+��� $��5 5 15 5q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Cân nặng�� %  !MaterialDesignFloatingHintTextBox#��[  ���� *WEIGHT+�� $��5 5 15 5q�$ Loại��#��[  ���� *TYPE+�� $��5 5 15 5q�$ Tiền thức ăn��#��[  ���� *	FOODPRICE+�� $��5 5 15 5q�$ Chuồng��#��[  ���� *
IDDOGHOUSE+�� $��5 5 15 5q�$ 	Đường��#��[  ���� *STREET+�� $��5 5 15 5q�$ 	Phường��#��[  ���� *WARD+�� $��5 5 15 5q�$ Quận��#��[  ���� *
DISTRICT+(  "System.Windows.Controls.DatePicker  $��Center=�$	��100��$��	5 5 15 -7q�$ Ngày vào�� ( $MaterialDesignFloatingHintDatePicker#��[    SelectedDate �� *DAYIN+)  #MaterialDesignThemes.Wpf.TimePicker  $��Center=�$	��100��$��	5 5 15 -7q�$ Giờ bắt�� ( $MaterialDesignFloatingHintTimePicker#��[    SelectedTime �� *TIME+  $��1��$��5q�.��� .+��� $��	15 5 15 5q�$ Mã cần tìm��#��[  ���� *ID+  $��2��$��5q�.��� .+��� $��Thêm��$��
150 5 15 5q�$	��120������ *
AddCommand+�� $��Cập nhật��$��5 5 15 5q�$	��120������ *EditCommand+�� $
��Xóa��$��5 5 15 5q�$	��120������ *DeleteCommand+  $��3��$��5q�.���� $
��Auto=�$
��Auto=�.���� ���� *List+ �� SelectedItem �� *SelectedItem+ �� Mode$ OneWayToSource=� �� View �� .P��� $��ID�� �� DisplayMemberBinding �� *ID+�� $��Chuồng�� �� *
IDDOGHOUSE+�� $��Cân nặng�� �� *WEIGHT+�� $��Loại�� �� *TYPE+�� $��
Ngày vào�� �� *DAYIN+�� $��Giờ bắt�� �� *TIME+�� $��	Đường�� �� *STREET+�� $��	Phường�� �� *WARD+�� $��Quận�� �� *
DISTRICT+�� $��Giá thức ăn�� �� *	FOODPRICE+