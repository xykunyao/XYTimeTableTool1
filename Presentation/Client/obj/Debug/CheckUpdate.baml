   M S B A M L   `   `   `  ����
  Client    Client.CheckUpdate   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5          �Name$
  main��5   	   $	��370��5   	    � Title$ 检查更新��5	   	    � WindowStyle$
 None=�5
   	      logo � Icon# �   5   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � AllowsTransparency .  � 
ResizeMode$ NoResize=�5   	    � SizeToContent$ Height=�5   	    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5   
   	   Color$	 #D4D5D6��6   
   ShadowDepth$
 2Q�5         Opacity$	 0.8Q�5         
BlurRadius$ 15Q�5      .��5      � $��15q�6   
������� � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��60 �6   �� 5       $��60 �6   .+�5#   
   �� $%��开源排课工具-升级程序��6   $��Center=�5$      $
��Left=�5%      $
��Bold"�5&       J� Opacity$	 0.5Q�5'      $��14(�5(      $��15,0,0,0q�5)      �� 5+   
   -   5        $��	btn_close��5,        CloseButtonStyle#���  5+      
�������$��Right=�50      $��0,0,10,0q�51      ��5.      �� *CancelCommand+��5/      ��  �� ElementName$
 main��51      � 53   
   $��1��6   $��15,10q�54        UpdateProgressBar#���  55       � Value 56      �� *ExecutionPercentage+57      �� 59   
   $	��179��6   $��15,10q�5:      $��2��5;       �� 
IsReadOnly . $��1q�5=      $	��Top=�5>       �� TextWrapping$
 Wrap=�5?      $��12(�5@      $ 1Q�5A      " �� VerticalScrollBarVisibility$
 Auto=�5B       �� AcceptsReturn . ��5C      �� *	Content+5D      �� 5F   
   $��3��6   $
��15,5q�5G      .+�5H      �� $��提示��6   $��5q�5I      $
��Left=�5J      �� 5K      $
��20,5q�5L      $
��Left=�5M      ��5K      �� *	Message+5M      5N      �� 5P   
    �� Orientation$ 
Horizontal=�6   $��4��5Q      $��10q�5R      $��Right=�5S      .+�5T      �� $��继续��6   $��2q�5W      $��80��5X      ��5U      �� *PursueCommand+{�5V      �� *PursueEnable+5X      �� 5Y      $��取消��6   $��2q�5\      $��80��5]      ��5Z      �� *CancelCommand+��5[      �� $
 main��5]      5^      5_      5`      