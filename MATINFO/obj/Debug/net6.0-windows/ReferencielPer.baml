   M S B A M L   `   `   `  ����B  >MATINFO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MATINFOMATINFO  5          MATINFO.ReferencielPer   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:MATINFO     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5          �Name$  referencePer��5   	    � Title$ ReferencielPer��5      $	��450��5	      $	��450��5
       � 
ResizeMode$ NoResize=�5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   $��19��6*   �� 5      .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� -   5         ��Name$ txTitre��5      $��Liste des personnels��6)   5      �� 5   
   -   5         ��Name$ btSupprimer��5      $��1��5      $��41��5      $��	0,0,10,56q�5      $��Bottom=�5      $��	Supprimer��5        J� RenderTransformOrigin$ 0.5,0.5&�5!      ���	#FFFB2222$	��204��6D   $��Right=�6P   z�5"      V� 5#      .~�5$      ��  �� ScaleX$ 1Q�6%   �� 5%      �� 5&      T� 5'      5(      5*      &   System.Windows.Controls.DataGrid  5+   
   -   5        	  Name$	 dgPersonnel��5,      $��1��5-      $��10,10,10,102q�5.      
   CanUserAddRows$
 False��50         AutoGenerateColumns$ False��51      ���	#FFBAC1F9��5/      ��  �� Path$% gestionAttribution.LesPersonnel�   Columns 53      0  *System.Windows.Controls.DataGridTextColumn  54      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6J      
IsReadOnly$
 True��6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� $ Idpersonnel�6V     55      $ Prenom��6N    6%   �� $ Prenompersonnel�6N     56      $	 Nom��6K    6%   �� $ Nompersonnel�6K     57      $ Email��6M    6%   �� $ Emailpersonnel�6M   59      �� 5:   
   -   5        $ 	btAjouter��5;      $��1��5<      $��41��5=      $��	10,0,0,56q�5>      $��Bottom=�5?      $��Ajouter��5A      $ 0.5,0.5&�5B      ���	#FF22FB22$	��204��6D   $
��Left=�6P   z�5C      V� 5D      .~�5E      �� $ 1Q�6%   �� 5F      �� 5G      T� 5H      5I      5K      �� 5L   
   -   5        $
 btOK��5M      $��1��5N      $��41��5O      $��
10,0,10,10q�5P      $��Bottom=�5Q      $��Valider Ajout��5S      $ 0.5,0.5&�5T      ���	#FF2A77F3z�5U      V� 5V      .~�5W      �� $ 1Q�6%   �� 5X      �� 5Y      T� 5Z      5[      5]      5^      5_      