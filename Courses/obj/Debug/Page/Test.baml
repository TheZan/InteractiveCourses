   M S B A M L   `   `   `  ����B  >Courses, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Courses.PageCourses.Page  5          Courses.Page.Test   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Courses.Page     5      V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  67   .��5	      � -   5          �Name$
  main��5	      .+�5
   
   �� .+�5      �� -   5         ��Name$ 
groupTitle��5   7   $
��Wrap=�6   $��5q�6,   $��24(�6i   ��6K   �� *questionText+6y   �� 5      -   5         ��Name$ 	answerBox��5   1   $��Center=�6   $��Arial)�6D   $��20(�6W   $	��0,2q�6e   $
��Left=�6�   ��6r   �� ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value 5      �� 5   "    �� 
TargetType" ��62   .R�5   &   ��  ��Name$ listItem��61   .+�5   *   �� $��3q�64   $
��Wrap=�6?   ��6S   �� *
answerText+5   '    �� Triggers 5   &   P� 5   *   	 P� Property	 �@J�IsMouseOver
 P� Value
 . . �5   .   ��  �� 
TargetName$ listItem��65    � �� �#F1F1F16a   5   +   5   #   5      -   5        5      5       �� 5!      -   5        $ messageError��5!      $y�	Collapsed=�6.   $��Center=�6E   $��18(�6b   $��Arial)�6p   
���  ��$/��)Выбран неверный ответ!��6�   6�   5"      )  #MaterialDesignThemes.Wpf.DialogHost  5#   
   -   5          Name$ 	dialogEnd��5#   3      IsOpen .     
Identifier$ 
endTesting��6F      DialogContent 5$      � 5%      $��20q�6    � RowDefinitions 5&      �� 5'      6*   �� 5(      6*   .+�5*      �� $��0��6!   .+�5+      �� $��5q�6$   $��0��6/   $��Center=�6<   $��Center=�6W   
��� � �$��20(�6�   $U��OПоздравляем! Вы разблокировали достижение!��6�   �� 5,      -   5         ��Name$ 
badgeImage��5,       $��Center=�64   $��5q�6Q   ��6\   �� *
badgeImage+6|   5-      �� 5.      $��Center=�6!   $��1��6>    �� Orientation$ 
Horizontal=�6K   .+�5/      �� -   5         ��Name$ goMain��5/   6   $��5q�6F   $��На главную��6Q   6h   �� 50      -	   5        $ 	goProfile��50   9   $��5q�6L   $��В профиль��6W   6m   51      52      54      55      56      