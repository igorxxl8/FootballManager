   M S B A M L   `   `   `  ����  FootballManager(    "FootballManager.SplashScreenWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  SplashScreenWindow��5   	   $	��350��6$   $	��600��61    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5	   	    � Cursor$ AppStarting��5
   	   
���� �� � 	Resources 5         geometryPath E� IsClosed E� 
StartPoint � Points  geometryPath1  	TextStyle �� 
TargetType	 �� Property
 �� Value3  -System.Windows.Media.Effects.DropShadowEffect   Color   	Direction   ShadowDepth��%�  &	        &	 u     &	 �     B� 5   
   .��5      E�  . $ 50, 220&�6)   .��5      �  �   �(� �6"   5      5      B� 5   
   .��5      E�  . $ 530, 220&�6)   .��5      �  �   ��� �6"   5      5      �� 5   
   " ��6"   .�5      �� 	 �@J�Effect
 5        5      $ 	#FF173B9F��6'   $	 300Q�69   $ 10Q�6I   5      �� 5      	 � ��$
 Center=�62   �� 5      	 � ��$
 Center=�64   �� 5      	 � ��$
 36(�6)   �� 5       	 � ��$
 Cambria Math)�6+   �� 5!      	 � ��$
 Italic$�6*   �� 5"      	 � ��
 �	#FFFAFAFA6+   5#      5$      .��5%      �� .+�5&   
   F� 
������� �� StrokeDashArray$	 2 5R�6   #��[  65   
 �� Top$ 10��6Z    �� Left$ 10��6j   �� 5'   
   $	 150��6   $ 70��6%   #��[ 66   $3��-Футбольный обозреватель��6Y   A� 5(   
   $��25��6   $��25��6   $	 220��6)   $ 50��6:   ��5)      
� 5*       
� RadiusX$ 1Q�6&    
� RadiusY$ 1Q�62    
� GradientOrigin$ 0.3, 0.3&�6>   .��5+      �  � Color$ White��6#    � Offset$ 0Q�61   � 5,      $ Black��6#   $ 1Q�61   5-       � Triggers 5/      :� 50       :� RoutedEvent$ Window.Loaded��6   .[�51      �� .��52      �� .��53      T�  �� TargetProperty$ (Canvas.Top)�67    g� Duration$ 0:0:5D�54   (    g� RepeatBehavior$ Forever��69    T� PathGeometry# [  55   (    T� Source$ Y=�6U   56      T� 57      $ (Canvas.Left)�67   $ 0:0:5D�58   (   $ Forever��69   # [  59   (   $ X=�6U   5:      5;      5<      5=      5?      A� 5@   
   $��25��6   $��25��6   $	 220��6)    �� Right$ 50��6:   ��5A      
� 5B      $ 1Q�6&   $ 1Q�62   $ 0.3, 0.3&�6>   .��5C      � $ White��6#   $ 0Q�61   � 5D      $ Black��6#   $ 1Q�61   5E       5G      :� 5H      $ Window.Loaded��6   .[�5I      �� .��5J      �� .��5K      T� $ (Canvas.Top)�67   $ 0:0:5D�5L   (   $ Forever��69   # [ 5M   (   $ Y=�6V   5N      T� 5O      $ (Canvas.Left)�67   $ 0:0:5D�5P   (   $ Forever��69   # [ 5Q   (   $ X=�6V   5R      5S      5T      5U      5W      5X      5Y      