   M S B A M L   `   `   `  ����E  AWPFcontact, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WPFcontact
WPFcontact  5   	   !    WPFcontact.newContactWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WPFcontact     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Add Contact��5	   	   $	��500��6   $	��350��6*    � WindowStartupLocation$ CenterScreen=�66    � 
ResizeMode$ NoResize=�6[    � WindowStyle$
 None=�6q   .��5
      � .+�5   
   �� $	��280��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF2281D1��6#   � 5      $ 	#FF34268A��6#    � Offset$ 1Q�65   � 5      $ 	#FF332888��6#   $	 0.5Q�65   5      5      �� 5   
   $��call.png��6   $	��100��6"   $	��100��6.   $
��Fill=�6;   $	��Top=�6J   $��Center=�6b   $��0,35,0,0q�6   �� 5   
   $	��280��6   $	��240��6    
�������$��Bottom=�6:   $��0,100q�6U    �� RadiusX$
 20.5��6d   	 �� RadiusY$
	 20.5��6s   
 J� Effect
 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 15Q�6#      ShadowDepth$ 1Q�63      	Direction$ 0Q�6C      RenderingBias$ Quality=�6Q      Color$ 	#FFBBBBBB��6i   5      � 5   
   $	��280��6   $	��240��6   $��Bottom=�6(   $��0,100q�6C   .+�5      �� $��Add contact��6   $��Center=�6+   $	��Top=�6H   $��5q�6`   
�������$��18(�6}   �� 5       $��Center=�6   $��10q�64   .+�5!      �� -   5         ��Name$ nameTextBox��5!   �   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 Name��6    %  !MaterialDesignFloatingHintTextBox#��[  6@   $
��0,10q�6{   6�   �� 5"      -   5        $ emailTextBox��5"   �   $ Email��6   #��[  6A   $
��0,10q�6|   6�   �� 5#      -   5        $ phoneNumberTextBox��5#   �   $ Phone��6   #��[  6A   $
��0,10q�6|   6�   5$      5%      � 5'   
   -   5        $��40��5'      $��25��6   $	��Top=�6&   $��Right=�6>   ���	#FF2196F3.+�5(      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6&   
�������$��Center=�6F   $��Center=�6c   $��40��6~   $��25��6�   5)      �� 5+   
   -   5        $	��310��5+      $��25��6!   $
��Left=�6.   $	��Top=�6I   ��5,   
   �� 5-       �� Color$ 	#FF2196F3��6   5/      �� 53   
   -   5        $��Center=�53   *   $��Bottom=�6G   $
��0,85q�6b   $	��150��6p   $
��Save��6|   55      56      