   M S B A M L   `   `   `  ����   
SourceCode    SourceCode.ThongKeHoaDon   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .��� -     �Name$  UCThongKeHoaDon��
����ح� � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+�#  MaterialDesignThemes.Wpf.Card  $��0��
����ح�.���� $
��auto��$��24(�$
��Bold"�$��	200 5 5 5q�THỐNG KÊ HÓA ĐƠN  $��1��
�������.���� $��5q�.+��� .��	Xem theo:� .+�(  "System.Windows.Controls.DatePicker  $��5q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$$ Ngày cần xuất hóa đơn�� (  $MaterialDesignFloatingHintDatePicker#��[     SelectedDate �� *
DAY_BILL+�� .��Tháng�� -   $��thang��.@��� .��1��  �� 
IsSelected . .��2�� .��3�� .��4�� .��5�� .��6�� .��7�� .��8�� .��9�� .��10�� .��11�� .��12�� .��Năm�� -   $	��nam��.@��� .��2016��  . .��2017�� .��2018  $��2��
�������.��� .+��� $��Xem hóa đơn nhập��$��
150 5 15 5q�$	��150������ *BillIn+�� $��Xem hóa đơn thu��$��5 5 15 5q�$	��150������ *	BillOut+  $��3��.���� $
��Auto=�$
��Auto=�.���� ���� *List+ �� SelectedItem �� *SelectedItem+ �� Mode$ OneWayToSource=� �� View �� .P��� $��Mã hóa đơn�� �� DisplayMemberBinding �� *	ID_BILL+�� $��Mã nhân viên�� �� *	ID_USER+�� $��Mã chó�� �� *ID_DOG+�� $��Tiền phạt�� �� *FINE+�� $��Ngày nhập hóa đơn�� �� *
DAY_BILL+  $��4��
����ح�.���� .+�� $��	10 10 0 0q�.+��� $	��0 7q�.��Số lượng:�� $��10 0 0 5q�$ 0�� % !MaterialDesignFloatingHintTextBox#��[ ���� *	SoLuong+� $��	10 10 0 0q�.+��� $	��0 7q�.��
Doanh thu:�� $��10 0 0 5q�$ 0��#��[ ���� *
DoanhThu+  
������ $��0q�$��5��
����ح�.���� $"��Xuất danh sách hóa đơn��$	��190������ *
ExportBill+