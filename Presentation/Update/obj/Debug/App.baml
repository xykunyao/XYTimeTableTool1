   M S B A M L   `   `   `  ����
  Update    
Update.App   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        �� 	Resources  5         ProgressBar.Progress �� Color  ProgressBar.Background  ProgressBar.Border  UpdateProgressBar �� 
TargetType �� Property �� Value �� 
TargetType �Name'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState	   
Storyboard
 g� RepeatBehavior �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value8  2System.Windows.Media.Animation.EasingPointKeyFrame $� KeyTime $� Value �� CornerRadius J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   	Direction   Color   
BlurRadius   ShadowDepth ��Name J� RenderTransformOrigin �� Triggers P� Property P� Value �� 
TargetName �� Angle��%�  &	        &	 %     &	 L     &	 s     7  7  �� 5   
   $ #4C9FFB��5      �� 5	   
   $ 	#FFE6E6E6��5
      �� 5   
   $ 	#FFBCBCBC��5      �� 5   
   " �5      .�5      ��  � �� �#5576BD5      �� 5       � ��8   5      �� 5       � ��8  5      �� 5       � ��$ 20��5      �� 5       � ��$ 1q�5      �� 5       � �� 5      �� 5      " �6&   .R�5      � $ TemplateRoot��6    5        5    "   CommonStates��. 5!   &     Determinate��62     5"   &   Indeterminate��.	 5#   *   �� $
 Forever��65   .��5$   .   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6L   $ 	Animation��5%   L   .\�5&   2     $ 0��6G   $
 0.25Q�5'   G     5(   2   $ 0:0:1��6G   $
 0.25Q�5)   G     5*   2   $ 0:0:2��6G   $
 0.25Q�5+   G   5,   /   *� 5-   .   $' !(UIElement.RenderTransformOrigin)�6K   $ 	Animation��5.   K   .'�5/   2     $ 0��6F   $ -0.5,0.5&�50   F     51   2   $ 0:0:1��6F   $ 0.5,0.5&�52   F     53   2   $ 0:0:2��6F   $ 1.5,0.5&�54   F   55   /   56   +   57   '   58   #   .+�5:      �� #��z��6%   #��z��5;   %   $ 10��5<   %   #��z��5=   %    5>   "     5?   &   $ 1Q�67   $ 	LightBlue��5@   7   $ 5Q�5A   7   $ 0Q�5B   7   5D      �� 5E      $ 
PART_Track��6%   $ 10��5F   %   ���	#FFFBFBFB5G   %   � 5H      $ PART_Indicator��6#   }�. $
��Left=�5J   #   .+�5K   "   �� $ 	Indicator��6)   $ 10��5L   )   #��z��5M   )   �� 5N   "   $ 	Animation��6)   $ 10��5O   )   #��z��5P   )   $ 0.5,0.5&�5Q   )   z�5R   &   V� 5S   *   .~�5T   .   �� �� 5U   .   �� 5V   .   T� 5W   .   5X   +   5Z   #   5[      5\       5]      P� 5^       �@�Orientation$ Vertical=�5_   &   . �5`   "   �� $ TemplateRoot��5a   )    �@�LayoutTransform 5b   &   �� 5c   *   $	 -90Q�6:   5e   #   5f      P� 5g       �@�IsIndeterminate . . �5i   "   �� $ 	Indicator��5j   )    � y�$ 	Collapsed=�5k   )   5l      5n      5p      5q      5r      5s      