   M S B A M L   `   `   `  ����G  CCoursesAdmin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CoursesAdmin.PageCoursesAdmin.Page  5           CoursesAdmin.Page.MainPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:CoursesAdmin.Page     5      V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � -   5          �Name$
  main��5
      .+�5   
   �  � RowDefinitions 5      �� 5      $
��103* �6    60   �� 5      $��5 �6    6-   �� 5      $	��73* �6    6/   �� 5      $��5 �6    6-   �� 5      $	��150 �6    6/   .+�5      �� $��1��6   ���#F1F1F166   �� 5      $��3��6   ���#F1F1F166   �� 5      $��0��6   .+�5      �� $��2q�6   $��Medium"�6'   $��Модули��6;   6K   �� 5      -   5         ��Name$ lv��5   :   $
��Auto=�6F   $
��Auto=�6v   $	��305��6�   ��6   �� *module+ � ContextMenu 5      �� 5      .@�5      m� -   5         m�Name$ 	addModule��5   '   $��Добавить��6V   
�������6h   m� 5      -   5        $ deleteModule��5   '   $��Удалить��6Y   
�������6j   m� 5      -   5        $ 
editModule��5   '   $��Изменить��6X   
�������6j   5      ��5      �� 5       .R�5!      A�  A� Columns$ 3��6*   68   5"      ��5$      �� 5%      .R�5&      �� $��10q�6%   $	��150��61   $	��200��6=   ._�5'   "   �� .+�5(   &   �� $��50��6-   $��50��68    �� CornerRadius$ 5��6D   $��5q�6U    J� Effect 5)   *   3  -System.Windows.Media.Effects.DropShadowEffect  5*   .      ShadowDepth$ 1Q�6?   ��5,   *   �� 5-   .   	 �� ImageSource	 69   �� *moduleImage+5/   '   �� 50   &   
 �� TextAlignment$
 Center=�60   $
��Wrap=�6G   $	��5 0q�6[   $��12(�6�   ��6h   �� *
moduleName+6�   51   #   52      53      ��55      �� 56       �� 
TargetType" ��6    .�57      ��  �� Property � �� �� Value 58   "   �� 59   &    �� 
TargetType" ��66   .R�5:   *   �� 5;   '   5=      -   5         �� Triggers 5@      P� 5A   "    P� Property �@J�IsMouseOver P� Value . . �5B   &   ��  �@�Cursor$
 Hand��6?   6N   5C   #   5E      5G      �� 5H      $��Center=�6    �� Orientation$ 
Horizontal=�6:   5I      �� 5J      $��2��6   .+�5K      �� -   5         ��Name$ 
moduleName��5K   ;   $��2q�6   $��Medium"�6'   $$��Разделы модуля - ��6O   6j   �� 5L      -   5         ��Name$ 	submodule��5L   2   $	��Top=�6   $��Arial)�6E   $��15(�6X   $��2q�6f   $	��169��6�   ��6q   ��  5M      �� 5N      .@�5O      m� -	   5        $ addSubmodule��5O   '   $��Добавить��6]   
�������6o   m� 5P      -
   5        $ deleteSubmodule��5P   '   $��Удалить��6_   
�������6p   m� 5Q      -   5        $ editSubmodule��5Q   '   $��Изменить��6^   
�������6p   5R      ��5T      �� 5U      " ��6    .�5V      ��  � �� 5W   "   �� 5X   &   " ��66   .R�5Y   *   ��  ��Name$ listItem��65   .+�5Z   .   �� 
���   �$��3q�6K   $
��Wrap=�6V   ��6j   �� *submoduleName+5[   +    �� Triggers 5\   *   P� 5]   .    �@J�IsMouseOver . . �5^   2   ��  �� 
TargetName$ listItem��69    � �� �#F1F1F16e   5_   /   5a   '   5c      -   5        5e      5g      5h      �� 5i      $��4��6   .+�5j      �� -   5        $ testModuleName��5j   ;   $��2q�6   $��Medium"�6'   $��Тест модуля -��6S   6j   �� 5k      -   5        $ 
testModule��5k   �   $
��Auto=�6   $
��Auto=�6L   $	��Top=�6|   $��Arial)�6�   $��15(�6�   $��2q�6�   $	��128��6�   ��6�   ��  5l      �� 5m      .@�5n      m� -   5        $ addQuestion��5n   '   $��Добавить��6[   
�������6m   m� 5o      -   5        $ deleteQuestion��5o   '   $��Удалить��6]   
�������6n   m� 5p      -   5        $ editQuestion��5p   '   $��Изменить��6\   
�������6n   m� 5q      -   5        $ 
editAnswer��5q   '   $-��'Редактировать ответы��6Z   
�������6x   5r      ��5t      �� 5u      " ��6    .�5v      ��  � �� 5w   "   �� 5x   &   " ��66   .R�5y   *   �� $ listItem��65   .+�5z   .   �� 
���   �$��3q�6K   $
��Wrap=�6V   ��6j   �� *questionText+5{   +    5|   *   P� 5}   .    �@J�IsMouseOver . . �5~   2   �� $ listItem��69    � �� �#F1F1F16e   5   /   5�   '   5�      -   5        5�      5�      5�      5�      )  #MaterialDesignThemes.Wpf.DialogHost  5�   
   -   5          Name$ dialogQuestion��5�   3      IsOpen .     
Identifier$ editQuestion��6K      DialogContent 5�      � 5�      $��20q�6   .+�5�      �� .+�5�      �� -   5         ��Name$ questionText��5�   "   $��10q�68   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Вопрос��6D    %  !MaterialDesignFloatingHintTextBox#��[  6l   $��Champagne & Limousines)�6�   $��18(�6�   �� 5�      -   5         ��Name$ addEditButton��5�   I   $��10q�6=   $��Добавить��6`   6u   5�      5�      5�      5�      5�      