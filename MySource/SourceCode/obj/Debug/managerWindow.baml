   M S B A M L   `   `   `  ����  
SourceCode    SourceCode.managerWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   -   5          � Title$  Quản lý chó��5   	   $	��720��6   $
��1280��6*    � WindowStartupLocation$ CenterScreen=�67    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5	   	      MaterialDesignBody#���   5   
   $��Regular"�5   
   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   
      TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � 	Resources 5        MenuItemControlTemplate �� 
TargetType ��Name	 J� SnapsToDevicePixels
 � ColumnDefinitions ��Name m� Icon F�Name �� HeaderStringFormat �� ContentStringFormat �Name � AllowsTransparency �� RelativeSource �� Padding ��Name �� 
ResourceId �� TypeInTargetAssembly �� ClearTypeHint ��Name �� ElementName ��Name-  'System.Windows.Input.KeyboardNavigation   DirectionalNavigation � IsSharedSizeScope   TabNavigation �� Triggers P� Property  P� Value! �� 
TargetName" �� Property# �� Value$ P� 
SourceName��%�
  &	       �� 5   
   " m�6:   .R�5      �� $ templateRoot��6   #��z��6+   #��z��6W   #��z��6�   	 . ._�5      � $��Center=�6   
 5      �� 5      $
��Auto �6+   �� 5      $
��Auto �6+   .+�5      �� $
 Icon��6'   #��z 65   $
��Icon��6V   $��Center=�6k   $��16��6�   $��3q�6�   #	 z	 6�   $��Center=�6�   $��16��6�   F� 5      $ 
GlyphPanel��6   T������� �O �`�G �ڊ � �D �ڊ �    �XO � � �g5 ���A  ] ������� @    р�� �O #��z��6t   $��LeftToRight=�6�   $��3q�6�   $y�	Collapsed=�6�   $��Center=�6�   �� 5      #��z��6'   #��z��6Z   $��1��6}   # z 6�   $��Header��6�   #��z��6�   ��. #	 z	 6  � 5      $ 
PART_Popup��6    . |�.  #��� -�6�   $��Bottom=�6  ��6\   �� *IsSubmenuOpen+ �� *TemplatedParent+.��5      �� $ SubMenuBorder��6!   ���	#FF999999$��1q�6P   ���#512da8$ 2q�6y   ._�5      �� $ SubMenuScrollViewer��6+   ��6H   C� *�� $ MenuScrollViewer��" �+.��5    "   � $ Enabled=�6'   .+�5!   &   �� $
��Left=�6-   $��0��6H   $	��Top=�6S   $��0��6k   .+�5"   *   �� $ 
OpaqueRect��64   ��6H   �� *
Background+$ SubMenuBorder����6   �� *ActualHeight+$ SubMenuBorder����6�   �� *ActualWidth+$ SubMenuBorder��5#   '   �� 5$   &   ���	#FFD7D7D7$
��Left=�6A   $��30,2,0,2q�6\   $��1��6n   �� 5%   &   $ ItemsPresenter��65   $ Cycle=�6M    . #	 z	 6�   $ Cycle=�6�   5&   #   5'      5(      5)      5*      5+       5,      P� 5-      " �@m�IsSuspendingPopupAnimation  . . �5.      �� $! 
PART_Popup��67   " � ��$
# None=�6O   5/      P� 50        6*   Z�  �@m�Icon. �51      �� $
! Icon��63   " � y�$# 	Collapsed=�6E   52      P� 53       �@m�	IsChecked  . . �54      �� $! 
GlyphPanel��63   " � y�$# Visible=�6K   �� 55      $
! Icon��63   " � y�$# 	Collapsed=�6E   56      P� 57       �@m�IsHighlighted  . . �58      �� $! templateRoot��63   " � ��# �	#FF26A0DA6M   �� 59      $! templateRoot��64   " � ��# �	#FF26A0DA6N   5:      P� 5;       � {�  .  . �5<      �� $! templateRoot��6?   " � ��# �	#FF7070706Y   �� 5=      $! 
GlyphPanel��6-   " � ��# �	#FF7070706E   5>      P� 5?      $$ SubMenuScrollViewer��66    � ��  .  . �5@      �� $! 
OpaqueRect��63   # 6K   �� *VerticalOffset+$ SubMenuScrollViewer��" �@��Top�� 5A      $! 
OpaqueRect��64   # 6L   �� *HorizontalOffset+$ SubMenuScrollViewer��" �@��Left5B      P� 5C       �@J�IsMouseOver  . . �5D      �� $! 
PART_Popup��6/   " � ��# . 6G   �� 5E      " �@�Cursor$
# Hand��6/   5F      5H      5I      .��5J      � ���#F5F5F5% � RowDefinitions% 5K   
   �� 5L      $��48 �6   6*   �� 5M      6   .+�5O   
   (  "MaterialDesignThemes.Wpf.ColorZone  -   5        $��0��5O   #   &   Mode$& PrimaryDark=�60   $	��300��6D   $��0q�6T   '   CornerRadius$' 3��5P   $   +  %MaterialDesignThemes.Wpf.ShadowAssist(   ShadowDepth$( Depth3=�5Q   $   $��0q�5R   $   .��5S      �� ) �� Orientation$) 
Horizontal=�6   .+�5T      � 
 5V      �� 5W      6)   �� 5X      -   5        * �Name$* someName��5X   '   $	��638 �67   6E   �� 5Y      $��60 �6'   64   �� 5Z      $��60 �6(   66   �� 5[      $��60 �6(   66   .+�5^      o� ���#512DA8$��0��62   + o� 
IsMainMenu+ . 
�������.@�5_      m� #���  6%   $��Tệp��6Z   .@�5`      m� -   5        $��Thoát��5`   >    5a   "   '  !MaterialDesignThemes.Wpf.PackIcon  5b   &   $��	-20 0 0 0q�6>   �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]],   Kind$, CloseOctagon=�6Q   5d      5e      m� 5g      -   5        $��Trợ giúp��5g   #   5h      m� 5i      -   5        $��Bản quyền��5i   &   5j      m� 5k      -   5        $��Liên lạc��5k   >   5m      m� 5n      -   5        $��MenuItemAccount��5n   #   #���  6;   .@�5p      m� -	   5        $��	15 0 15 0q�5p   A   $��Tài khoản��6U    5q   "     5r   &   $��	-10 0 0 0q�6>   $, HelpBox=�6Q   5t      m� 5u      -
   5        $��	15 0 15 0q�5u   @   $��Mật khẩu��6T    5v   "     5w   &   $��	-10 0 0 0q�6>   $, AccountConvert=�6Q   5y      �� 5z      m� 5{      -   5        $��	15 0 15 0q�5{   @   $��Đăng xuất��6T    5|   "     5}   &   $��	-10 0 0 0q�6>   $, LogoutVariant=�6Q   5      5�      5�      �� 5�      -   5        $��btnMinimize��5�      - � ToolTip$- Ẩn đi��60   $��2��6@   $��5q�6P   $��35��5�   4   
���"�"�.��5�        $, WindowMinimize=�62   5�      �� 5�      -   5        $��btnMaximize��5�      $- Maximize��60   $��3��6C   $��5q�6S   $��35��5�   7   
��� ���.��5�        -   5        $��iconMaximize��5�   3   $, WindowMaximize=�6G   5�      �� 5�      -   5        $��btnClose��5�      $��4��6-   $- Đóng��6>   $��35��5�   4   $��5q�6@   
��� E��.��5�        $, WindowClose=�66   5�      5�      5�      5�      � 5�   
   -   5        $��1��5�      
 5�      �� 5�      6%   �� 5�      $��55 �6$   61   .+�5�      � -   5        $��UserControl_MainWindow��5�      $��0��61   5�      � 5�      -   5        $��Menu_SliderBar��5�      $��1��6)   5�      5�      5�      5�      