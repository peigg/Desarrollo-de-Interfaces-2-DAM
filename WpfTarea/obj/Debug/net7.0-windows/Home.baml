   M S B A M L   `   `   `  ����C  ?WpfTarea, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfTareaWpfTarea  5          WpfTarea.Home   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:WpfTarea     5        N� Title$  ExpenseIt - Home��5	      .��5      � $��0,0,0,0q�6    � 	Resources 5   
      ExpenseDataSource � XPath  nameItemTemplate �� XPath��%_  &	        &	     � 5      $ Gastos��68   .��5      �	�	<Gastos xmlns="">
                        <Nombre Nombre="Miguel" Departamento="Legal">
                            <Gasto TipoDeGasto="Comida" Cantidad="50" />
                            <Gasto TipoDeGasto="Transporte" Cantidad="50" />
                        </Nombre>
                        <Nombre Nombre="Lisa" Departamento="Marketing">
                            <Gasto TipoDeGasto="Impresora" Cantidad="50" />
                            <Gasto TipoDeGasto="Regalo" Cantidad="125" />
                            <Gasto TipoDeGasto="Camara" Cantidad="500" />
                        </Nombre>
                        <Nombre Nombre="Juan" Departamento="Ingenieria">
                            <Gasto TipoDeGasto="Suscripcion" Cantidad="50" />
                            <Gasto TipoDeGasto="Maquinas" Cantidad="600" />
                            <Gasto TipoDeGasto="Software" Cantidad="500" />
                        </Nombre>
                        <Nombre Nombre="María" Departamento="Finanzas">
                            <Gasto TipoDeGasto="Cena" Cantidad="100" />
                            <Gasto TipoDeGasto="Compra" Cantidad="120" />
                        </Nombre>
                    </Gastos>        5)      �� 5+      .R�5,      �� ��6   �� $ @Nombre��5-      5/      ��52   
   �� 53       �� ImageSource$ FondoRegistro.png��6    � ColumnDefinitions 56   
   �� 57      $	��230 �6   �� 58      �� 59       � RowDefinitions 5=   
   �� 5>      �� 5?      $
��Auto �6   �� 5@      �� 5A      $
��Auto �6   �� 5B      .+�5H   
   �� $��50��6   $��0��6     headerTextStyle#��[ 6,   $��
44,0,266,0q�6U   $��2��6i   .��6~   Ver informe de gastos5J      �� 5K   
   $��1��6   $��1��6!     listHeaderStyle#��[ 6.   ._�5L      ��   listHeaderTextStyle#��[ 6   .��6A   
Personas6K   5M      �� 5N   
   -   5        $��peopleListBox��5N      $��1��6'   $��2��67   #��[ 5P   
   ��5O   
   ��  �� Source# [  $ Nombre��5Q      �� 5U   
   -   5        $��1��5U      $��3��6!     buttonStyle#��[ 6C   .��6h   	Consultar6s   5X      5Y      