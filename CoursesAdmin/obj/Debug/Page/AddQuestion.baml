   M S B A M L   `   `   `  ����G  CCoursesAdmin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CoursesAdmin.PageCoursesAdmin.Page  5      #    CoursesAdmin.Page.AddQuestion   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:CoursesAdmin.Page     5      V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � -   5          �Name$
  main��5
      .+�5   
   �� .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ questionName��5   8   {�.  $	��540��6,   $��10q�6N   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Вопрос��6Z    %  !MaterialDesignFloatingHintTextBox#��[  6�   $��Champagne & Limousines)�6�   $��18(�6�   �� 5      -   5         ��Name$
 back��5   -   $��Right=�6;   $��
Назад��6W   6i   5      �� 5      .+�5      �� -   5         ��Name$ lvAnswer��5      $	��194��6-    � ContextMenu 5      �� 5      .@�5      m� -   5         m�Name$ 
setCorrect��5   '   $8��2Сделать правильным ответом��6U   
�������6y   5      ��5      �� 5       �� 
TargetType" ��6    .�5      �� 	 �� Property	 � ��
 �� Value
 5   "   �� 5   &    �� 
TargetType" ��66   .R�5   *   ��  ��Name$ listItem��65   .+�5   .   �� 
���   �$��3q�6K   $
��Wrap=�6V   ��6j   �� *
answerText+5   +    �� Triggers 5   *   P� 5    .    P� Property �@J�IsMouseOver P� Value . . �5!   2   ��  �� 
TargetName$ listItem��69   	 � ��
 �#F1F1F16e   5"   /   5$   '   5&      -   5        5)      5+      �� 5,      $��5��6   ���#F1F1F168   �� 5-      -   5        $ 
answerText��5-      $��10q�6.   $ 
Ответ��6:   #��[  6a   $��Champagne & Limousines)�6�   $��18(�6�   �� 5.      -   5         ��Name$ correctAnswer��5.      $
��Wrap=�63   $��15(�6G   $��Arial)�6U   6j   �� 5/      -	   5        $ 	addButton��5/   1   $��5q�6D   $��Добавить��6O   6d   �� 50      -
   5        $ addEditButton��50   5   $��5q�6L   $��Изменить��6W   6l   �� 51      -   5        $ 	delButton��51   1   $��5q�6D   $��Удалить��6O   6c   52      53      54      55      