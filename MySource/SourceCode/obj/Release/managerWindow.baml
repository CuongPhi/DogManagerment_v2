   M S B A M L   `   `   `  ����   
SourceCode    SourceCode.managerWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     � Title$  Quản lý chó��$	��720��$
��1280�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=�   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper#���    MaterialDesignFont#���   � 	Resources   MenuItemControlTemplate �� 
TargetType ��Name	 J� SnapsToDevicePixels
 � ColumnDefinitions ��Name m� Icon F�Name �� HeaderStringFormat �� ContentStringFormat �Name � AllowsTransparency �� RelativeSource �� Padding ��Name �� 
ResourceId �� TypeInTargetAssembly �� ClearTypeHint ��Name �� ElementName ��Name-  'System.Windows.Input.KeyboardNavigation   DirectionalNavigation � IsSharedSizeScope   TabNavigation �� Triggers P� Property  P� Value! �� 
TargetName" �� Property# �� Value$ P� 
SourceName��%�  &	       �� " m�.R��� $ templateRoot��#��z��#��z��#��z��	 . ._�� $��Center=�
 �� $
��Auto ��� $
��Auto �.+��� $
 Icon��#��z $
��Icon��$��Center=�$��16��$��3q�#	 z	 $��Center=�$��16��F� $ 
GlyphPanel��T������� �O �`�G �ڊ � �D �ڊ �    �XO � � �g5 ���A  ] ������� @    р�� �O #��z��$��LeftToRight=�$��3q�$y�	Collapsed=�$��Center=��� #��z��#��z��$��1��# z $��Header��#��z����. #	 z	 � $ 
PART_Popup�� . |�.  #��� -�$��Bottom=����� *IsSubmenuOpen+ �� *TemplatedParent+.���� $ SubMenuBorder�����	#FF999999$��1q����#512da8$ 2q�._��� $ SubMenuScrollViewer����C� *�� $ MenuScrollViewer��" �+.��� $ Enabled=�.+��� $
��Left=�$��0��$	��Top=�$��0��.+��� $ 
OpaqueRect������ *
Background+$ SubMenuBorder������ *ActualHeight+$ SubMenuBorder������ *ActualWidth+$ SubMenuBorder���� ���	#FFD7D7D7$
��Left=�$��30,2,0,2q�$��1���� $ ItemsPresenter��$ Cycle=� . #	 z	 $ Cycle=� P� " �@m�IsSuspendingPopupAnimation  . . ��� $! 
PART_Popup��" � ��$
# None=�P�   Z�  �@m�Icon. ��� $
! Icon��" � y�$# 	Collapsed=�P�  �@m�	IsChecked  . . ��� $! 
GlyphPanel��" � y�$# Visible=��� $
! Icon��" � y�$# 	Collapsed=�P�  �@m�IsHighlighted  . . ��� $! templateRoot��" � ��# �	#FF26A0DA�� $! templateRoot��" � ��# �	#FF26A0DAP�  � {�  .  . ��� $! templateRoot��" � ��# �	#FF707070�� $! 
GlyphPanel��" � ��# �	#FF707070P� $$ SubMenuScrollViewer�� � ��  .  . ��� $! 
OpaqueRect��# �� *VerticalOffset+$ SubMenuScrollViewer��" �@��Top�� $! 
OpaqueRect��# �� *HorizontalOffset+$ SubMenuScrollViewer��" �@��LeftP�  �@J�IsMouseOver  . . ��� $! 
PART_Popup��" � ��# . �� " �@�Cursor$
# Hand��.��� ���#F5F5F5% � RowDefinitions% �� $��48 ��� .+�(  "MaterialDesignThemes.Wpf.ColorZone  -   $��0��&   Mode$& PrimaryDark=�$	��300��$��0q�'   CornerRadius$' 3��+  %MaterialDesignThemes.Wpf.ShadowAssist(   ShadowDepth$( Depth3=�$��0q�.���� ) �� Orientation$) 
Horizontal=�.+�� 
 �� �� -   * �Name$* someName��$	��638 ��� $��60 ��� $��60 ��� $��60 �.+�o� ���#512DA8$��0��+ o� 
IsMainMenu+ . 
�������.@�m� #���  $��Tệp��.@�m� -   $��Thoát�� '  !MaterialDesignThemes.Wpf.PackIcon  $��	-20 0 0 0q��  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]],   Kind$, CloseOctagon=�m� $��Trợ giúp��m� $��Bản quyền��m� $��Liên lạc��m� -   $��Menu_UserName��#���  $��Cường ...��.@�m� $��	15 0 15 0q�$��Tài khoản��   $��	-10 0 0 0q�$, HelpBox=�m� $��	15 0 15 0q�$��Mật khẩu��   $��	-10 0 0 0q�$, AccountConvert=��� m� -   $��	15 0 15 0q�$��Đăng xuất��   $��	-10 0 0 0q�$, LogoutVariant=��� -   $��btnMinimize��- � ToolTip$- Ẩn đi��$��2��$��5q�$��35��
���"�"�.��  $, WindowMinimize=��� -   $��btnMaximize��$- Maximize��$��3��$��5q�$��35��
��� ���.��  -	   $��iconMaximize��$, WindowMaximize=��� -
   $��btnClose��$��4��$- Đóng��$��35��$��5q�
��� E��.��  $, WindowClose=�� -   $��1��
 �� �� $��55 �.+�� -   $��UserControl_MainWindow��$��0��� -   $��Menu_SliderBar��$��1��