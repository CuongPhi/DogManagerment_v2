   M S B A M L   `   `   `  ����   
SourceCode    SourceCode.SoQuy   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     $
��auto��.��� -     �Name$  UCSoQuy��
����ح� � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto � � ColumnDefinitions �� $	��240 ��� $
��auto �$	��498��.+�#  MaterialDesignThemes.Wpf.Card  $��0��$��2��
����ح�$��42��.��� .+��� $��	400 0 0 0q�$��24(�$
��Bold"�$	��333��$��SỔ QUỸ TIỀN MẶT��  $��1��$��0��$��42��.���� $��10 2 2 2q�.+��� $��18(�
����� �$��-5,2,2,2q�.��Tìm kiếm  $��2��$��0��$��35��.���� .+��� 
�������$��-8,5,2,5q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Theo mã phiếu�� %  !MaterialDesignFloatingHintTextBox#��[  $	��140������ *	ID_BILL+  $��3��$��0��$��35��.���� .+�o� 
����� �.@�m� 
����� �$��Trạng thái��.@�	�  	� 	GroupName$ 	trangthai��$��Đã thanh toán��	� $ 	trangthai��$��
Đã hủy��  $��4��$��0��$��35��.���� .+�o� 
����� �.@�m� 
����� �$��Thời gian��.@�	� $ thoigian��.���� .@��� .��1�� .��2�� .��3�� .��4�� .��5��  �� 
IsSelected . .��6�� .��7�� .��8�� .��9�� .��10�� .��11�� .��12	� $ thoigian��.��(  "System.Windows.Controls.DatePicker  $��5q�$ Lựa chọn khác�� ( $MaterialDesignFloatingHintDatePicker#��[   $��5��$��0��$��35��.���� .+�o� $	��180��$	��200��
����� �.@�m� 
����� �$��Người tạo��.@��� 
�������$��-8,5,2,5q�$ Theo mã phiếu��#��[  $	��140��  $��1��$��1��$��2��$��73��.���� $��Right=�.+�� .+��� .��Quỹ đầu kì�� .��
Tống thu�� .��
Tổng chi�� .��Tồn quỹ� .+��� 
�������$��-8,5,2,5q�$ 0��#��[  $��80������ *
QuyDauKi+�� 
�������$��-8,5,2,5q�$ 0��#��[  $��80������ *	TongThu+�� 
�������$��-8,5,2,5q�$ 0��#��[  $��80������ *	TongChi+�� 
�������$��-8,5,2,5q�$ 0��#��[  $��80������ *TonQuy+  $��1��$��3��$��2��$��50��.���� $
��Auto=�$
��Auto=�.���� ���� *List+ �� SelectedItem �� *SelectedItem+ �� Mode$ OneWayToSource=� �� View �� .P��� $��Mã phiếu��	 �� DisplayMemberBinding	 �� *	ID_BILL+�� $��Thời gian��	 �� *
DAY_BILL+�� $��Loại thu chi��	 �� *TYPE+�� $��Người nộp/nhận��	 �� *	ID_USER+�� $��
Giá trị��	 �� *FINE+