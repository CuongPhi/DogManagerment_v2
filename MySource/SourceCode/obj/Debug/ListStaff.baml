   M S B A M L   `   `   `  ����E  ASourceCode, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SourceCode
SourceCode  5          SourceCode.ListStaff   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:SourceCode     5      V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5        $��uc_ListStaff��5
      $
��auto��5	      .��5      � -   5          �Name$  
UCNhanVien��5      ���#ced5e0 � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   .+�5   
   � $��0��6   .+�5      ��  �� Padding$ 5q�6   $��	220 0 0 0q�6$    #  MaterialDesignDisplay1TextBlock#��[  67   QUẢN LÝ NHÂN VIÊN5      5      #  MaterialDesignThemes.Wpf.Card  5   
   $��1��6   $��5q�6+   .��5      � -   5        $��SelectedItemWraPnel��5   `   $��Center=�6   $��Center=�66   $
��auto��6R   .+�5      �� -   5        $��
txbID_User��5      $��14(�6,   $��5 5 5 5q�6b   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mã NV��6s    % !MaterialDesignFloatingHintTextBox#��[ 6�   ��6;   �� *
IDPERSON+ �� Mode$ OneWay=�6�   �� 5      -   5        $��txbName��5      $��14(�6)   $��5 5 5 5q�6Z   $
 Tên��6k   #��[ 6�   ��67   �� *NAME+$ OneWay=�6�   �� 5       -   5        $��txbUserName��5       $��14(�6-   $��5 5 5 5q�6b   $ Tài khoản��6s   #��[ 6�   ��6;   �� *
USERNAME+$ OneWay=�6�   �� 5!      -   5        $��txbIsBan��5!      $��14(�6+   $��Khóa��69   $��5 5 5 5q�6q    d� 	IsChecked 6H   �� *ISBAN+$ OneWay=�6q   �� 5"      -   5        $��	txbGender��5"      $��14(�6+   $��5 5 5 5q�6^   $ Giới tính��6o   #��[ 6�   ��69   �� *GENDER+$ OneWay=�6�   �� 5#      -	   5        $��txbIDNum��5#      $��14(�6*   $��5 5 5 5q�6\   $
 CMND��6m   #��[ 6�   ��68   �� *ID_TT+$ OneWay=�6�   �� 5$      -
   5        $��	txbSalary��5$      $��14(�6+   $��5 5 5 5q�6^   $ Lương��6o   #��[ 6�   ��69   �� *SALARY+$ OneWay=�6�   �� 5'      -   5        $��txbEmail��5'      $��14(�6*   $��5 5 5 5q�6]   $ Email��6n   #��[ 6�   ��69   �� *EMAIL+$ OneWay=�6�   �� 5(      -   5        $��txbPhone��5(      $��14(�6*   $��5 5 5 5q�6\   $
 SĐT��6m   #��[ 6�   ��68   �� *PHONE+$ OneWay=�6�   �� 5)      -   5        $��
txbAddress��5)      $��14(�6,   $��5 5 5 5q�6`   $
 SĐT��6q   #��[ 6�   ��6:   �� *	ADDRESS+$ OneWay=�6�   (  "System.Windows.Controls.DatePicker  5*      -   5        $��
dpBirthDay��5*      $��Center=�6/   $	��100��6x   $��5 5 5 -5q�6�   $ 
Ngày sinh��6�    ( $MaterialDesignFloatingHintDatePicker#��[ 6�      SelectedDate 6J   �� *	BIRHDAY+$ OneWay=�6�     5+      -   5        $��	dpDayJoin��5+      $��Center=�6.   $	��100��6w   $��5 5 5 -5q�6�   $ 	Vào C.Ty��6�   #��[ 6�    6I   �� *	DAYJOIN+$ OneWay=�6�   5-      5.        5/   
   $��50��6   $��2��6*   $��5,6,5,0q�67   .��50      � .+�51      �  � ColumnDefinitions 52      �� 53      $	��350 �6+   69   �� 54      $	��420 �6+   69   �� 55      6-   .+�57      (  "MaterialDesignThemes.Wpf.ColorZone  $��1��6+      Mode$ Standard=�6;   $��8 4 8 8q�6K   	   CornerRadius$	 2��6]   
 K� ZIndex$
 1��6n   $��0 0 16 0q�58   $   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�59   $   .��5:      �  5;      �� 5<      $
��Auto �6/   �� 5=      $��* �6/   �� 5>      $
��Auto �6/   .+�5@      ��   MaterialDesignToolButton#���  6!   .��5A      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]   Kind$ Magnify=�66    J� Opacity$	 .56Q�6E   5B      �� 5C      -   5        $��	txbSearch��5C   "   $
��auto��63   $��1��6@   $��8 0 0 0q�6P   $ Tìm kiếm..��6a   .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�5D   &   $��0q�6c   $	��200��5E   &   $��Center=�65   6P   �� 5F      -   5        #���  5F   6   $��2��6i   .��5G        $ 
Microphone=�66   $	 .56Q�6H   $��8 0 0 0q�6V   5H      5I      5J      � 5K      -   5        $
��prgb��5K      $��2��6*    � IsIndeterminate . $	��270��6Q   $��30��6]   �� 5L      -   5        $��lbprgrb��5L      $��2��6+   $��Center=�6;   $��Center=�6X   $��Đang tải...��6s   6�   � 5M      $��0��6   $��	20 0 10 0q�6+   .+�5N      ]� .+�5O      �� -   5        $��Thêm��5O   D   $��0 0 5 0q�6S   $	��100��6d   ��6%   �� *
AddCommand+6�   �� 5P      -   5        $��
Làm mới��5P   E   $��0 0 5 0q�6W   $	��100��6h   ��6%   �� *EditCommand+6�   �� 5Q      -   5        $
��Xóa��5Q   G   $��0 0 5 0q�6U   $	��100��6f   ��6%   �� *DeleteCommand+6�   5R      5S      5T      5U      5V        5W   
   $��3��6   $��5q�6+   .��5X      �� $
��Auto=�6   $
��Auto=�6>   .��5Y      �� -   5        $��lvListStaff��5Y   �     alternatingStyle#��[ 6    �� AlternationCount$ 2��6R    � ContextMenu 5[      �� 5\      -   5        $��ZoneIformationList��5\   &    �� 	StaysOpen . 
������� J� BitmapEffect 5]      �� 5^   "   .@�5`      m� -   5        $��ResetPasswordMenuItem��5`   c   $��Reset mật khẩu��6'   6c   m� 5a      -   5        $��SetSalaryMenuItem��5a   Y   $��Cập nhật��6'   6Y   m� 5b      -   5        $��NotBanAccountMenuitem��5b   b   $��Mở tài khoản��6'   6b   m� 5c      -   5        $��BanAccountMenuitem��5c   a   $��Khóa tài khoản��6'   6a   5e       �� View 5h      �� 5i      4	  .System.Windows.Automation.AutomationProperties 	  IsColumnHeader . .P�5j      �� $	��Mã��6-    �� DisplayMemberBinding 69   �� *
IDPERSON+6e   �� 5k      $
��Tên��6-    6:   �� *NAME+6b   �� 5l      $��Tên TK��6-    6=   �� *
USERNAME+6i   �� 5m      $��Trạng thái��6-   -   5        CheckBoxColumn�� �� CellTemplate 5n   "   �� 5o   &   .R�5p   *   � .+�5q   .   �� $��Khóa��67   $��Center=�6F    6c   �� *ISBAN+$ OneWay=�5r   +   5s   '   5u      �� 5v      $��Giới tính��6-    6@   �� *GENDER+6k   �� 5w      $
��CMND��6-    6;   �� *ID_TT+6d   �� 5x      $��Lương��6-    6<   �� *SALARY+6f   �� 5y      $��Vào Cty��6-    6>   �� *	DAYJOIN+ �� StringFormat$ {0:dd/MM/yyyy}��6�   �� 5|      $��Địa chỉ��6-    6>   �� *	ADDRESS+6i   �� 5}      $��Email��6-    6<   �� *EMAIL+6f   �� 5~      $
��SĐT��6-    6:   �� *PHONE+6c   �� 5      $��
Ngày sinh��6-    6@   �� *	BIRHDAY+$ {0:dd/MM/yyyy}��6�   5�      5�      5�      5�      5�      5�      