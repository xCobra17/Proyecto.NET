   M S B A M L   `   `   `  ����@  <Login, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:LoginLogin  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5	   	   &     Login.Pages.Productor.vProductor   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Login     5   	   R NMahApps.Metro.IconPacks, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null=	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks  5   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5	   	   $��0q�5
   	      AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow    	GlowBrush#  �   5   	    � 
ResizeMode$ CanResizeWithGrip=�5   	      WindowTransitionsEnabled .   � WindowStartupLocation$ CenterScreen=�5   	    � Title$ Administrador��5   	   $	��720��6   $
��1280��6,   .��5      �� $
��1280��6   $	��720��6   .+�5   
   � $
��1280��6   $	��720��6    � RowDefinitions 5      �� 5      $��7* �6    �� 5      $	��23* �6    ��5      �� 5       �� ImageSource$' !/Login;component/Resources/we.jpg��6   .+�5      �� -   5         ��Name$ image��5      $
��Left=�6#   $��94��6>   $��1100,15,0,0q�6J   $	��Top=�6_   $	��170��6w   $1��+/Login;component/Resources/feriavirtual.PNG��6�    J� Opacity$ 1Q�6�   �� 5      $
��Left=�6   $	��710��63   
���   �$	��Top=�6O   $
��1280��6g   $��2��6t   ��5      �� 5      	 �� Color$	 	#FF151515��6&   
 �� Opacity$

 0.60Q�68   5      !  MahApps.Metro.Controls.Tile  5      $��195,33,905,339q�6   $
��Auto��64   $
��Auto��6A      Title$ Crear Frutas��6O   $��1��6d   ��5       �� 5!      $	 	#CCE51400��6&   $

 0.85Q�68   .��5#      .  (MahApps.Metro.IconPacks.PackIconMaterial  E AControlzEx, Version=3.0.2.4, Culture=neutral, PublicKeyToken=null�  �ControlzEx.PackIconBase`1[[MahApps.Metro.IconPacks.PackIconMaterialKind, MahApps.Metro.IconPacks, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null]]   Kind$ 	FoodApple=�6-   $��Center=�6>   $��Center=�6Y   
�������$��75��6�   $��75��6�    �� Left$	 174��6�   
 �� Top$	 208��6�   5$        5%      $��380,33,428,339q�6   $
��Auto��64   $
��Auto��6A   $ Crear Ventas��6O   $��1��6d   ��5&      �� 5'      $	 	#CCE51400��6&   $

 0.85Q�68   .��5)        $ Finance=�6-   $��Center=�6<   $��Center=�6W   
�������$��75��6�   $��75��6�   $	 174��6�   $	 208��6�   5*        5+      $��10,218,798,154q�6   $
��Auto��64   $
��Auto��6A   $ Administrar Contratos��6O   $��1��6m   ��5,      �� 5-      $	 	#CCE51400��6&   $

 0.85Q�68   .��5/        $ FilePdf=�6-   $��Center=�6<   $��Center=�6W   
�������$��75��6�   $��75��6�   $	 174��6�   $	 208��6�   50        51      $��487,218,428,154q�6   $
��Auto��65   $
��Auto��6B   $ Administrar Transporte��6P   $��1��6o   ��52      �� 53      $	 	#CCE51400��6&   $

 0.85Q�68   .��55        $ TruckDelivery=�6-   $��Center=�6B   $��Center=�6]   
�������$��75��6�   $��75��6�   $	 174��6�   $	 208��6�   56        57      -   5        $��857,33,230,154q�57      $
��Auto��64   $
��Auto��6A   $ Configuraciones��6O   $��1��6g   ��58      �� 59      $	 	#CCE51400��6&   $

 0.85Q�68   .��5;        $ Settings=�6-   $��Center=�6=   $��Center=�6X   
�������$��75��6�   $��75��6�   $	 174��6�   $	 208��6�   5<      �� 5=      -   5         ��Name$ label��5=      $��Bienvenido Productor��6#   $
��Left=�6B   $��
155,64,0,0q�6]   $	��Top=�6q   
������ 
�������$��55��6�   $	��289��6�   $��22(�6�     5>      ���	#CC3E3A3A$��25,24,1154,37q�63   $ 1Q�6J   $
��Auto��6V   $
��Auto��6d   .��5?        $ Account=�6-   $��Center=�6<   $��Center=�6W   
�������$��75��6�   $��75��6�   $	 174��6�   $	 208��6�   5@      #  MahApps.Metro.Controls.Flyout  5A      -   5          Name$ Configuracion��5A         Position$ Right=�65   $��2��6F   $	��230��6W   
�������$��Configuraciones��6v   ��5B      �� 5C      $	 	#FF232323��6&   $	
 0.9Q�68   .��5E      �� .+�5F        $��0q�6$   $ 48��6/   $	 477��6@   $	��125��6Q   $	��126��6^   $ Cerrar Sesion��6j      HorizontalTitleAlignment$ Center=�6�   ��6�   Z� .��5G        $ Logout=�65   $��Center=�6C   $��Center=�6^   
�������$��55��6�   $��55��6�   $	 174��6�   $	 208��6�   5H      5I      5J      5K      5L      5M      