   M S B A M L   `   `   `  ����S  OTarea9_POO_PabloGuerrero, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Tarea9_POO_PabloGuerreroTarea9_POO_PabloGuerrero  5   	   $    Tarea9_POO_PabloGuerrero.Intro   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:Tarea9_POO_PabloGuerrero     5   	     � Title$  Intro��5   	   $	��450��6   $	��800��6$    � WindowStartupLocation$ CenterScreen=�60    � WindowStyle$
 None=�6U   .��5	      � ��5
   
   �� 5       �� ImageSource$ Imagenes/FondoBosque.png��6   .+�5   
   �� $��Center=�6   $	��Top=�61   $��18(�6I   $
��Bold"�6W   $��0,20,0,0q�6i   ���#2ca4a8$��77��6�   �� 6�   $J�DTe encuentras a un hombre misterioso que te bloquea el camino, para ��6�   �� 5      �� 6   $I�C                     poder avanzar tienes que ganarle a los dados. ��6   �� 5      �� 6   $R�L                          Tienes un máximo de 3 oportunidades              ��6   5      �� 5   
   -   5         ��Name$ imgDadoJugador��5      $
��Left=�6(   $	��Top=�6C   $��225,170,0,0q�6[   $��75��6p   $��75��6|   $��Imagenes/Dado.png��6�   �� 5   
   -   5        $ 
imgDadoNPC��5      $��Right=�6$   $	��Top=�6@   $��0,170,225,0q�6X   $��75��6m   $��75��6y   $��Imagenes/Dado.png��6�   �� 5   
   -   5        $ imagenExplorador��5      $
��Left=�6*   $	��Top=�6E   $��
50,170,0,0q�6]   $	��150��6q   $	��100��6~   �� 5   
   -   5        $ 	imagenNPC��5      $��Right=�6#   $	��Top=�6?   $��
0,170,50,0q�6W   $	��150��6k   $	��100��6x   �� 5   
   -   5         ��Name$ txtResultado��5      $�� ��6*   $��Center=�62   $��Center=�6O   $��16(�6j   $
��Bold"�6x   $��	0,200,0,0q�6�   ���	#FF2CA4A86�   �� 5   
   -   5         ��Name$ btnLanzarDados��5      $��Center=�6)   $	��Top=�6F   $��62��6{   $	��102��6�   $��	0,363,0,0q�6�   ��5       �� 5!      $! Imagenes/btnLanzarDados.png��6   5#      �� 5$   
   -   5        $ btnContinuar��5$   &   $��547,357,0,0q�6   $
��Left=�6<   $	��Top=�6W   $��50��6�   $	��150��6�   $y�	Collapsed=�6�   ��5%      �� 5&      $ Imagenes/btnContinuar.png��6   5(      5*      5+      