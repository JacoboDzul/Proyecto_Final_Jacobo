   M S B A M L   `   `   `  ����  Proyecto_Final_23AM$    Proyecto_Final_23AM.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Login��5   	   $	��450��6   $	��800��6$    � WindowStartupLocation$ CenterScreen=�5       J� OpacityMask
 ����� � WindowStyle$
 None=�5   	   
������  � AllowsTransparency$
 true��5   	    � 
ResizeMode$ NoResize=�5	   	   .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��20* �6   �� 5      $	��19* �6   �� 5      .+�5   
   �� $��0��6   $1��+Images/erik-mclean-BXiLSwwvqrY-unsplash.jpg��6    $��UniformToFill=�6U   $��	0,0,0,-53q�6m   � 5   
   $��1��6   ���#F0F6F9$��0,0,-15,-55q�64   $��2��6I    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��40(�6   $��Login��6"   $��Center=�62   $��Center=�6O   $��Center=�6j   $��Segoe UI Semibold)�6�   ���	#FF26A015
�������$	��440��6�   �� 5      $��1��6   $��20(�6!   $��Usuario��6/   $��Center=�6A   $��Center=�6^   $��Center=�6y   $
��0,20q�6�   �� 5       -   5         ��Name$ txtUser��5       $��1��6'   $��15(�64   $��Center=�6B   $	��Top=�6_   $	��200��6w   $��30��6�   $��0,72,0,0q�6�   $��2��6�   �� 5"      $��3��6   $��20(�6!   $��Password��6/   $��Center=�6B   $��Center=�6_   $��Center=�6z   $
��0,20q�6�   G� 5#      -   5        	 G�Name$	 txtPassword��5#      $��3��6/   $��15(�6<   $��Center=�6J   $	��Top=�6g   $	��200��6   $��30��6�   $��0,76,0,0q�6�   $��2��6�   �� 5%      -   5        
 ��Name$
 btnLogin��5%   "   $��4��6   $��Iniciar Sesión��64   $
��Left=�6M   $	��Top=�6h   $	��150��6�   $��35��6�   $��
134,90,0,0q�6�   ���#5CC754
�������6�   �� 5&      -   5        $
 BtnAbrir��5&      $��Ventana��6'   $
��Left=�69   $��165,182,0,0q�6T   $��4��6i   $��20��6�   $	��Top=�6�   5'      5(      5)      