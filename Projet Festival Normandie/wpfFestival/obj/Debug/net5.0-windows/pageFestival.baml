   M S B A M L   `   `   `  ����F  BwpfFestival, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:wpfFestivalwpfFestival  5          wpfFestival.pageFestival   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:wpfFestival     5        N� Title$  pageFestival��5	      .��5      � ��5   
   �� 5       �� ImageSource$) #/Images/Bouton image/Background.jpg��6    �� RelativeTransform 5      V� 5      .~�5      ��  �� CenterY$	 0.5Q�6)    �� CenterX$	 0.5Q�67   �� 5       �� CenterY$	 0.5Q�6(    �� CenterX$	 0.5Q�66   �� 5       �� Angle$	 -90Q�6*    �� CenterY$	 0.5Q�66   	 �� CenterX$		 0.5Q�6D   T� 5      5      5      .+�5   
   �� -   5        $
��Left=�5      $��90��6,   $��
110,35,0,0q�68   $	��Top=�6L   $	��170��6d   6p   �� 5   
   -   5        $
��Left=�5      $��90��6,   $	��Top=�68   $	��170��6P   $��110,168,0,0q�6p   �� 5   
   -   5        $
��Left=�5      $��90��6,   $��110,304,0,0q�68   $	��Top=�6M   $	��170��6e   6q   &   System.Windows.Controls.DataGrid  5   
   -   5        
  Name$
 
dgFestival��5      $
��Left=�6)   $	��268��6D   $��
400,53,0,0q�6Q   $	��Top=�6e   $	��333��6}      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nom du Festival��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *Nom_Festival+  5      $ Lieu du Festival��6%    6?   �� *Lieu+  5      $ Nom des organisateurs��6%    6D   �� *Organisateur+5!      5$      5%      