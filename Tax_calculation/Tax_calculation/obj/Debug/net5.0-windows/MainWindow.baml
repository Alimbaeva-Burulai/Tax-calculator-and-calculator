   M S B A M L   `   `   `  ����J  FTax_calculation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Tax_calculationTax_calculation  5   	        Tax_calculation.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Tax_calculation     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� $��Income��6   $
��Left=�6!   $��	72,64,0,0q�6<   $	��Top=�6O   $��62��6g   $��25��6r   �� 5   
   $	��Tax��6   $
��Left=�6   $��
72,125,0,0q�69   $	��Top=�6M   $��62��6e   $��25��6p   �� 5   
   $��Prepaid��6   $
��Left=�6"   $��
72,192,0,0q�6=   $	��Top=�6Q   $��62��6i   $��25��6t   �� 5   
   -   5         ��Name$ 	txtIncome��5      $
��Left=�6%   $��
180,68,0,0q�6@   $��0��6T    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��112��6�   $��21��6�   �� 5   
   -   5        $ txttaxPercent��5      $
��Left=�6)   $��180,138,0,0q�6D   $��0��6Y   $
 Wrap=�6b   $	��Top=�6v   $	��112��6�   $��20��6�   �� 5   
   -   5        $ 
txtPrepaid��5      $
��Left=�6&   $��180,194,0,0q�6A   $��0��6V   $
 Wrap=�6_   $	��Top=�6s   $	��112��6�   $��20��6�   �� 5   
   -   5        $��	Calculate��5      $
��Left=�6?   $��
416,68,0,0q�6Z   $	��Top=�6n   $��90��6�   $��80��6�   �� 5   
   -   5         ��Name$ 	lblResult��5      $��Results go here!��6#   $
��Left=�6>   $��103,293,0,0q�6Y   $	��Top=�6n   $	��189��6�   5      5      