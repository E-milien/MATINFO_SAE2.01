   M S B A M L   `   `   `  ����B  >MATINFO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MATINFOMATINFO  5          MATINFO.ReferencielAtt   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:MATINFO     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5          �Name$  ReferenceAtt��5   	    � Title$ ReferencielAtt��5      $	��450��5	      $	��450��5
       � 
ResizeMode$ NoResize=�5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   $��19��6*   �� 5      .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� -   5         ��Name$ txTitre��5      $��Liste des attribution��6)   5      �� 5   
   -   5         ��Name$ btSupprimer��5      $��1��5      $��0,0,8,10q�5      $��	Supprimer��5       J� RenderTransformOrigin$ 0.5,0.5&�5      $��41��6-   $��Bottom=�69   ���	#FFFB2222$��Right=�6k   $	��204��6�   z�5       V� 5!      .~�5"      ��  �� ScaleX$ 1Q�6%   �� 5#      �� 5$      T� 5%      5&      5(      �� 5*   
   -   5        $ 	btAjouter��5+      $��1��5,      $��	10,0,0,10q�5-      $��Ajouter��5/      $ 0.5,0.5&�50      $��41��6-   $��Bottom=�69   ���	#FF22FB22$
��Left=�6k   $	��204��6�   z�51      V� 52      .~�53      �� $ 1Q�6%   �� 54      �� 55      T� 56      57      59      &   System.Windows.Controls.DataGrid  5:   
   -   5        	  Name$	 dgAttribution��5:      $��10,10,10,62q�6i   $��1��6~   
   AutoGenerateColumns$
 False��6�    �� SelectedIndex$ 0��6�      CanUserAddRows$ False��6�   ���	#FFBAC1F7��6*   ��  �� Path$' !gestionAttribution.LesAttribution�   Columns 5;      0  *System.Windows.Controls.DataGridTextColumn  5<      ,  &System.Windows.Controls.DataGridColumn   Header$ ID Materiel��6%      
IsReadOnly$
 True��6^   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� $ 
IdMateriel�6^     5=      $ ID Personnel��6%   $
 True��6`    6;   �� $ IdPersonnel�6`     5>      $
 Date��6%    63   �� $ DateAttribut� �� StringFormat$ d��  5?      $ Commentaire��6%    6:   �� $ Commentaire�5A      5C      5D      