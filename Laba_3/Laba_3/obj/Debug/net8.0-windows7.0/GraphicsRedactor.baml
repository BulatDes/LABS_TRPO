   M S B A M L   `   `   `  ����A  =Laba_3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Laba_3Laba_3  5   	       Laba_3.GraphicsRedactor   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Laba_3     5   	     � Title$  GraphicsRedactor��5   	   $	��450��6"   $	��800��6/    � 	Resources 5	      �� 5
   
      KeyMyEditingModes   �� Type2  ,System.Windows.Controls.InkCanvasEditingMode"  6)   .s�5      ��  �� Member$ InkCanvasEditingMode.Ink��6   �� 5      $! InkCanvasEditingMode.Select��6   �� 5      $' !InkCanvasEditingMode.EraseByPoint��6   �� 5      $( "InkCanvasEditingMode.EraseByStroke��6   5      �� 5   
   MyDrawingAttributes  *  $System.Windows.Ink.DrawingAttributes"  6.   .s�5           Color$	 Red��6       Width$ 3Q�6,      Height$ 1Q�66     5      $ Green��6    $ 1Q�6.   $ 1Q�68     5      $
 Blue��6    $ 1Q�6-   $ 1Q�67     5      $ Yellow��6    $ 1Q�6/   $ 1Q�69     5      $ Black��6    $ 1Q�6.   $ 1Q�68   5      �� 5   
    �� 
TargetType" ��6   .�5      ��  �� Property � ��	 �� Value
	 �   �6+   5      �� 5   
   " ��6   .�5      ��  � ��
	 ���_�6+   5      .��5       � 
 � ColumnDefinitions
 5!   
   �� 5"      $��5* �6   �� 5#      $��5* �6   �� 5$      $��5* �6    � RowDefinitions 5&   
   �� 5'      $��2* �6   �� 5(      $	��10* �6   .+�5+   
   �� -   5        $��	ColorCmbx��5+       �� SelectedIndex$ 0��6$     MyDrawingAttributes#��[ 66   $��10q�6j   $��20��6v   ��5,      �� 5-      .R�5.      �� ��6    ��  �� Path$ Color�5/      51      �� 53   
   $��Размер кисти��6   $��1��6'   $��0,0,0,0q�67   6J   �� 54   
   -   5         ��Name$ 	brushSize��54       � Minimum$ 1Q�6%    � Maximum$ 20Q�61    �� IsMoveToPointEnabled$
 True��6�   $��1��6�   $��20q�6�    � Value 6>   ��  �� ElementName$ 	canvasink��$$ DefaultDrawingAttributes.Width�6�   �� 56   
   -   5         ��Name$ ModeBox��56   {   $��2��6   $	��200��6#   $��20��6/     MyEditingModes#��[ 6;   $ 0��6i   58      �� 59   
   -   5        $��	canvasink��59   5   $��3��6   $��1��6(    �� 
Background
 ����� �� DefaultDrawingAttributes 6G   �� $ 	ColorCmbx��$ SelectedValue� �� EditingMode 6�   �� $ ModeBox��$ SelectedValue�6�   5:      5;      