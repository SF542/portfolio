   M S B A M L   `   `   `  ����F  BMinesweeper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MinesweeperMinesweeper  5   	       Minesweeper.PlayGround   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Minesweeper     5   	   -   5          �Name$  PlayGround1��5   	    � Title$ 
PlayGround��5   	    � WindowStartupLocation$ CenterOwner=�6   $
��Auto��6@   $
��Auto��6N    � 	Resources 5	         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 ButtonStyle1	 �� 
TargetType
 �� 
TargetType ��Name ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7 	 �� 5
   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   #��� ��6E    . $��1��6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   "	 ��6%   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5       � ��8  6,   �� 5        � ��# � ��6+   �� 5!       � ��$ 1q�60   �� 5"       � ��$ Center=�6;   �� 5#       � ��$ Center=�69   �� 5$       � ��$ 1q�6(   �� 5%       � �� 5&      �� 5'      "
 ��6&   .R�5(      �� $ border��6!   #��z��61   #��z��6[   #��z��6�    . ._�5)      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5*       5+      P� 5,       �@��IsDefaulted . . �5-   "   �� $ border��6@   # � ��6T    � ��5.      P� 5/       �@J�IsMouseOver . 50      P� 51       � �� . . �52   "   �� $ border��6?   8   � ��6S   �� 53   "   $ border��6@   8   � ��6T   54      P� 55       � {� .  . �56   "   �� $ border��6?   8   � ��6S   �� 57   "   $ border��6@   8   � ��6T   �� 58   "   $ contentPresenter��6K   8   � ��6i   59      5;      5=      5>      5?      .��5@      � -   5         �Name$ Mygrid��5@      .+�5A   
   �� -   5         ��Name$ Restart��5A   8   #��� 
 6   $�� ��6I   $��Center=�6T   $��50��6q   $��0,10,0,0q�6}   $	��Top=�6�   $��50��6�    J� RenderTransformOrigin$ 0.522,0.544&�6�   ��5B      �� 5C       �� ImageSource$I C/png-transparent-smiley-icon-smiley-misCellaneous-face-emoticon.png��6   5E      � 5F   
   -   5        $ Field��5F      $��Center=�6   $
��Auto��6;   $��0,79,0,0q�6I   $	��Top=�6[   $
��Auto��6s   �� 5G   
   -   5         ��Name$ tb��5G      $
��Left=�6    $��25��6;   $��	64,10,0,0q�6G   $
��Wrap=�6Z   $	��Top=�6n   $��68��6�   {�.  $y�Hidden=�6�   �� 5H   
   -   5        $
 back��5H      $ ��Главное 
  меню��6   $��Right=�6=   $��37��6Y   $��0,10,5,0q�6e   $	��Top=�6w   $��49��6�   6�   �� 5I   
   -   5        $ tbBlock��5I      $
��Left=�6%   $
��Auto��6@   $��	10,10,0,0q�6N   $
��Wrap=�6a   $�� ��6u   $	��Top=�6}   $
��Auto��6�   $
��Bold"�6�   $��20(�6�   
���  ��6�   �� 5J   
   $�� ��6   $
��Left=�6   $��25��66   $��5,37,0,0q�6B   $	��Top=�6T   $��25��6l   ��5K      �� 5L      $ /whiteflag.jpg��6   5N      5O      5P      