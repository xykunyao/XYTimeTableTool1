   M S B A M L   `   `   `  ����
  Update    Update.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5          �Name$
  main��5   	    � Title$ 更新程序��5   	   $	��370��5   	    � WindowStyle$
 None=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � AllowsTransparency .  � 
ResizeMode$ NoResize=�5   	    � SizeToContent$ Height=�5   	    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5   
      Color$ #D4D5D6��6   	   ShadowDepth$	 2Q�5      
   Opacity$	
 0.8Q�5         
BlurRadius$ 15Q�5      .��5      � $��15q�6   
������� � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��50 �6   .+�5   
   �� $��Center=�6   $
��Left=�5       $
��Bold"�5!       J� Opacity$	 0.5Q�5"      $��14(�5#      $��升级中...��5$      $��15,0,0,0q�5%      5&      � 5(   
   $��1��6   $��15,10q�5)         UpdateProgressBar#���   5*       � Value 5+      �� *ExecutionPercentage+5,      5-      5.      