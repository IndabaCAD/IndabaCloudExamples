   M S B A M L   `   `   `  ����  IndabaCloudChat     IndabaCloudChat.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6    � RowDefinitions 5
   
   �� 5      $��40 �6   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   �� $��0��6   $��0��6!   $��Name: ��61   $��Right=�6?   $��Center=�6[   �� 5   
   $��1��6   $��0��6    $��2��60   ��6D   ��  �� Path$ 	ChatLines� �� Mode$ OneWay=��� 5   
   $��0��6   $��1��6   $��Stretch=�6/   $��5q�6M   ��6X   �� $ Chatter�$ TwoWay=��� 5   
   $��2��6   $��0��6!   $��	Message: ��61   $��Right=�6B   $��Center=�6^   �� 5   
   $��2��6   $��1��6   $��Stretch=�6/   $��	5,5,100,5q�6M   ��6`   �� $ ChatLine�$ TwoWay=��� 5   
   -   5         ��Name$ btSent��5      $��2��6!   $��1��6.   $��Right=�6>   $��80��6Z   $��5q�6e   $
��Send��6p   ��6   �� $ LineSentCommand�5      5      