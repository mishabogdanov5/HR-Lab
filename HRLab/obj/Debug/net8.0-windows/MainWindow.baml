   M S B A M L   `   `   `  ����@  <HrLab, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LoadDataAppLoadDataApp  5   	       LoadDataApp.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:LoadDataApp     5   	     � Title$  
MainWindow��5   	   $
��1600��6   $	��640��6,    � WindowState$ 	Maximized=�6<   .��5	      ]� $��0,0,0,0q�6   .+�5   
   �� -   5         ��Name$ 	AddButton��5      $	��Top=�6$   $��Add New Condidate��6:   $��0, 100, 0, 40q�6V   
��� ���$��80, 10, 80, 10q�6�   $��Center=�6�   $��Center=�6�   $��16(�6�   6�   �� 5   
   -   5         ��Name$ SortingComboBox��5   7   $	��Top=�6    �� Text$ Sorting��6(   $	��150��6P   $
��Left=�6\   $��	30, 0,0,0q�6w   .@�5      �� -   5         ��Name$
 Date��5   >   $2��,По дате добавления возр.��6    �� 
IsSelected$
 True��6L   �� 5      -   5        $ DateDescending��5   >   $2��,По дате добавления убыв.��6   6>   �� 5      -   5        $
 Mark��5   5   $!��По оценке возр.��6   65   �� 5      -   5        $ MarkDescending��5   5   $!��По оценке убыв.��6   65   5      �� 5   
   -   5         ��Name$ 
ScrollItem��5      $
��Auto=�6+   $��50q�6N   $	��Top=�6Z   $
��1400��6o   .��5      �� -   5         ��Name$ CondidatesList��5      $
��1380��6.   5      5      5      5      