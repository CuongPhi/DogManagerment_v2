   M S B A M L   `   `   `  ����E  ASourceCode, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SourceCode
SourceCode  5          SourceCode.NhanVienNhap   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:SourceCode     5      V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5      $
��auto��5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      � -   5         � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      6   .+�5   
   � $��0��6   ���#512da8.+�5      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6'   $��5q�69   .��5      ]� .+�5      d�  * &MaterialDesignSwitchAccentToggleButton#��[ 6#   $��Center=�6c   $��Right=�5   #   �� 5       �� Orientation$ 
Horizontal=�6!   +  %MaterialDesignThemes.Wpf.RippleAssist   
IsCentered . .+�5      d�  ' #MaterialDesignHamburgerToggleButton#���  6'     5      $ Standard=�63   $��8 4 8 4q�6C      CornerRadius$ 2��6U    K� ZIndex$ 1��6f   $��16 0 0 0q�5    $   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�5!   $   .��5"      � 	 � ColumnDefinitions	 5#   "   �� 5$   &   $
��Auto �67   �� 5%   &   $��* �67   �� 5&   &   $
��Auto �67   .+�5(   "   ��   MaterialDesignToolButton#���  6)   .��5)   &   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]
   Kind$
 Magnify=�6>    J� Opacity$	 .56Q�6M   5*   #   �� 5+   "   -   5        $��txbSearchDog��5+   *   $��1��6b   $��8 0 0 0q�6r   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Build a search bar��6�   .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�5,   &   $��0q�6c   $	��470��5-   &   $��Center=�65   �� 5.   "   #���  6)   $��2��6\   .��5/   &     $
 
Microphone=�6>   $	 .56Q�6P   $��8 0 0 0q�6^   50   #   51      52      �� 53      -   5         �� 	IsDefault .  & "MaterialDesignToolForegroundButton#���  53   I   $��8 0 0 0q�6�   $ 0��6�   .��54        $

 Send=�66   55      �� 56       �� Padding$ 5q�6$   $��	120 0 0 0q�60    # MaterialDesignDisplay1TextBlock#��[ 6C   NHẬP CHÓ58      59      5:      5=      5>      � 5?   
   $��1��6   
����ح�	 5@      �� 5A      6%   �� 5B      $	��360 �6#   62   .+�5D      �� $��0��6   $��0 0 10 0q�6%   $��2q�68   
���  ��._�5E      � -   5        $��Display_Tag��5E       5F      �� 5G      $	��150 �6)   69   �� 5H      6*   .+�5J      � -   5        $��SelectedItemBinding��5J   )   $��0��6   	 5K      �� 5L      $	��650��6/   6@   �� 5M      $	��300��6/   6@   .+�5O      �� -   5        $��1��5O   "   
����ح�$��	20 10 0 0q�6I   $
��Left=�6\   $��Center=�6w   $	��150��6�   $	��150��6�   .��5P      �� .+�5Q   "   �� -   5        $��ImageDogBinding��5Q   �   $��Center=�6(   $��Center=�6E   $	��130��6`   $	��130��6l   ��6�   �� *IMAGES+6�   5R      5S      �� 5U      -   5        $��0��5U   8   $��	10 10 0 0q�6H   $��2q�6[   
���  ��._�5V      � $��
10 10 10 0q�6#    5W   "   �� 5X   &   66   �� 5Y   &   66   .+�5[   "   #	  MaterialDesignThemes.Wpf.Card	  $��0 0 0 0q�67   $��0��6H   .��5\   &   � .+�5]   *   �� -	   5        $��txbIDDog��5]   2    �� 
IsReadOnly . $��10q�6y   $ ID Chó��6�    % !MaterialDesignFloatingHintTextBox#��[ 6�   ��6T   �� *ID_DOG+ �� Mode$ OneWay=�6�   �� 5^   *   -
   5        $��txttime��5^   D    . $��10q�6u   $ Giờ bắt��6�   #��[ 6�   ��6S   �� *TIME+$ OneWay=�6�   �� 5_   *   -   5        $��txtday��5_   D    . $��10q�6�   $ Ngày��6�   #��[ 6�   ��6R   �� *DAYIN+$ OneWay=� �� StringFormat$ {0:MM/dd/yyyy}��6�   �� 5`   *   -   5        $��	txbWeight��5`   3   $��10q�6i   $ Nặng��6u   #��[ 6�   ��6D   �� *WEIGHT+$ OneWay=�6�   �� 5a   *   $��10q�6]   $ 
Nơi bắt��6i   #��[ 6�   ��63   �� *DOG_ADDRESS+$ OneWay=�6�   �� 5c   )   -   5        $��btnEdit��5c   �   $��16(�60   $��0q�6>    � ToolTip$ Chỉnh sửa��6_   $��60��6s   $��40��6~   .��6�   Sửa5e   /   �� 5f   *   -   5        $��txbIDTypeDog��5f   F   $y�Hidden=�62   $��10q�6   $ 
Mã Loại��6�   #��[ 6�   ��6Z   �� *	ID_TYPE+$ OneWay=�6�   �� 5g   *   -   5        $��txbIDHouseDog��5g   F   $y�Hidden=�62   $��10q�6�   $ Mã Chuồng��6�   #��[ 6�   ��6[   �� *
ID_HOUSE+$ OneWay=�6�   5i   '   5k   #   	  5l   "   $��1��66   .��5m   &   � .+�5n   *   �� -   5        $��txbNameTypeDog��5n   D    . $��10q�6�   $ Loại��6�   #��[ 6�   ��6Z   �� *	NAME_TYPE+$ OneWay=�6�   �� 5o   *    . $��10q�6m   $ Chuồng��6y   #��[ 6�   ��6D   �� *DESTRIPTION+$ OneWay=�6�   �� 5p   *   -   5        $��txbFoodPrice��5p   E    . $��10q�6�   $ 
Thức ăn��6�   #��[ 6�   ��6Y   �� *
FOOD_PRICE+$ OneWay=�6�   �� 5q   *   -   5        $��txbNumofDay��5q   D    . $��10q�6~   $ 
Số ngày��6�   #��[ 6�   ��6W   �� *
NumOfDay+$ OneWay=�6�   �� 5r   *   -   5        $��txbFine��5r   R    . $��500000��6D   $��10q�6b   $ Tiền phạt��6n   #��[ 6�   �� 5s   *   -   5        $��txbTotalPrice��5s   F    . $��10q�6[   $ Tổng tiền��6g   $
��Bold"�6�   $��14(�6�   #��[ 6�   6�   5t   '   5u   #   5v      5w      5x      � 5z      $	��850��6   $��1��6*   $��
10 0 10 10q�67    5{      �� 5|      $��25 �6,   6;   �� 5}      6.   .+�5      � $��0��6   .+�5�      � -   5        $��prgb_acc_dog��5�   =   
��� � �$��2��6Q   $��Center=�6a   $��Center=�6|    � IsIndeterminate . $	��350��6�   $��15��6�   �� 5�      -   5        $��lbprgrb_acc_dog��5�   $   $��2��6;   $��Center=�6K   $��Center=�6h   $��Đang tải...��6�   6�   5�      �� 5�      -   5         ��Name$ dogBox��5�   [   $��1��6N   $��Stretch=�6k   $	��Top=�6�   ��5�      �� 5�   "   .R�5�   &   A�  A� Columns$ 5��62   $��Stretch=�6>   5�   #   ��5�      �� 5�   "   .R�5�   &   �� $	��120��61   $	��130��6=   $ Vertical=�6J   $��Stretch=�6a   $��Stretch=�6}   .+�5�   *   �� $��ImageDogInListView��6J   $��Stretch=�6d   $	��120��6�   $	��110��6�   $	��Top=�6�   $��UniformToFill=�6�   ��60   �� *IMAGES+6�   �� 5�   *   $��Stretch=�6Q   $��Bottom=�6o   ��64   �� *DOG_ADDRESS+6o   5�   '   5�   #   5�      5�      5�      5�      �� 5�      $��1��6   $��2q�6%   
���  ��._�5�      � -   5        $��Bill_Tag��5�      
������� 5�      �� 5�      $��25 �6(   67   �� 5�      $��40 �6(   67   �� 5�      $��40 �6(   67   �� 5�      $��40 �6)   68   �� 5�      $��40 �6(   67   �� 5�      6,   �� 5�      $��40 �6(   67   �� 5�      $	��150 �6(   67   �� 5�      $��75 �6(   66   �� 5�      6*   .+�5�      � $��0��6   	 5�      �� 5�      61   �� 5�      61   .+�5�      �� -   5        $��	StaffName��5�   F   $��50 0 0 0q�6$   $��0��66   $��Nhân viên: ��6W   6l   5�      � 5�      $��7q�6   $��1��6'   	 5�      �� 5�      $	��140 �6/   6=   �� 5�      61   .+�5�      � $��0��6   .+�5�      �� $��Center=�6(   $��Loại :��6C   $
��Left=�6Q   6o   �� 5�      -   5        $��
cbbnewtype��5�   '   $��50��69   $��50 0 0 0q�6G   $
��Left=�6Z   $��Center=�6u   .@�5�   "   ��  �� 
IsSelected . .��6A   
Loại 16I   �� 5�   "   .��6/   
Loại 267   �� 5�   "   .��6/   
Loại 367   5�      5�      � 5�      $��1��6    .+�5�      �� $��Center=�6(   $��Tiền thức ăn:��6C   $
��Left=�6X   6v   �� 5�      -   5        $��txbnewPricefood��5�   5   $	��100��6&   $��Center=�6L   $��90 0 0 0q�6g   $
��Left=�6z   6�   5�      5�      � 5�      $��7q�6   $��2��6'   	 5�      �� 5�      $	��180 �60   6>   �� 5�      61   .+�5�      � $��0��6   .+�5�      �� $��Mã chuồng:��6(   $��Center=�6:   $
��Left=�6U   6s   �� 5�      -   5        $��cbbnewMaChuong��5�   6   $��50��6(   $��90 0 0 0q�6L   $��Center=�6^   $
��Left=�6z   .@�5�   "   �� .��6/   
Chuồng 169   �� 5�   "    . .��6A   
Chuồng 26K   �� 5�   "   .��6/   
Chuồng 369   5�      5�      � 5�      $��1��6   $��2��6/   .+�5�      �� $��Cân nặng:��6(   $��Center=�69   $
��Left=�6T   6r   �� 5�      -   5        $��txbnewWeight��5�   4   $��70��6&   $��70 0 0 0q�6I   $��Center=�6[   $
��Left=�6v   6�   5�      5�      � 5�      $��7q�6   $��3��6'   .+�5�      � $��0��6   .+�5�      �� $��
Đường:��6(   $��Center=�66   $
��Left=�6Q   6o   �� 5�      -   5        $��txbBill_Streets��5�   &   $	��250��6=   $��Center=�6I   $��50 0 0 0q�6d   $
��Left=�6w   6�   5�      5�      � 5�      $��7q�6   $��4��6'   	 5�      �� 5�      61   �� 5�      61   .+�5�      � $��0��6   .+�5�      �� $��Center=�6(   $��
Phường:��6C   $
��Left=�6R   6p   �� 5�      -   5        $��txbBill_Ward��5�   4   $��50��6&   $��Center=�6H   $��50 0 0 0q�6c   $
��Left=�6v   6�   5�      � 5�      $��1��6   .+�5�      �� $��Center=�6(   $��Quận:��6C   $
��Left=�6P   6n   �� 5�      -    5        $��txbBill_District��5�   4   $��50��6&   $��Center=�6L   $��50 0 0 0q�6g   $
��Left=�6z   6�   5�      5�      � 5�      $��7q�6    � ShowGridLines . $��50��6<   
����ح�$��5��6_   .+�5�      �� $��Center=�6    $��Center=�6;   .��6X   HÓA ĐƠN NHẬP6f   5�      � 5�      $��6��6   	 5�      �� 5�      61   �� 5�      61   .+�5�      � $��0��6   .+�5�      �� $��7q�6(   $��Center=�63   $��Mã HĐ:��6N   $
��Left=�6\   $��2��6w   6�   �� 5�      -!   5        $��	txbIDBill��5�   4   $��50��6&   $
��Bold"�6E   $��Center=�6W   $��Center=�6s   6�   5�      � 5�      $��1��6   .+�5�      �� -"   5        $��	DateInput��5�   �   $��50 0 0 0q�6(   $��Center=�6:   $��Center=�6X   $��1��6s   $��04/05/2018 20:18��6�   6�   5�      5�      � 5�      $��7��6   .+�5�      �� -#   5        $��1��5�   8   
����ح�$��Center=�6_   $��Center=�6|   $	��150��6�   $	��150��6�   .��5�      �� .+�5   "   �� -$   5        $��
imagedogin��5   z   $��Center=�6)   $��Center=�6D   $	��130��6a   $	��130��6m   6�   5     5     5     � 5     $��8��6   .+�5     �� $
��Left=�6    $��5q�6;   $��Center=�6F   .��6a   
Ghi chú6j   �� 5     -%   5        $��txbBill_Note��5  "    �� TextWrapping$
 Wrap=�66   " �� VerticalScrollBarVisibility$ Visible=�6J   $	��250��6p   $��1q�6|   
���  ��$��80 0 0 0q�6�   $��Center=�6�   $
��Left=�6�   6�   5     � 5     $��7q�6   $��9��6'   .+�5	     �� -&   5        $��75��5	  !   $��NHẬN CHÓ��6-   5     5     5     5     5     5     5     