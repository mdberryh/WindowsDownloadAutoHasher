   M S B A M L   `   `   `  ����T  PDownloadWatcherHashHelper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:DownloadWatcherHashHelperDownloadWatcherHashHelper  5      2    ,DownloadWatcherHashHelper.FileHashingControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:DownloadWatcherHashHelper     5      -   5        
�������$	��150��5   F     J� 	AllowDrop  . $��5q�5	      .��5      � -   5         �Name$ grdFileHashCnt��5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   � $
��Auto��6   $��0��6   $��0,0,0,0q�6*   $��Center=�6;    � ColumnDefinitions 5      �� 5      $��75 �6#   �� 5      $	��150 �6#   �� 5      $��75 �6#   .+�5      �� $��	File Name��6   $��0��6)   $��Stretch=�69   $��Stretch=�6W   6u   �� 5      -   5        $��txtBxFileName��5      $�� ��6   $��1��63   $��Stretch=�6C   $��Stretch=�6a    �� TextWrapping$
 Wrap=�6}   6�   �� 5      $��2��6   $��Center=�6)   .+�5      �� -   5        $��btnFileBrowse��5   *   $��Browse��6   6]   5      5      � 5   
   $
��Auto��6   $��1��6   $��Center=�6*    5       �� 5!      $��75 �6#   �� 5"      $	��150 �6#   �� 5#      $��75 �6#   .+�5%      �� $��	File Hash��6   $��0��6)   $��Stretch=�69   $��Stretch=�6W   6u   �� 5&      -   5        $��txtBxFileHash��5.      $�� ��6   $��1��5/      $��Stretch=�50      $��Stretch=�6/   $
 Wrap=�6K   6a   �� 51      $��2��6   $��Center=�6)   .+�53      �� -   5        $��cmbHashType��53       �� Text$ Sha256��6.   .@�54      �� -   5        $
��cbi1��54   #   .��6/   MD564   �� 55      -   5        $
��cbi2��55   #   .��6/   Sha25667   56      57      58      � 59   
   $
��Auto��6   $��2��6   $��Center=�6*    5:      �� 5;      $��75 �6#   �� 5<      $	��150 �6#   �� 5=      $��75 �6#   .+�5?      �� $��	File Size��6   $��0��6)   $��Stretch=�69   $��Stretch=�6W   6u   �� 5@      -	   5        $��txtBxFileSize��5@   0    �� 
IsReadOnly . $�� ��6(   $��1��6E   $��Stretch=�6U   $��Stretch=�6s   $
 Wrap=�6�   6�   �� 5A      $��2��6   $��Center=�6)   .+�5B      �� $��Bytes��6   6+   5D      5E      5G      5I      