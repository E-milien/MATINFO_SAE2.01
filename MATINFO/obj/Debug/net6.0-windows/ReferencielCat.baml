   M S B A M L   `   `   `  ����B  >MATINFO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MATINFOMATINFO  5          MATINFO.ReferencielCat   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:MATINFO     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5          � Title$  ReferencielCat��5      $	��450��5	      $	��450��5
       � 
ResizeMode$ NoResize=�5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   $��19��6*   �� 5      .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� -   5         ��Name$ txTitre��5      $��Liste des categorie��6)   5      �� 5   
   -   5         ��Name$ btSupprimer��5      $��1��5      $��41��5      $��	0,0,10,56q�5      $��Bottom=�5      $��	Supprimer��5        J� RenderTransformOrigin$ 0.5,0.5&�5!      ���	#FFFB2222$��Right=�6D   $	��204��6`   z�5"      V� 5#      .~�5$      ��  �� ScaleX$ 1Q�6%   �� 5%      �� 5&      T� 5'      5(      5*      &   System.Windows.Controls.DataGrid  5+   
   -   5          Name$ dgCategorie��5-      	   AutoGenerateColumns$	 False��5,      $��1��5.      $��10,10,10,104q�5/      
 �� SelectedIndex$
 0��50   J      CanUserAddRows$ False��51      ���	#FFBAC1F9��50      ��  �� Path$% gestionAttribution.LesCategorie�   Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6&      
IsReadOnly$
 True��6W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� $ Idcategorie�6W     54      $	 Nom��6&    63   �� $ Nomcategorie�56      �� 57   
   -   5        $ 	btAjouter��58      $��1��59      $��41��5:      $��	10,0,0,56q�5;      $��Bottom=�5<      $��Ajouter��5>      $ 0.5,0.5&�5?      ���	#FF22FB22$
��Left=�6D   $	��204��6_   z�5@      V� 5A      .~�5B      �� $ 1Q�6%   �� 5C      �� 5D      T� 5E      5F      5H      �� 5I   
   -   5        $
 btOK��5J      $��1��5K      $��41��5L      $��
10,0,10,10q�5M      $��Bottom=�5N      $��Valider Ajout��5P      $ 0.5,0.5&�5Q      ���	#FF2A77F3z�5R      V� 5S      .~�5T      �� $ 1Q�6%   �� 5U      �� 5V      T� 5W      5X      5Z      5[      5\      