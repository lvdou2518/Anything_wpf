   M S B A M L   `   `   `  ���� M  IAnything[wpf_main], Version=1.0.5.3, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Anything_wpf_main_.FormAnything_wpf_main_.Form  ?$clr-namespace:Anything_wpf_main_.clsAnything_wpf_main_.cls  Q-clr-namespace:Anything_wpf_main_.UserControlsAnything_wpf_main_.UserControls  )    #Anything_wpf_main_.Form.wndSettings   R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    8x,http://schemas.microsoft.com/winfx/2006/xaml    >d2http://schemas.microsoft.com/expression/blend/2008    Hmc;http://schemas.openxmlformats.org/markup-compatibility/2006    5local%clr-namespace:Anything_wpf_main_.Form    2cls$clr-namespace:Anything_wpf_main_.cls    :uc-clr-namespace:Anything_wpf_main_.UserControls    -     � Title$  wndSettings��$	��362��$	��600�� � WindowStyle$
 None=� � AllowsTransparency . ���	#00000000 � WindowStartupLocation$ CenterScreen=�.���� -    ��Name$ BdrOut�����	#aaeeeeee �� CornerRadius$ 5��$��2q�$
��auto��$
��auto��._��� ���	#DE161616$��1q�$ 5������  �� ElementName$ BdrOut�� �� Path$ Width�._��  � RowDefinitions �� $
��auto ��� $��* �.+��� -   	 ��Name$	 btnClose��   ButtonStyle_Close#��[  $��Right=�$	��Top=�$��0��$��2��.��� .+��� 	
 �� X1$
 6��	 �� Y1$ 6��	 �� X2$ 20��	 �� Y2$ 20�����	#FFAAAAAA$��2���� $
 6��$ 6��$ 20��$ 20�����	#FFAAAAAA$��2�� J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~��� �� ��  �� Angle$ 90Q�T� �� $��1��$
��Auto=�.���� -    ��Name$ spMain��$
��auto��.+�9� -    9�Name$	 exp��$
��10,0q�
�������$��Visual Settings��$��16(�.����  �� Orientation$ Vertical=�.+��� $ 
Horizontal=�.+��� $��Maximum Opacity:��  TextBlockStyle#��[ �� -    ��Name$ sldrMaxOpacity��$	��300��$��Center=� � Maximum$	 1.0Q� � Minimum$	 0.1Q� � Value ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType$ local:wndSettingsL�$ 
MaxOpacity� �� Mode$ TwoWay=��� #��[ $��50������ $ sldrMaxOpacity��$ Value��� $ 
Horizontal=�.+��� $��Minimum Opacity:��#��[ �� -   $ sldrMinOpacity��$	��300��$��Center=�$	 1.0Q�$
 0.05Q� ��  �� $ FindAncestor=�$ local:wndSettingsL�$ 
MinOpacity�$ TwoWay=��� #��[ $��50������ $ sldrMinOpacity��$ Value��� $ 
Horizontal=�.+��� $��Fadein Duration:��#��[ �� -   $ 
sldrFadein��$	��300��$��Center=�$
 60.0Q�$ 0.001Q� ��  �� $ FindAncestor=�$ local:wndSettingsL�$ Fadein�$ TwoWay=��� #��[ $��50������ $ 
sldrFadein��$ Value��� $ 
Horizontal=�.+��� $��Fadeout Duration:��#��[ �� -	   $ sldrFadeout��$	��300��$��Center=�$
 60.0Q�$ 0.001Q� ��  �� $ FindAncestor=�$ local:wndSettingsL�$ Fadeout�$ TwoWay=��� #��[ $��50������ $ sldrFadeout��$ Value��� $ 
Horizontal=�.+��� $��
Item Size:��#��[ �� -
   $ sldrItemSize��$	��300��$��Center=�$	 256Q�$ 16Q� ��  �� $ FindAncestor=�$ local:wndSettingsL�$ ItemSize�$ TwoWay=��� #��[ $��50������ $ sldrItemSize��$ Value�9� $
��10,0q�
�������$��Search Engine Management��$��16(�.���� $ Vertical=�.+��� .+��� #��[ $
��Left=�$3��-Add New(Use "%keyword%" to  instead keyword):���  � ColumnDefinitions �� $
��auto ��� $��* � �� �� �� .+��� $��0��$��0��$��Name:��#��[ �� -    ��Name$ 	txtSEName��$��0��$��1��  TextBoxStyle#��[ �� $��1��$��0��$
��URL:��#��[ �� -   $ txtSEContent��$��1��$��1��#��[ �� -   $	 btnAdd��$	��130��  NormalButtonStyle#��[ $��2��$��2��$	��Add��9� $
��10,0q�
�������$��Hot Key Management��$��16(�.���� $ Vertical=�.+��� $ 
Horizontal=�$
��Left=�.+�6   0Anything_wpf_main_.UserControls.HotKeyVisualItem  -     Name$ HotKeyVisual��6   0Anything_wpf_main_.UserControls.HotKeyVisualItem   	MouseMove$  HotKeyVisualItem_MouseMove��$��20,0,0,0q��� -   $	 btnAddHotKey��$	��Add��#��[ 