   M S B A M L   `   `   `  ����C  ?WpfTarea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfTareaWpfTarea  5          WpfTarea.Report   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:WpfTarea     5        N� Title$  Gastos-Ver Reporte��5	      .��5      �  � 	Resources 5   
      typeItemTemplate �� XPath  amountItemTemplate��%�   &	        &	 I     �� 5      .R�5      �� ��6   �� $ @TipoDeGasto��5      �� 5      .R�5      �� ��6   �� $ 	@Cantidad��5      5      ��5   
   �� 5       �� ImageSource$ FondoRegistro.png��6    � ColumnDefinitions 5   
   �� 5      $	��230 �6   �� 5       � RowDefinitions 5!   
   �� 5"      �� 5#      $
��Auto �6   �� 5$      .+�5'   
   �� $��0��6     headerTextStyle#��[ 6    $��57,28,513,0q�6I   $	��Top=�6^   $��2��6v   $��0��6�   .��6�   Reporte de Gastos5)      � 5*   
   $��10q�6   $��1��6   $��1��6+    5+      �� 5,      �� 5-       5/      �� 51      $
��Auto �6    �� 52      $
��Auto �6    �� 53      .+�57      �� $��0��6   $��2��6)   $��0��6=    �� Orientation$ 
Horizontal=�6J   .+�58      ��   
labelStyle#��[ 6   .��6<   	Nombre:6E   �� 59      #��[ 6   ��6<   �� $ @Nombre��6`   5:      �� 5=      $��0��6   $��2��6)   $��1��6=   $ 
Horizontal=�6J   .+�5>      �� #��[ 6   .��6<   Departamento:6K   �� 5?      #��[ 6   ��6<   �� $ @Departamento��6f   5@      � 5D      $��0��6   $��2��6#   $��2��67   $	��Top=�6D   $
��Left=�5E      .+�5G      &   System.Windows.Controls.DataGrid    columnHeaderStyle   ColumnHeaderStyle# [ 6      AutoGenerateColumns$ False��5H      	   RowHeaderWidth$	 0Q�61   $��	0,0,10,27q�6D   
   Columns
 5I      4  .System.Windows.Controls.DataGridTemplateColumn  5J      ,  &System.Windows.Controls.DataGridColumn   Header$ Tipo de Gasto��61     5K      $ Cantidad��61   .@�5N        # [ 6J   $ False��6�   $	 0Q�6�   ��6   �� $ Nombre/Gasto��
 5P        5Q      $ Tipo de Gasto��65      CellTemplate# [  6L     5R      $ Cantidad��65   # [ 6G   5U      5W      5X      5Y      5\      5_      