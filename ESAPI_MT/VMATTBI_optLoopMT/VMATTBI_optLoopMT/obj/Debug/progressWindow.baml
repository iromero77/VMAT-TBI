   M S B A M L   `   `   `  ����Q  MVMATTBI_optLoopMT_v1.0, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null1clr-namespace:VMATTBI_optLoopVMATTBI_optLoop  5   	   $    VMATTBI_optLoop.progressWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:VMATTBI_optLoop     5   	   -   5        $��Center=�5   	   $	��605��6&   $	��815��63   
�������.��5	      � .+�5
   
   �� $#��Progress of Optimization Loop��6   $��20(�68   $
��Bold"�6F   $	��Top=�6X   $��Center=�6p   $��5q�6�   6�   �� 5   
   -   5          ��Name$  scroller��5      $��Bottom=�6*   $��Center=�6E   $	��795��6b   $	��490��6n   $��0,0,0,35q�6{   
���   �.��5      �� -   5         ��Name$ update��5      $��12(�6(   $��Courier New)�66   $	��775��6O   
�������6q   5      �� 5   
   -   5         ��Name$ abort��5      $��Abort��6    $
��Left=�60   $��20��6K   $��70��6W   $��35,0,0,6q�6b   $��Bottom=�6t   6�   �� 5   
   -   5         ��Name$ abortStatus��5       �� TextAlignment$ Center=�6'   
�������$
��Left=�6Q   $��Bottom=�6l   $��20��6�   $	��120��6�   $��	125,0,0,6q�6�   6�   �� 5   
   -   5        $ write��5      $��Write results to file��6    $
��Left=�6@   $��20��6[   $	��120��6g   $��	295,0,0,6q�6s   $��Bottom=�6�   6�   � 5   
   $	��210��6   $��29��6   $��Bottom=�6'   $��Right=�6B   $��	0,0,135,2q�6^   .+�5      �� $��
Progress: ��6   $��Center=�6)   $��Right=�6D   $��	0,0,150,0q�6`   6u   � 5      -   5        $��progress��5   �   $��Right=�6   $��20��66   $��0,0,0,0q�6B   $��Center=�6S   $	��150��6n    � Minimum$ 0Q�6z    � Maximum$	 100Q�6�   
���2�2�6�   �� 5      $��Right=�6a   $��Center=�6}   $��0,0,65,0q�6�   ��6   ��  �� ElementName$ progress�� �� Path$ Value�	 �� StringFormat$	 {0:0}%��6�   5      �� 5   
   -   5        $ runTime��5      $��16(�6%   $	��100��63   
 �� TextAlignment$
 Center=�6?   $��Bottom=�6V   $��Right=�6q   $��0,0,5,8q�6�   
���   �6�   5      5      