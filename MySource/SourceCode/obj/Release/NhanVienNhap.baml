   M S B A M L   `   `   `  ����   
SourceCode    SourceCode.NhanVienNhap   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .��� -     �Name$  UCNhanVienNhap��
����ح� � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+�#  MaterialDesignThemes.Wpf.Card  $��0��$��5q�.��� .+��� $��5 5 15 5q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mã hóa đơn�� %  !MaterialDesignFloatingHintTextBox#��[  ���� *	ID_BILL+�� $��5 5 15 5q�$ Mã nhân viên��#��[  ���� *	ID_USER+�� $��5 5 15 5q�$ Mã chó��#��[  ���� *ID_DOG+�� $��5 5 15 5q�$ Tiền phạt��#��[  ���� *FINE+(  "System.Windows.Controls.DatePicker  $��Center=�$	��100��$��	5 5 15 -7q�$ Ngày nhập hóa đơn�� ( $MaterialDesignFloatingHintDatePicker#��[    SelectedDate �� *
DAY_BILL+  $��1��$��5q�.��� .+��� $��	15 5 15 5q�$ Mã cần tìm��#��[  ���� *	ID_BILL+  $��2��$��5q�.��� .+��� $��Thêm��$��
150 5 15 5q�$	��120������ *
AddCommand+�� $��Cập nhật��$��5 5 15 5q�$	��120������ *EditCommand+�� $
��Xóa��$��5 5 15 5q�$	��120������ *DeleteCommand+  $��3��$��5q�.���� $
��Auto=�$
��Auto=�.���� ���� *List+ �� SelectedItem �� *SelectedItem+ �� Mode$ OneWayToSource=� �� View �� .P��� $��Mã hóa đơn�� �� DisplayMemberBinding �� *	ID_BILL+�� $��Mã nhân viên�� �� *	ID_USER+�� $��Mã chó�� �� *ID_DOG+�� $��Tiền phạt�� �� *FINE+�� $��Ngày nhập hóa đơn�� �� *
DAY_BILL+