   M S B A M L   `   `   `  ���� E  ASourceCode, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SourceCode
SourceCode  $    SourceCode.Accountant_Handover   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     *localclr-namespace:SourceCode     V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�$
��auto��  MaterialDesignPaper#���    MaterialDesignFont#���  .��� -    � RowDefinitions �� $��50 ��� .+�� $��0�����#512da8.+�(  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�$��5q�.��]� .+�d�  * &MaterialDesignSwitchAccentToggleButton#��[ $��Center=�$��Right=���  �� Orientation$ 
Horizontal=�+  %MaterialDesignThemes.Wpf.RippleAssist   
IsCentered . .+�d�  ' #MaterialDesignHamburgerToggleButton#���    $ Standard=�$��8 4 8 4q�   CornerRadius$ 2�� K� ZIndex$ 1��$��16 0 0 0q�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�.��� 	 � ColumnDefinitions	 �� $
��Auto ��� $��* ��� $
��Auto �.+���   MaterialDesignToolButton#���  .��'  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]
   Kind$
 Magnify=� J� Opacity$	 .56Q��� $��1��$��8 0 0 0q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Build a search bar��.  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�$��0q�$	��470��$��Center=��� #���  $��2��.��  $
 
Microphone=�$	 .56Q�$��8 0 0 0q���  & "MaterialDesignToolForegroundButton#���  $��8 0 0 0q�$ 0��.��  $

 Send=���  �� Padding$ 5q�$��	120 0 0 0q� # MaterialDesignDisplay1TextBlock#��[ HÓA ĐƠN XUẤT CHÓ� $��1��
����ح�	 �� �� $	��360 �.+��� $��0��$��0 0 10 0q�$��2q�
���  ��._�� -   $��Display_Tag�� �� $	��150 ��� .+�� -   $��SelectedItemBinding��$��0��	 �� $	��650���� $	��300��.+��� -   $��1��
����ح�$��	20 10 0 0q�$
��Left=�$��Center=�$	��150��$	��150��.���� -   $��ImageDogBinding��$��
-17 -3 0 0q�$	��130��$	��130������ *IMAGES+�� -   $��0��$��	10 10 0 0q�$��2q�
���  ��._�� $��
10 10 10 0q� �� �� .+�#	  MaterialDesignThemes.Wpf.Card	  $��0 0 0 0q�$��0��.��� .+��� $��10q�$ ID Chó�� % !MaterialDesignFloatingHintTextBox#��[ ���� *ID_DOG+ �� Mode$ OneWay=��� $��10q�$ Giờ bắt��#��[ ���� *TIME+$ OneWay=��� $��10q�$ Nhập��#��[ ���� *DAYIN+$ OneWay=� �� StringFormat$ {0:dd/MM/yyyy}���� -   $��	txbWeight��$��10q�$ Nặng��#��[ ���� *WEIGHT+$ OneWay=��� $��10q�$ 
Nơi bắt��#��[ ���� *DOG_ADDRESS+$ OneWay=��� -   $��txbIDTypeDog��$y�Hidden=�$��10q�$ 
Mã Loại��#��[ ���� *	ID_TYPE+$ OneWay=��� -	   $��txbIDHouseDog��$y�Hidden=�$��10q�$ Mã Chuồng��#��[ ���� *
ID_HOUSE+$ OneWay=�	  $��1��.��� .+��� -
   $��txbNameTypeDog��$��10q�$ Loại��#��[ ���� *	NAME_TYPE+$ OneWay=��� $��10q�$ Chuồng��#��[ ���� *DESTRIPTION+$ OneWay=��� -   $��txbFoodPrice��$��10q�$ 
Thức ăn��#��[ ���� *
FOOD_PRICE+$ OneWay=��� -   $��txbNumofDay��$��10q�$ 
Số ngày��#��[ ���� *
NumOfDay+$ OneWay=��� -   $��txbFine��$��500000��$��10q�$ Tiền phạt��#��[ �� -   $��txbTotalPrice��$��10q�$ Tổng tiền��$
��Bold"�$��14(�#��[ � $��1��$��
10 0 10 10q� �� $��25 ��� .+�� $��0��.+�� -   $��prgb_acc_dog��
��� � �$��2��$��Center=�$��Center=� � IsIndeterminate . $	��350��$��15���� -   $��lbprgrb_acc_dog��$��2��$��Center=�$��Center=�$��Đang tải...���� -    ��Name$ dogBox��$��1��$��Stretch=�$	��Top=����� .R�A�  A� Columns$ 5��$��Stretch=����� .R��� $ Vertical=�$��Stretch=�$��Stretch=�.+��� $��ImageDogInListView��$��Stretch=�$	��100��$	��100��$	��Top=�$��UniformToFill=��� $��Stretch=�$��Bottom=����� *DOG_ADDRESS+�� $��1��$��2q�
���  ��._�� -   $��Bill_Tag�� � ShowGridLines . 
������� �� �� �� �� �� �� �� .+�� $��0��	 �� �� .+��� -   $��	StaffName��$��0��$��Cường���� -   $��DateTime��$��1��$��04/05/2018 20:18��