   M S B A M L   `   `   `  ����B  >MATINFO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MATINFOMATINFO  5          MATINFO.ReferencielMat   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:MATINFO     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5          � Title$  ReferencielMat��5      $	��450��5	      $	��450��5
       � 
ResizeMode$ NoResize=�5      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $��2* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   $��19��6*   �� 5      .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��2��6;   .+�5      �� -   5         ��Name$ txTitre��5      $��Liste des matériels��6)   5      �� 5   
   -   5         ��Name$ btSupprimer��5      $��1��5      $��41��5       $��	0,0,10,10q�5!      $��Bottom=�5"      $��	Supprimer��5$       J� RenderTransformOrigin$ 0.5,0.5&�5%      $��1��6-   $	��204��6=   $��Right=�6I   ���	#FFFB2222z�5&      V� 5'      .~�5(      ��  �� ScaleX$ 1Q�6%   �� 5)      �� 5*      T� 5+      5,      5.      �� 50   
   -   5        	 ��Name$	 lvCategorie��50      $��1��51      $��0��52      $��
10,10,0,56q�6   ���	#FFBAC1F9
 �� SelectionMode$
 Multiple=�55      ��53      ��  �� Path$% gestionAttribution.LesCategorie� �� View 56      �� 57      .P�58      �� $��Nom categorie��59       �� Width$	 125��5;       �� DisplayMemberBinding 5:      �� $ Nomcategorie�5;      5<      5>      � 5@   
   $��1��6   $��10,10,10,56q�6   $��1��64   .+�5A      &   System.Windows.Controls.DataGrid  -   5          Name$ 
dgMateriel��5B         AutoGenerateColumns$ false��5C         CanUserAddRows$ False��5E      ���	#FFBAC1F9��5D      �� $ LesMateriel�   Columns 5F      0  *System.Windows.Controls.DataGridTextColumn  5G      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6H      
IsReadOnly$
 True��6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *
Idmateriel+6T     5H      $	 Nom��6I    6)   �� *Nommateriel+6I     5I      $ 
Code barre��6G    6)   �� *	Codebarre+6G     5J      $ 	Reference��6O    6)   �� *Referencemateriel+6O   5L      5M      �� 5N   
   -   5        $ 	btAjouter��5O      $��1��5P      $��41��5Q      $��	10,0,0,10q�5R      $��Bottom=�5S      $��Ajouter��5U      $ 0.5,0.5&�5V      $��2��6-   $	��204��6A   $
��Left=�6M   ���	#FF22FB22z�5W      V� 5X      .~�5Y      �� $ 1Q�6%   �� 5Z      �� 5[      T� 5\      5]      5_      5a      5b      