   M S B A M L   `   `   `  ���� E  ASourceCode, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SourceCode
SourceCode      SourceCode.ListStaff   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     *localclr-namespace:SourceCode     V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  $
��auto��.��� -     �Name$  
UCNhanVien��
����ح� � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+�� $��0��.+���  �� Padding$ 5q�$��	220 0 0 0q� #  MaterialDesignDisplay1TextBlock#��[  QUẢN LÝ NHÂN VIÊN#  MaterialDesignThemes.Wpf.Card  $��1��$��5q�.��� -   $��SelectedItemWraPnel��$��Center=�$��Center=�$
��auto��.+��� $��14(�$��5 5 5 5q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mã NV�� % !MaterialDesignFloatingHintTextBox#��[ ���� *
IDPERSON+ �� Mode$ OneWay=��� $��14(�$��5 5 5 5q�$
 Tên��#��[ ���� *NAME+$ OneWay=��� $��14(�$��5 5 5 5q�$ Tài khoản��#��[ ���� *
USERNAME+$ OneWay=��� $��14(�$
��Nữ��$��	5 0 5 -10q��� $��14(�$��5 5 5 5q�$
 CMND��#��[ ���� *ID+$ OneWay=��� $��14(�$��5 5 5 5q�$ Lương��#��[ ���� *SALARY+$ OneWay=��� $��14(�$��5 5 5 5q�$
 BHYT��#��[ ���� *
ID_MEDICAL+$ OneWay=��� $��14(�$��5 5 5 5q�$
 TKNH��#��[ ���� *	ID_BANK+$ OneWay=��� $��14(�$��5 5 5 5q�$ Email��#��[ ���� *EMAIL+$ OneWay=��� $��14(�$��5 5 5 5q�$
 SĐT��#��[ ���� *PHONE+$ OneWay=�(  "System.Windows.Controls.DatePicker  $��Center=�$	��100��$��5 5 5 -5q�$ 
Ngày sinh�� ( $MaterialDesignFloatingHintDatePicker#��[    SelectedDate �� *	BIRHDAY+$ OneWay=�  $��Center=�$	��100��$��5 5 5 -5q�$ 	Vào C.Ty��#��[  �� *	DAYJOIN+$ OneWay=�  $��50��$��2��$��5,6,5,0q�.��� .+��  � ColumnDefinitions �� $	��350 ��� $	��420 ��� .+�(  "MaterialDesignThemes.Wpf.ColorZone  $��1��   Mode$ Standard=�$��8 4 8 8q�   CornerRadius$ 2��	 K� ZIndex$	 1��$��0 0 16 0q�+  %MaterialDesignThemes.Wpf.ShadowAssist
   ShadowDepth$
 Depth1=�.���  �� $
��Auto ��� $��* ��� $
��Auto �.+���   MaterialDesignToolButton#���  .��'  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]   Kind$ Magnify=� J� Opacity$	 .56Q��� $
��auto��$��1��$��8 0 0 0q�$ Tìm kiếm..��.  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�$��0q�$	��200��$��Center=��� -   #���  $��2��.��  $ 
Microphone=�$	 .56Q�$��8 0 0 0q�� -   $
��prgb��$��2�� � IsIndeterminate . $	��270��$��30���� -   $��lbprgrb��$��2��$��Center=�$��Center=�$��Đang tải...��� $��0��$��	20 0 10 0q�.+�]� .+��� $��Thêm��$��0 0 5 0q�$	��100������ *
AddCommand+�� $��Cập nhật��$��0 0 5 0q�$	��100������ *EditCommand+�� $
��Xóa��$��0 0 5 0q�$	��100������ *DeleteCommand+  $��3��$��5q�.���� $
��Auto=�$
��Auto=�.���� -   $��lvListStaff�� �� View �� 4	  .System.Windows.Automation.AutomationProperties 	  IsColumnHeader . .P��� $	��Mã�� �� DisplayMemberBinding �� *
IDPERSON+�� $
��Tên�� �� *NAME+�� $��Tên TK�� �� *
USERNAME+�� $��Giới tính�� �� *gender+�� $
��CMND�� �� *ID+�� $��Lương�� �� *SALARY+�� $��Vào Cty�� �� *	DAYJOIN+ �� StringFormat$ {0:dd/MM/yyyy}���� $
��BHYT�� �� *
ID_MEDICAL+�� $
��TKNH�� �� *	ID_BANK+�� $��Email�� �� *EMAIL+�� $
��SĐT�� �� *PHONE+�� $��
Ngày sinh�� �� *	BIRHDAY+$ {0:dd/MM/yyyy}��